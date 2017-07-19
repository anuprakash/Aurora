﻿using Aurora.EffectsEngine;
using Aurora.Settings;
using Aurora.Settings.Layers;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aurora.Profiles.Borderlands2
{
    public class Borderlands2Profile : ApplicationProfile
    {
        public Borderlands2Profile() : base()
        {
            
        }

        public override void Reset()
        {
            base.Reset();
            Layers = new System.Collections.ObjectModel.ObservableCollection<Layer>()
            {
                //new Layer("Health Indicator", new PercentLayerHandler()
                //{
                //    Properties = new PercentLayerHandlerProperties()
                //    {
                //        _PrimaryColor = Color.Red,
                //        _SecondaryColor = Color.DarkRed,
                //        _PercentType = PercentEffectType.Progressive_Gradual,
                //        _Sequence = new KeySequence(new Devices.DeviceKeys[] {
                //            Devices.DeviceKeys.ONE, Devices.DeviceKeys.TWO, Devices.DeviceKeys.THREE, Devices.DeviceKeys.FOUR, Devices.DeviceKeys.FIVE,
                //            Devices.DeviceKeys.SIX, Devices.DeviceKeys.SEVEN, Devices.DeviceKeys.EIGHT, Devices.DeviceKeys.NINE, Devices.DeviceKeys.ZERO,
                //            Devices.DeviceKeys.MINUS, Devices.DeviceKeys.EQUALS
                //        }),
                //        _BlinkThreshold = 0.0,
                //        _BlinkDirection = false,
                //        _VariablePath = "Player/currentHealth",
                //        _MaxVariablePath = "Player/maximumHealth"
                //    },
                //}),
                //new Layer("Shield Indicator", new PercentLayerHandler()
                //{
                //    Properties = new PercentLayerHandlerProperties()
                //    {
                //        _PrimaryColor =  Color.Cyan,
                //        _SecondaryColor = Color.DarkCyan,
                //        _PercentType = PercentEffectType.Progressive_Gradual,
                //        _Sequence = new KeySequence(new Devices.DeviceKeys[] {
                //            Devices.DeviceKeys.F1, Devices.DeviceKeys.F2, Devices.DeviceKeys.F3, Devices.DeviceKeys.F4,
                //            Devices.DeviceKeys.F5, Devices.DeviceKeys.F6, Devices.DeviceKeys.F7, Devices.DeviceKeys.F8,
                //            Devices.DeviceKeys.F9, Devices.DeviceKeys.F10, Devices.DeviceKeys.F11, Devices.DeviceKeys.F12
                //        }),
                //        _BlinkThreshold = 0.0,
                //        _BlinkDirection = false,
                //        _VariablePath = "Player/currentShield",
                //        _MaxVariablePath = "Player/maximumShield"
                //    },
                //}),
                new Layer("Borderlands 2 Background", new Layers.Borderlands2BackgroundLayerHandler())
            };
        }
    }
}
