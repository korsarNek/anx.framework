﻿using System;
using System.Collections.Generic;
using System.IO;
using ANX.Framework.NonXNA;
using ANX.Framework.NonXNA.Development;
using ANX.Framework.NonXNA.SoundSystem;

// This file is part of the ANX.Framework created by the
// "ANX.Framework developer group" and released under the Ms-PL license.
// For details see: http://anxframework.codeplex.com/license

namespace ANX.Framework.Audio
{
	[PercentageComplete(100)]
    [Developer("AstrorEnales")]
    [TestState(TestStateAttribute.TestState.InProgress)]
	public sealed class SoundEffect : IDisposable
	{
		#region Static
	    public static float DistanceScale
	    {
	        get 
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    return creator.DistanceScale;
                }

                return 0.0f; 
            }
	        set 
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    creator.DistanceScale = value;
                }
                else
                {
                    throw new InvalidOperationException("couldn't set DistanceScale because no supported SoundSystem was found");
                }
            }
	    }

	    public static float DopplerScale
	    {
            get
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    return creator.DopplerScale;
                }

                return 0.0f;
            }
            set
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    creator.DopplerScale = value;
                }
                else
                {
                    throw new InvalidOperationException("couldn't set DopplerScale because no supported SoundSystem was found");
                }
            }
        }

	    public static float MasterVolume
	    {
            get
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    return creator.MasterVolume;
                }

                return 0.0f;
            }
            set
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    creator.MasterVolume = value;
                }
                else
                {
                    throw new InvalidOperationException("couldn't set MasterVolume because no supported SoundSystem was found");
                }
            }
	    }

	    public static float SpeedOfSound
	    {
            get
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    return creator.SpeedOfSound;
                }

                return 0.0f;
            }
            set
            {
                ISoundSystemCreator creator = GetCreator();
                if (creator != null)
                {
                    creator.SpeedOfSound = value;
                }
                else
                {
                    throw new InvalidOperationException("couldn't set SpeedOfSound because no supported SoundSystem was found");
                }
            }
        }
		#endregion

		#region Private
		private static readonly List<SoundEffectInstance> fireAndForgetInstances = new List<SoundEffectInstance>();
        private static ISoundSystemCreator creator;
		private readonly List<WeakReference> children;
		internal ISoundEffect NativeSoundEffect;
		#endregion

		#region Public
		public TimeSpan Duration
		{
			get
			{
				return NativeSoundEffect.Duration;
			}
		}

		public bool IsDisposed
		{
			get;
			private set;
		}

		public string Name
		{
			get;
			set;
		}
		#endregion

		#region Constructor
		private SoundEffect()
		{
			children = new List<WeakReference>();
			IsDisposed = false;
		}

		private SoundEffect(Stream stream)
			: this()
		{
			var creator = GetCreator();
			NativeSoundEffect = creator.CreateSoundEffect(this, stream);
		}

		public SoundEffect(byte[] buffer, int sampleRate, AudioChannels channels)
			 : this(buffer, 0, buffer.Length, sampleRate, channels, 0, 0)
		{
		}

		public SoundEffect(byte[] buffer, int offset, int count, int sampleRate, AudioChannels channels, int loopStart,
            int loopLength)
			: this()
		{
			var creator = GetCreator();
			NativeSoundEffect = creator.CreateSoundEffect(this, buffer, offset, count, sampleRate, channels, loopStart,
                loopLength);
		}

		~SoundEffect()
		{
			Dispose();
		}
		#endregion

		#region GetCreator
		private static ISoundSystemCreator GetCreator()
		{
            if (creator == null)
            {
                creator = AddInSystemFactory.Instance.GetDefaultCreator<ISoundSystemCreator>();
                AddInSystemFactory.Instance.PreventSystemChange(AddInType.SoundSystem);

                //We are once setting the default values, which means, we don't support chaning the sound system later on, otherwise we would have
                //uninitiliazed values.
                MasterVolume = 1f;
                SpeedOfSound = 343.5f;
                DopplerScale = 1f;
                DistanceScale = 1f;
            }

			return creator;
		}
		#endregion

		#region CreateInstance
		public SoundEffectInstance CreateInstance()
		{
			return new SoundEffectInstance(this, false);
		}
		#endregion

		#region FromStream
		public static SoundEffect FromStream(Stream stream)
		{
			return new SoundEffect(stream);
		}
		#endregion

		#region GetSampleDuration
		public static TimeSpan GetSampleDuration(int sizeInBytes, int sampleRate, AudioChannels channels)
		{
			float sizeMulBlockAlign = (float)sizeInBytes / ((int)channels * 2);
			return TimeSpan.FromMilliseconds(sizeMulBlockAlign * 1000f / sampleRate);
		}
		#endregion

		#region GetSampleSizeInBytes
		public static int GetSampleSizeInBytes(TimeSpan duration, int sampleRate, AudioChannels channels)
		{
			int timeMulSamples = (int)(duration.TotalMilliseconds * (sampleRate / 1000f));
			return (timeMulSamples + timeMulSamples % (int)channels) * ((int)channels * 2);
		}
		#endregion

		#region Play
		public bool Play()
		{
			return Play(1f, 1f, 0f);
		}

		public bool Play(float volume, float pitch, float pan)
		{
			if (IsDisposed)
				return false;

			try
			{
			    var newInstance = new SoundEffectInstance(this, true)
			    {
			        Volume = volume,
			        Pitch = pitch,
			        Pan = pan,
			    };

				children.Add(new WeakReference(newInstance));

				lock (fireAndForgetInstances)
					fireAndForgetInstances.Add(newInstance);

				newInstance.Play();
			}
			catch (Exception ex)
			{
				Logger.Warning("Failed to play sound effect cause of: " + ex);
				return false;
			}

			return true;
		}
		#endregion

        #region RecycleStoppedFireAndForgetInstances
        internal static void RecycleStoppedFireAndForgetInstances()
        {
            lock (fireAndForgetInstances)
            {
                var instancesToDispose = new List<SoundEffectInstance>();
                foreach (SoundEffectInstance current in fireAndForgetInstances)
                    if (current.State == SoundState.Stopped)
                        instancesToDispose.Add(current);

                foreach (SoundEffectInstance current in instancesToDispose)
                {
                    current.Dispose();
                    fireAndForgetInstances.Remove(current);
                }
            }
        }
        #endregion

        #region Dispose
        public void Dispose()
		{
			if (IsDisposed)
				return;

			IsDisposed = true;
			NativeSoundEffect.Dispose();
			NativeSoundEffect = null;

			var weakRefs = new List<WeakReference>(children);

			lock (fireAndForgetInstances)
			{
				foreach (WeakReference current in weakRefs)
				{
					var soundInstance = current.Target as SoundEffectInstance;
				    if (soundInstance == null)
				        continue;

				    if (soundInstance.IsFireAndForget)
				        fireAndForgetInstances.Remove(soundInstance);
				    soundInstance.Dispose();
				}
			}

			weakRefs.Clear();
			children.Clear();
		}
		#endregion
	}
}
