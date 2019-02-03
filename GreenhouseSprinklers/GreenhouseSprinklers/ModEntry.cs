﻿using System;
using Bpendragon.GreenhouseSprinklers.Data;
using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace Bpendragon.GreenhouseSprinklers
{
    partial class ModEntry : Mod
    {
        private ModConfig Config;
        private ModData Data;

        public override void Entry(IModHelper helper)
        {
            this.Config = this.Helper.ReadConfig<ModConfig>();
            Data = this.Helper.Data.ReadJsonFile<ModData>($"data/{Constants.SaveFolderName}.json") ?? new ModData();

            helper.Events.GameLoop.DayStarted += this.OnDayStart;
            helper.Events.GameLoop.TimeChanged += this.OnTimeChanged;
            helper.Events.GameLoop.Saving += this.OnSave;
            helper.Events.GameLoop.SaveLoaded += this.OnLoad;

        }


    }
}
