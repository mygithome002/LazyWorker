﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyWorkerTool
{
    class ExtendedCostGenerator
    {
        public static void GenerateExtendedCost(string ID, string ReqHonor, string ReqArenaPoints, string ReqArenaSlot,
            string ReqItem1, string ReItemCount1, string ReqItem2, string ReItemCount2,
            string ReqItem3, string ReItemCount3, string ReqItem4, string ReItemCount4, string ReqItem5, string ReItemCount5,
            string ReqPersonalRating)
        {
            StringBuilder ExtendedCost = new StringBuilder();
            string Separator = ",";
            string ItemExtendedCostCache;


            if (!Directory.Exists(@"./ExtendedCost"))
                Directory.CreateDirectory(@"./ExtendedCost");

            if (File.Exists(@"./ExtendedCost/ItemExtendedCost.dbc.csv"))
                ItemExtendedCostCache = File.ReadAllText(@"./ExtendedCost/ItemExtendedCost.dbc.csv");
            else
                ItemExtendedCostCache = "";

            ExtendedCost.AppendLine(ID + Separator + ReqHonor + Separator + ReqArenaPoints + Separator + ReqArenaSlot + Separator + ReqItem1 + Separator + 
                ReItemCount1 + Separator + ReqItem2 + Separator + ReItemCount2 + Separator + ReqItem3 + Separator + ReItemCount3 + Separator +
                ReqItem4 + Separator + ReItemCount4 + ReqItem5  + Separator + ReItemCount5 + Separator + ReqPersonalRating + ",0");


            File.WriteAllText("./ExtendedCost/ItemExtendedCost.dbc.csv", ItemExtendedCostCache + ExtendedCost.ToString());
        }
    }
}
