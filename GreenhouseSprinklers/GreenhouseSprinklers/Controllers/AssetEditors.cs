﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI;

namespace Bpendragon.GreenhouseSprinklers
{
    class MyModMail : IAssetEditor
    {
        public MyModMail()
        {

        }

        public bool CanEdit<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Data\\mail");
        }

        public void Edit<T>(IAssetData asset)
        {
            var data = asset.AsDictionary<string, string>().Data;

            data["Bpendragon.GreenhouseSprinklers.Wizard1"] = I18n.Mail_Wizard1();
            data["Bpendragon.GreenhouseSprinklers.Wizard1b"] = I18n.Mail_Wizard1b();
            data["Bpendragon.GreenhouseSprinklers.Wizard2"] = I18n.Mail_Wizard2();
            data["Bpendragon.GreenhouseSprinklers.Wizard3"] = I18n.Mail_Wizard3();
        }
    }
}
