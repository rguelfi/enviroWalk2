namespace EnviroWalk.DataModel.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EnviroWalk.DataModel.ContextEnviro>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EnviroWalk.DataModel.ContextEnviro context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

            //context.RepQuestion.RemoveRange(context.RepQuestion);
            //context.RepQuestionAction.RemoveRange(context.RepQuestionAction);
            //context.RepQuestionCusAction.RemoveRange(context.RepQuestionCusAction);
            //context.Report.RemoveRange(context.Report);
            //context.QuestionAction.RemoveRange(context.QuestionAction);
            //context.Question.RemoveRange(context.Question);
            //context.Category.RemoveRange(context.Category);
            //context.SaveChanges();

            var cat1 = new Category { CategoryID = 1, CategoryDescription = "Nutrient management" };
            var cat2 = new Category { CategoryID = 2, CategoryDescription = "Effluent management" };
            var cat3 = new Category { CategoryID = 3, CategoryDescription = "Waterways and biodiversity" };
            var cat4 = new Category { CategoryID = 4, CategoryDescription = "Water use and irrigation" };
            var cat5 = new Category { CategoryID = 5, CategoryDescription = "Land and soil management" };
            var cat6 = new Category { CategoryID = 6, CategoryDescription = "Storage Infrastructure & Waste Management" };
            context.Category.Add(cat1);
            context.Category.Add(cat2);
            context.Category.Add(cat3);
            context.Category.Add(cat4);
            context.Category.Add(cat5);
            context.Category.Add(cat6);
            //context.Category.AddOrUpdate( c => c.CategoryID, cat1, cat2, cat3, cat4, cat5, cat6 );
            context.SaveChanges();

            var ques1 = new Question { QuestionID = 1, QuestionDescription = "Maintain written records to enable annual completion of a nutrient budget", Category = cat1 };
            var ques2 = new Question { QuestionID = 2, QuestionDescription = "Use your nutrient budget to manage the use of nutrients on farm", Category = cat1 };
            var ques3 = new Question { QuestionID = 3, QuestionDescription = "Apply nitrogen fertiliser to match plant requirements and minimise losses", Category = cat1 };
            var ques4 = new Question { QuestionID = 4, QuestionDescription = "Monitor and maintain Olsen P levels at economic (biological, agronomical??) optimum", Category = cat1 };
            var ques5 = new Question { QuestionID = 5, QuestionDescription = "Fertiliser spreading equipment is well maintained and calibrated", Category = cat1 };

            var ques6 = new Question { QuestionID = 6, QuestionDescription = "Farm Dairy Effluent system and animal housing effluent is fit for purpose (capable of compliance 365 days a year)", Category = cat2 };
            var ques7 = new Question { QuestionID = 7, QuestionDescription = "Sufficient storage is available to allow for deferred irrigation and cover risky wet periods", Category = cat2 };
            var ques8 = new Question { QuestionID = 8, QuestionDescription = "Spreading equipment is well maintained and calibrated", Category = cat2 };
            var ques9 = new Question { QuestionID = 9, QuestionDescription = "Effluent is applied at the correct depth, rate and time", Category = cat2 };
            var ques10 = new Question { QuestionID = 10, QuestionDescription = "I have an effluent management plan", Category = cat2 };
            var ques11 = new Question { QuestionID = 11, QuestionDescription = "I record all effluent applications", Category = cat2 };
            var ques12 = new Question { QuestionID = 12, QuestionDescription = "I train staff on how to operate and maintain the effluent system", Category = cat2 };

            var ques13 = new Question { QuestionID = 13, QuestionDescription = "Stock are excluded from waterways and wetlands", Category = cat3 };
            var ques14 = new Question { QuestionID = 14, QuestionDescription = "Risk of runoff from laneways and stock crossings is reduced", Category = cat3 };
            var ques15 = new Question { QuestionID = 15, QuestionDescription = "Contaminant losses from paddock wintering is minimised", Category = cat3 };
            var ques16 = new Question { QuestionID = 16, QuestionDescription = "Develop a riparian management plan", Category = cat3 };
            var ques17 = new Question { QuestionID = 17, QuestionDescription = "Minimise losses of sediment and nutrient to water", Category = cat3 };

            var ques18 = new Question { QuestionID = 18, QuestionDescription = "Irrigation rates and timing match plant requirements", Category = cat4 };
            var ques19 = new Question { QuestionID = 19, QuestionDescription = "Design, calibrate and operate irrigation systems to use water efficiently", Category = cat4 };
            var ques20 = new Question { QuestionID = 20, QuestionDescription = "Efficient use of water in the dairy shed", Category = cat4 };
            var ques21 = new Question { QuestionID = 21, QuestionDescription = "Losses on the stock water/reticulation system are minimised", Category = cat4 };

            var ques22 = new Question { QuestionID = 22, QuestionDescription = "Protect soil structure with good grazing management", Category = cat5 };
            var ques23 = new Question { QuestionID = 23, QuestionDescription = "Reduce periods of bare soil between crops and pasture to minimise erosion and soil loss", Category = cat5 };
            var ques24 = new Question { QuestionID = 24, QuestionDescription = "Use appropriate paddocks for intensive grazing and/or cultivation", Category = cat5 };
            var ques25 = new Question { QuestionID = 25, QuestionDescription = "All active and potential erosion sites are managed to prevent further erosion and minimise sediment loss", Category = cat5 };
            var ques26 = new Question { QuestionID = 26, QuestionDescription = "Manage grazing to minimise nutrient losses from critical source areas", Category = cat5 };

            var ques27 = new Question { QuestionID = 27, QuestionDescription = "Farm waste is minimised and managed properly", Category = cat6 };
            var ques28 = new Question { QuestionID = 28, QuestionDescription = "Store and load fertiliser with minimal spillage and leaching", Category = cat6 };
            var ques29 = new Question { QuestionID = 29, QuestionDescription = "Store, transport and distribute feed with minimal wastage, leachate and soil damage and leaching", Category = cat6 };

            context.Question.AddOrUpdate(
              q => q.QuestionID, ques1, ques2, ques3, ques4, ques5, ques6, ques7, ques8, ques9, ques10,
              ques11, ques12, ques13, ques14, ques15, ques16, ques17, ques18, ques19, ques20,
              ques21, ques22, ques23, ques24, ques25, ques26, ques27, ques28, ques29);
            context.SaveChanges();

            var act1 = new QuestionAction { QuestionActionID = 1, QuestionActionDescription = "Record stock numbers on farm monthly", QuestionActionOrder = 1, Question = ques1 };
            var act2 = new QuestionAction { QuestionActionID = 2, QuestionActionDescription = "Record purchased feed amounts, types and when it was fed", QuestionActionOrder = 2, Question = ques1 };
            var act3 = new QuestionAction { QuestionActionID = 3, QuestionActionDescription = "Record all effluent (solid and liquid) applications rates and times", QuestionActionOrder = 3, Question = ques1 };
            var act4 = new QuestionAction { QuestionActionID = 4, QuestionActionDescription = "Record all fertiliser and nitrogen applications including the product, date, time and location", QuestionActionOrder = 4, Question = ques1 };
            var act5 = new QuestionAction { QuestionActionID = 5, QuestionActionDescription = "Record where crops are located", QuestionActionOrder = 5, Question = ques1 };
            var act6 = new QuestionAction { QuestionActionID = 6, QuestionActionDescription = "Include recent soil test results", QuestionActionOrder = 6, Question = ques1 };
            var act7 = new QuestionAction { QuestionActionID = 7, QuestionActionDescription = "Supply the nutrient information to your milk company at the end of each season", QuestionActionOrder = 7, Question = ques1 };

            var act8 = new QuestionAction { QuestionActionID = 8, QuestionActionDescription = "Nutrient budgets prepared by suitably qualified person and provides fertiliser recommendations", QuestionActionOrder = 1, Question = ques2 };
            var act9 = new QuestionAction { QuestionActionID = 9, QuestionActionDescription = "Apply fertiliser in accordance with the nutrient budget and soil test results", QuestionActionOrder = 2, Question = ques2 };
            var act10 = new QuestionAction { QuestionActionID = 10, QuestionActionDescription = "Nutrient budget reflects on farm practice", QuestionActionOrder = 3, Question = ques2 };

            var act11 = new QuestionAction { QuestionActionID = 11, QuestionActionDescription = "Assess soil temperature levels before applying fertiliser and don’t apply when under 6 degrees", QuestionActionOrder = 1, Question = ques3 };
            var act12 = new QuestionAction { QuestionActionID = 12, QuestionActionDescription = "Assess soil moisture levels before applying fertiliser and don’t apply when at or near field capacity", QuestionActionOrder = 2, Question = ques3 };
            var act13 = new QuestionAction { QuestionActionID = 13, QuestionActionDescription = "Avoid applying nitrogen fertiliser when heavy rainfall is forecast and runoff is likely", QuestionActionOrder = 3, Question = ques3 };
            var act14 = new QuestionAction { QuestionActionID = 14, QuestionActionDescription = "Avoid applying nitrogen fertiliser near or in waterways	", QuestionActionOrder = 4, Question = ques3 };
            var act15 = new QuestionAction { QuestionActionID = 15, QuestionActionDescription = "Assess crop or feed requirements before application (and refer to nutrient budget)", QuestionActionOrder = 5, Question = ques3 };
            var act16 = new QuestionAction { QuestionActionID = 16, QuestionActionDescription = "Apply nitrogen at the appropriate rates for plant uptake -little and often", QuestionActionOrder = 6, Question = ques3 };

            var act17 = new QuestionAction { QuestionActionID = 17, QuestionActionDescription = "Soil test annually on each different management block (area of your farm with a different soil type or type of management e.g. receives effluent, crops, irrigations)", QuestionActionOrder = 1, Question = ques4 };
            var act18 = new QuestionAction { QuestionActionID = 18, QuestionActionDescription = "Monitor the Olsen P level trends from soil tests", QuestionActionOrder = 2, Question = ques4 };
            var act19 = new QuestionAction { QuestionActionID = 19, QuestionActionDescription = "Tailor fertiliser applications in different management blocks to keep Olsen P in the optimum range (maintenance, capital or no fertiliser)", QuestionActionOrder = 3, Question = ques4 };

            var act20 = new QuestionAction { QuestionActionID = 20, QuestionActionDescription = "Calibrate farm spreading equipment regularly – check spreading width and volume", QuestionActionOrder = 1, Question = ques5 };
            var act21 = new QuestionAction { QuestionActionID = 21, QuestionActionDescription = "Clean and grease spreaders routinely", QuestionActionOrder = 2, Question = ques5 };
            var act22 = new QuestionAction { QuestionActionID = 22, QuestionActionDescription = "Check for ‘paddock stripes’ after spreading", QuestionActionOrder = 3, Question = ques5 };
            var act23 = new QuestionAction { QuestionActionID = 23, QuestionActionDescription = "If using contractors: Make sure they are Spreadmark accredited", QuestionActionOrder = 4, Question = ques5 };

            var act24 = new QuestionAction { QuestionActionID = 24, QuestionActionDescription = "The effluent application area is of sufficient size to maximise nutrient uptake", QuestionActionOrder = 1, Question = ques6 };
            var act25 = new QuestionAction { QuestionActionID = 25, QuestionActionDescription = "Effluent is collected from all sources: dairy yards, feed pads, underpasses", QuestionActionOrder = 2, Question = ques6 };
            var act26 = new QuestionAction { QuestionActionID = 26, QuestionActionDescription = "Has an Effluent Management Plan?", QuestionActionOrder = 3, Question = ques6 };
            var act27 = new QuestionAction { QuestionActionID = 27, QuestionActionDescription = "A system designed to be appropriate for the soil type, topography, and climate", QuestionActionOrder = 4, Question = ques6 };

            var act28 = new QuestionAction { QuestionActionID = 28, QuestionActionDescription = "Used the Dairy Effluent Storage Calculator to work out storage needs", QuestionActionOrder = 1, Question = ques7 };
            var act29 = new QuestionAction { QuestionActionID = 29, QuestionActionDescription = "Used an accredited effluent designer, if building new storage", QuestionActionOrder = 2, Question = ques7 };
            var act30 = new QuestionAction { QuestionActionID = 30, QuestionActionDescription = "Apply effluent whenever possible to keep storage low", QuestionActionOrder = 3, Question = ques7 };
            var act31 = new QuestionAction { QuestionActionID = 31, QuestionActionDescription = "Effluent storage facilities are sealed", QuestionActionOrder = 4, Question = ques7 };
            var act32 = new QuestionAction { QuestionActionID = 32, QuestionActionDescription = "A routine to remove effluent solids that accumulate", QuestionActionOrder = 5, Question = ques7 };
            var act33 = new QuestionAction { QuestionActionID = 33, QuestionActionDescription = "Safety barriers, equipment and signage", QuestionActionOrder = 6, Question = ques7 };

            var act34 = new QuestionAction { QuestionActionID = 34, QuestionActionDescription = "Calibrate effluent irrigator and/or spreading equipment", QuestionActionOrder = 1, Question = ques8 };
            var act35 = new QuestionAction { QuestionActionID = 35, QuestionActionDescription = "Inspect and maintain effluent equipment", QuestionActionOrder = 2, Question = ques8 };
            var act36 = new QuestionAction { QuestionActionID = 36, QuestionActionDescription = "Service effluent pumping equipment", QuestionActionOrder = 3, Question = ques8 };

            var act37 = new QuestionAction { QuestionActionID = 37, QuestionActionDescription = "Check the application depth and rate and maintain the irrigator if they are too high", QuestionActionOrder = 1, Question = ques9 };
            var act38 = new QuestionAction { QuestionActionID = 38, QuestionActionDescription = "Adjust effluent application timing and rates based on soil moisture levels", QuestionActionOrder = 2, Question = ques9 };
            var act39 = new QuestionAction { QuestionActionID = 39, QuestionActionDescription = "Spread nutrient load evenly across the largest area practical", QuestionActionOrder = 3, Question = ques9 };
            var act40 = new QuestionAction { QuestionActionID = 40, QuestionActionDescription = "Test for high potassium (K) levels on effluent block to avoid animal health issues", QuestionActionOrder = 4, Question = ques9 };
            var act41 = new QuestionAction { QuestionActionID = 41, QuestionActionDescription = "Adjust fertiliser application to effluent areas based on soil tests", QuestionActionOrder = 5, Question = ques9 };
            var act42 = new QuestionAction { QuestionActionID = 42, QuestionActionDescription = "Identify and record risk areas for effluent application on map", QuestionActionOrder = 6, Question = ques9 };
            var act43 = new QuestionAction { QuestionActionID = 43, QuestionActionDescription = "Consider odour impact during application", QuestionActionOrder = 7, Question = ques9 };

            var act44 = new QuestionAction { QuestionActionID = 44, QuestionActionDescription = "Fence all permanently flowing waterways (including wetlands)", QuestionActionOrder = 1, Question = ques13 };
            var act45 = new QuestionAction { QuestionActionID = 45, QuestionActionDescription = "Bridge or culvert across regular stock crossings", QuestionActionOrder = 2, Question = ques13 };
            var act46 = new QuestionAction { QuestionActionID = 46, QuestionActionDescription = "Temporarily fence any temporary or ephemeral streams if stock grazing the paddock they are in while water is flowing", QuestionActionOrder = 3, Question = ques13 };
            var act47 = new QuestionAction { QuestionActionID = 47, QuestionActionDescription = "Identify and record all waterways as well as wetlands ephemeral waterways and critical source areas on a map", QuestionActionOrder = 4, Question = ques13 };
            var act48 = new QuestionAction { QuestionActionID = 48, QuestionActionDescription = "Manage drains to prevent stock access if grazing the paddock they are in while water is flowing", QuestionActionOrder = 5, Question = ques13 };

            var act49 = new QuestionAction { QuestionActionID = 49, QuestionActionDescription = "Identify risk areas where surface runoff may enter waterways", QuestionActionOrder = 1, Question = ques14 };
            var act50 = new QuestionAction { QuestionActionID = 50, QuestionActionDescription = "Leave a grass buffer strip or riparian plantings between waterway and laneways", QuestionActionOrder = 2, Question = ques14 };
            var act51 = new QuestionAction { QuestionActionID = 51, QuestionActionDescription = "Ensure bridges and culverts have raised sides or mounds to avoid effluent and sediment flowing into the waterway", QuestionActionOrder = 3, Question = ques14 };
            var act52 = new QuestionAction { QuestionActionID = 52, QuestionActionDescription = "If the track is beside a waterway, slope the track in the opposite direction to avoid effluent and sediment flowing into the waterway", QuestionActionOrder = 4, Question = ques14 };
            var act53 = new QuestionAction { QuestionActionID = 53, QuestionActionDescription = "Maintain track cut offs to appropriately direct track runoff", QuestionActionOrder = 5, Question = ques14 };
            var act54 = new QuestionAction { QuestionActionID = 54, QuestionActionDescription = "Locate tracks away from waterway where practical", QuestionActionOrder = 6, Question = ques14 };

            var act55 = new QuestionAction { QuestionActionID = 55, QuestionActionDescription = "Leave a grass buffer strip or riparian plantings between waterway and fence", QuestionActionOrder = 1, Question = ques15 };
            var act56 = new QuestionAction { QuestionActionID = 56, QuestionActionDescription = "If cultivating paddocks leave an uncultivated buffer strip between cultivation and waterway (the steeper the land the wider the buffer needs to be)", QuestionActionOrder = 2, Question = ques15 };

            var act57 = new QuestionAction { QuestionActionID = 57, QuestionActionDescription = "Has a written riparian plan with short and long term actions including a map and planting plans", QuestionActionOrder = 1, Question = ques16 };
            var act58 = new QuestionAction { QuestionActionID = 58, QuestionActionDescription = "Map includes areas of existing planting", QuestionActionOrder = 2, Question = ques16 };
            var act59 = new QuestionAction { QuestionActionID = 59, QuestionActionDescription = "Plan includes maintenance requirements for existing and future plantings", QuestionActionOrder = 3, Question = ques16 };

            var act60 = new QuestionAction { QuestionActionID = 60, QuestionActionDescription = "Supplementary feed is fed away from waterways", QuestionActionOrder = 1, Question = ques17 };
            var act61 = new QuestionAction { QuestionActionID = 61, QuestionActionDescription = "Supplementary feed is rotated to avoid camping", QuestionActionOrder = 2, Question = ques17 };
            var act62 = new QuestionAction { QuestionActionID = 62, QuestionActionDescription = "Water troughs located away from waterways in a dry area of the paddock", QuestionActionOrder = 3, Question = ques17 };
            var act63 = new QuestionAction { QuestionActionID = 63, QuestionActionDescription = "Gateways are in a dry point", QuestionActionOrder = 4, Question = ques17 };
            var act64 = new QuestionAction { QuestionActionID = 64, QuestionActionDescription = "Gateways are wide enough for good cow flow to reduce pugging", QuestionActionOrder = 5, Question = ques17 };
            var act65 = new QuestionAction { QuestionActionID = 65, QuestionActionDescription = "Riparian margins or buffer strips beside waterways and other areas where sediment and nutrients may flow such as gullies or swales", QuestionActionOrder = 6, Question = ques17 };

            var act66 = new QuestionAction { QuestionActionID = 66, QuestionActionDescription = "No irrigation", QuestionActionOrder = 1, Question = ques18 };
            var act67 = new QuestionAction { QuestionActionID = 67, QuestionActionDescription = "Irrigate to replace soil moisture deficit only", QuestionActionOrder = 2, Question = ques18 };
            var act68 = new QuestionAction { QuestionActionID = 68, QuestionActionDescription = "Assess soil moisture levels and weather when scheduling irrigation by: Estimate soil moisture levels with a soil water budget or Monitor soil moisture levels with real time soil moisture equipment", QuestionActionOrder = 3, Question = ques18 };
            var act69 = new QuestionAction { QuestionActionID = 69, QuestionActionDescription = "Record irrigation events - when, where, amount", QuestionActionOrder = 4, Question = ques18 };
            var act70 = new QuestionAction { QuestionActionID = 70, QuestionActionDescription = "Measure all irrigation water use on farm with water meters", QuestionActionOrder = 5, Question = ques18 };
            var act71 = new QuestionAction { QuestionActionID = 71, QuestionActionDescription = "Monitor large water takes (e.g. with telemetry)", QuestionActionOrder = 6, Question = ques18 };

            var act72 = new QuestionAction { QuestionActionID = 72, QuestionActionDescription = "Use an accredited design and installation company – “Blue tick” for new irrigation system or upgrades", QuestionActionOrder = 1, Question = ques19 };
            var act73 = new QuestionAction { QuestionActionID = 73, QuestionActionDescription = "Evaluate irrigation system annually to check application efficiency and performance (consider using a skilled professional to assess)", QuestionActionOrder = 2, Question = ques19 };
            var act74 = new QuestionAction { QuestionActionID = 74, QuestionActionDescription = "Carry out routine bucket tests to assess performance", QuestionActionOrder = 3, Question = ques19 };
            var act75 = new QuestionAction { QuestionActionID = 75, QuestionActionDescription = "Inspect and maintain regularly", QuestionActionOrder = 4, Question = ques19 };
            var act76 = new QuestionAction { QuestionActionID = 76, QuestionActionDescription = "Train all staff using the system (Consider Irrigation NZ’s operator and manager training)", QuestionActionOrder = 5, Question = ques19 };

            var act77 = new QuestionAction { QuestionActionID = 77, QuestionActionDescription = "Shed water use measured with a water meter", QuestionActionOrder = 1, Question = ques20 };
            var act78 = new QuestionAction { QuestionActionID = 78, QuestionActionDescription = "Records of shed water usage are kept for comparison to current use", QuestionActionOrder = 2, Question = ques20 };
            var act79 = new QuestionAction { QuestionActionID = 79, QuestionActionDescription = "Alert systems are in place to highlight water leaks and losses in the shed", QuestionActionOrder = 3, Question = ques20 };
            var act80 = new QuestionAction { QuestionActionID = 80, QuestionActionDescription = "Leaks are fixed promptly", QuestionActionOrder = 4, Question = ques20 };
            var act81 = new QuestionAction { QuestionActionID = 81, QuestionActionDescription = "Train all staff in the shed water use procedures (especially around wash down and filling cylinders or tubs)", QuestionActionOrder = 5, Question = ques20 };

            var act82 = new QuestionAction { QuestionActionID = 82, QuestionActionDescription = "Alert systems are in place to highlight water leaks and losses in the stock water/reticulation system", QuestionActionOrder = 1, Question = ques21 };
            var act83 = new QuestionAction { QuestionActionID = 83, QuestionActionDescription = "Farm water system is mapped including sources, pipes, shut off valves and leak prone areas", QuestionActionOrder = 2, Question = ques21 };
            var act84 = new QuestionAction { QuestionActionID = 84, QuestionActionDescription = "Leaks are fixed promptly", QuestionActionOrder = 3, Question = ques21 };
            var act85 = new QuestionAction { QuestionActionID = 85, QuestionActionDescription = "Water troughs are check daily where animals are grazing", QuestionActionOrder = 4, Question = ques21 };
            var act86 = new QuestionAction { QuestionActionID = 86, QuestionActionDescription = "Train all staff in the stock water/reticulation system including an introduction to the map", QuestionActionOrder = 5, Question = ques21 };

            var act87 = new QuestionAction { QuestionActionID = 87, QuestionActionDescription = "Shift stock from saturated soils to dry areas or standoff", QuestionActionOrder = 1, Question = ques22 };
            var act88 = new QuestionAction { QuestionActionID = 88, QuestionActionDescription = "Avoid pugging and soil compaction", QuestionActionOrder = 2, Question = ques22 };
            var act89 = new QuestionAction { QuestionActionID = 89, QuestionActionDescription = "Use no/low tillage methods", QuestionActionOrder = 3, Question = ques22 };
            var act90 = new QuestionAction { QuestionActionID = 90, QuestionActionDescription = "Have written wet weather and winter management policies and procedures for the farm", QuestionActionOrder = 4, Question = ques22 };
            var act91 = new QuestionAction { QuestionActionID = 91, QuestionActionDescription = "Retire and fence off erosion prone areas", QuestionActionOrder = 5, Question = ques22 };
            var act92 = new QuestionAction { QuestionActionID = 92, QuestionActionDescription = "Erosion prone areas and critical source areas are mapped", QuestionActionOrder = 6, Question = ques22 };
            var act93 = new QuestionAction { QuestionActionID = 93, QuestionActionDescription = "Train all staff in the farms policies to protect soil structure", QuestionActionOrder = 7, Question = ques22 };

            var act94 = new QuestionAction { QuestionActionID = 94, QuestionActionDescription = "Re-sow bare paddocks as soon as practical", QuestionActionOrder = 1, Question = ques23 };
            var act95 = new QuestionAction { QuestionActionID = 95, QuestionActionDescription = "Rest erosion damaged areas from stock and machines and resow where possible", QuestionActionOrder = 2, Question = ques23 };
            var act96 = new QuestionAction { QuestionActionID = 96, QuestionActionDescription = "Cover crops (e.g. oats, mustard) are used to reduce losses and increase organic material", QuestionActionOrder = 3, Question = ques23 };
            var act97 = new QuestionAction { QuestionActionID = 97, QuestionActionDescription = "Choose subsoil, rip or cultivate methods for compacted soil", QuestionActionOrder = 4, Question = ques23 };
            var act98 = new QuestionAction { QuestionActionID = 98, QuestionActionDescription = "Have written cropping/pasture renewal policies and procedures for the farm", QuestionActionOrder = 5, Question = ques23 };

            var act99 = new QuestionAction { QuestionActionID = 99, QuestionActionDescription = "Sow crops across slopes not up and down where practical", QuestionActionOrder = 1, Question = ques24 };
            var act100 = new QuestionAction { QuestionActionID = 100, QuestionActionDescription = "Select paddocks that are further from waterways", QuestionActionOrder = 2, Question = ques24 };
            var act101 = new QuestionAction { QuestionActionID = 101, QuestionActionDescription = "Select paddocks which are least likely to pug", QuestionActionOrder = 3, Question = ques24 };
            var act102 = new QuestionAction { QuestionActionID = 102, QuestionActionDescription = "Select paddocks which are flatter with as few gullies and swales as possible", QuestionActionOrder = 4, Question = ques24 };

            var act103 = new QuestionAction { QuestionActionID = 103, QuestionActionDescription = "Assessed farm for vulnerable soils including for evidence of erosion, loss of vegetation cover, slippage or mass movement, deposition of eroded soil", QuestionActionOrder = 1, Question = ques25 };
            var act104 = new QuestionAction { QuestionActionID = 104, QuestionActionDescription = "Plot all erosion areas on a farm plan map", QuestionActionOrder = 2, Question = ques25 };
            var act105 = new QuestionAction { QuestionActionID = 105, QuestionActionDescription = "Managing areas of erosions through methods such as retirement from grazing, erosion control trees, surface water control, lower stocking rates, no cultivation, land use change etc.", QuestionActionOrder = 3, Question = ques25 };

            var act106 = new QuestionAction { QuestionActionID = 106, QuestionActionDescription = "If paddocks near waterways have to be used during wet periods, fence off a buffer strip beside the waterway", QuestionActionOrder = 1, Question = ques26 };
            var act107 = new QuestionAction { QuestionActionID = 107, QuestionActionDescription = "Offer more feed in cold conditions when demand is high and utilization low", QuestionActionOrder = 2, Question = ques26 };
            var act108 = new QuestionAction { QuestionActionID = 108, QuestionActionDescription = "When break feeding feed towards the waterway rather than beginning closest to the waterway", QuestionActionOrder = 3, Question = ques26 };
            var act109 = new QuestionAction { QuestionActionID = 109, QuestionActionDescription = "Move fences daily when break feeding rather than offering a few days feed at a time", QuestionActionOrder = 4, Question = ques26 };
            var act110 = new QuestionAction { QuestionActionID = 110, QuestionActionDescription = "Back-fence land that has already been grazed", QuestionActionOrder = 5, Question = ques26 };
            var act111 = new QuestionAction { QuestionActionID = 111, QuestionActionDescription = "Offer long narrow breaks rather than wide breaks", QuestionActionOrder = 6, Question = ques26 };
            var act112 = new QuestionAction { QuestionActionID = 112, QuestionActionDescription = "Avoid leaving stock on small sections of crops", QuestionActionOrder = 7, Question = ques26 };

            var act113 = new QuestionAction { QuestionActionID = 113, QuestionActionDescription = "Recycle waste where possible", QuestionActionOrder = 1, Question = ques27 };
            var act114 = new QuestionAction { QuestionActionID = 114, QuestionActionDescription = "Contain and remove waste from farm where feasible", QuestionActionOrder = 2, Question = ques27 };
            var act115 = new QuestionAction { QuestionActionID = 115, QuestionActionDescription = "Send dead animals for processing or correctly dispose on-farm", QuestionActionOrder = 3, Question = ques27 };
            var act116 = new QuestionAction { QuestionActionID = 116, QuestionActionDescription = "Any on-farm waste pits are small, away from waterways, and above the water table", QuestionActionOrder = 4, Question = ques27 };
            var act117 = new QuestionAction { QuestionActionID = 117, QuestionActionDescription = "Control pests around or in waste", QuestionActionOrder = 5, Question = ques27 };

            var act118 = new QuestionAction { QuestionActionID = 118, QuestionActionDescription = "Follow ‘Fertiliser Industry – Code of Practice’ for fertiliser handling, storage and use", QuestionActionOrder = 1, Question = ques28 };
            var act119 = new QuestionAction { QuestionActionID = 119, QuestionActionDescription = "Locate storage sites away from waterways on sealed surface", QuestionActionOrder = 2, Question = ques28 };
            var act120 = new QuestionAction { QuestionActionID = 120, QuestionActionDescription = "Ensure stored fertiliser is covered", QuestionActionOrder = 3, Question = ques28 };

            var act121 = new QuestionAction { QuestionActionID = 121, QuestionActionDescription = "Locate feed storage areas away from waterways", QuestionActionOrder = 1, Question = ques29 };
            var act122 = new QuestionAction { QuestionActionID = 122, QuestionActionDescription = "Store silage and other feeds on hard sealed areas and collect leachate", QuestionActionOrder = 2, Question = ques29 };
            var act123 = new QuestionAction { QuestionActionID = 123, QuestionActionDescription = "Divert overland flow and rain water away from feed storage area", QuestionActionOrder = 3, Question = ques29 };
            var act124 = new QuestionAction { QuestionActionID = 124, QuestionActionDescription = "Ensure silage has been sufficiently wilted before being put into stack", QuestionActionOrder = 4, Question = ques29 };
            var act125 = new QuestionAction { QuestionActionID = 125, QuestionActionDescription = "Ensure silage remains sealed while stored to prevent rotting", QuestionActionOrder = 5, Question = ques29 };
            var act126 = new QuestionAction { QuestionActionID = 126, QuestionActionDescription = "Permanent feed-out areas / facilities are sealed and effluent is collected", QuestionActionOrder = 6, Question = ques29 };

            context.QuestionAction.AddOrUpdate(
              a => a.QuestionActionID, act1, act2, act3, act4, act5, act6, act7, act8, act9, act10, act11, act12, act13, act14, act15, act16, act17, act18, act19, act20,
              act21, act22, act23, act24, act25, act26, act27, act28, act29, act30, act31, act32, act33, act34, act35, act36, act37, act38, act39, act40,
              act41, act42, act43, act44, act45, act46, act47, act48, act49, act50, act51, act52, act53, act54, act55, act56, act57, act58, act59, act60,
              act61, act62, act63, act64, act65, act66, act67, act68, act69, act70, act71, act72, act73, act74, act75, act76, act77, act78, act79, act80,
              act81, act82, act83, act84, act85, act86, act87, act88, act89, act90, act91, act92, act93, act94, act95, act96, act97, act98, act99, act100,
              act101, act102, act103, act104, act105, act106, act107, act108, act109, act110, act111, act112, act113, act114, act115, act116, act117, act118,
              act119, act120, act121, act122, act123, act124, act125, act126);
            context.SaveChanges();

            var rep1 = new Report { ReportID = 1, UserID = 1, ReportFarmName = "Farm with 1 report", ReportDateTime = DateTime.Now };
            var rep2 = new Report { ReportID = 2, UserID = 2, ReportFarmName = "Farm with 2 reports unfinished", ReportDateTime = DateTime.Now };
            var rep3 = new Report { ReportID = 3, UserID = 2, ReportFarmName = "Farm with 2 reports with custom actions", ReportDateTime = DateTime.Now };
            var rep4 = new Report { ReportID = 4, UserID = 3, ReportFarmName = "2 farms with 1 report each (Farm 1 - all right)", ReportDateTime = DateTime.Now };
            var rep5 = new Report { ReportID = 5, UserID = 3, ReportFarmName = "2 farms with 1 report each (Farm 2 - all wrong)", ReportDateTime = DateTime.Now };
            context.Report.AddOrUpdate(r => r.ReportID, rep1, rep2, rep3, rep4, rep5);
            context.SaveChanges();

            context.RepQuestion.AddOrUpdate(r => r.RepQuestionID,
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques1 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques2 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques3 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques4 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques5 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques6 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques7 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques8 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques9 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques10 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques11 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques12 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques13 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques14 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques15 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques16 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques17 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques18 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques19 },

                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques20 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques21 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques22 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques23 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques24 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques25 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques26 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques27 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques28 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep1, Question = ques29 }
            );
            context.SaveChanges();

            context.RepQuestionAction.AddOrUpdate(r => r.RepQuestionActionID,
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act1, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act2, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act3, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act4, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act5, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act6, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act7, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act8, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act9, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act10, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act11, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act12, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act13, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act14, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act15, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act16, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act17, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act18, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act19, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act20, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act21, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act22, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act23, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act24, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act25, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act26, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act27, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act28, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act29, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act30, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act31, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act32, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act33, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act34, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act35, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act36, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act37, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act38, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act39, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act40, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act41, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act42, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act43, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act44, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act45, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act46, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act47, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act48, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act49, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act50, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act51, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act52, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act53, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act54, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act55, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act56, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act57, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act58, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act59, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act60, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act61, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act62, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act63, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act64, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act65, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act66, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act67, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act68, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act69, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act70, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act71, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act72, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act73, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act74, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act75, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act76, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act77, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act78, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act79, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act80, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act81, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act82, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act83, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act84, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act85, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act86, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act87, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act88, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act89, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act90, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act91, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act92, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act93, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act94, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act95, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act96, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act97, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act98, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act99, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act100, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act101, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act102, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act103, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act104, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act105, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act106, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act107, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act108, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act109, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act110, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act111, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act112, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act113, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act114, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act115, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act116, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act117, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act118, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act119, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act120, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep1, QuestionAction = act121, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act122, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act123, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act124, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act125, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep1, QuestionAction = act126, RepQuestionActionDate = DateTime.Now }
            );
            context.SaveChanges();

            context.RepQuestion.AddOrUpdate(r => r.RepQuestionID,
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques1 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques2 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques3 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques4 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques5 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques6 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques7 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques8 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques9 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques10 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques11 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques12 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques13 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques14 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques15 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques16 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques17 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques18 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques19 },

                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques20 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep2, Question = ques21 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques22 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques23 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques24 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques25 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques26 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques27 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques28 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep2, Question = ques29 }
            );
            context.SaveChanges();

            context.RepQuestionAction.AddOrUpdate(r => r.RepQuestionActionID,
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act1, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act2, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act3, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act4, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act5, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act6, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act7, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act8, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act9, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act10, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act11, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act12, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act13, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act14, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act15, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act16, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act17, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act18, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act19, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act20, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act21, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act22, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act23, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act24, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act25, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act26, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act27, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act28, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act29, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act30, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act31, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act32, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act33, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act34, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act35, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act36, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act37, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act38, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act39, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act40, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act41, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act42, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act43, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act44, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act45, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act46, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act47, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act48, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act49, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act50, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act51, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act52, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act53, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act54, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act55, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act56, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act57, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act58, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act59, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act60, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act61, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act62, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act63, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act64, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act65, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act66, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act67, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act68, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act69, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act70, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act71, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act72, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act73, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act74, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act75, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act76, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act77, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act78, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act79, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act80, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act81, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act82, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act83, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act84, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep2, QuestionAction = act85, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act86, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act87, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act88, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act89, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act90, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act91, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act92, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act93, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act94, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act95, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act96, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act97, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act98, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act99, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act100, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act101, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act102, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act103, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act104, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act105, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act106, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act107, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act108, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act109, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act110, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act111, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act112, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act113, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act114, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act115, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act116, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act117, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act118, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act119, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act120, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act121, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act122, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act123, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act124, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act125, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep2, QuestionAction = act126, RepQuestionActionDate = DateTime.Now }
            );
            context.SaveChanges();

            context.RepQuestion.AddOrUpdate(r => r.RepQuestionID,
                new RepQuestion { RepQuestionAnswer = true, Report = rep3, Question = ques1 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques2 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques3 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques4 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques5 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques6 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques7 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques8 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques9 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques10 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques11 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques12 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques13 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques14 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques15 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques16 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques17 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques18 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques19 },

                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques20 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques21 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques22 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques23 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques24 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques25 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques26 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques27 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques28 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep3, Question = ques29 }
            );
            context.SaveChanges();

            context.RepQuestionAction.AddOrUpdate(r => r.RepQuestionActionID,
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act1, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act2, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act3, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act4, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act5, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act6, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act7, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act8, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act9, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act10, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act11, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act12, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act13, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act14, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act15, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act16, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act17, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act18, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act19, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act20, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act21, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act22, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act23, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act24, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act25, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act26, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act27, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act28, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act29, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act30, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act31, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act32, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act33, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act34, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act35, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act36, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act37, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act38, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act39, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act40, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act41, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act42, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act43, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act44, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act45, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act46, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act47, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act48, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act49, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act50, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act51, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act52, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act53, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act54, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act55, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act56, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act57, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act58, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act59, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act60, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act61, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act62, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act63, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act64, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act65, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act66, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act67, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act68, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act69, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act70, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act71, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act72, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act73, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act74, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act75, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act76, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act77, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act78, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act79, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act80, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act81, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act82, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act83, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act84, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act85, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act86, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act87, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act88, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act89, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act90, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act91, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act92, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act93, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act94, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act95, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act96, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act97, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act98, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act99, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act100, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act101, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act102, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act103, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act104, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act105, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act106, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act107, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act108, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act109, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act110, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act111, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act112, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act113, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act114, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act115, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act116, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act117, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act118, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act119, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act120, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act121, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act122, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act123, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act124, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act125, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep3, QuestionAction = act126, RepQuestionActionDate = DateTime.Now }
            );
            context.SaveChanges();

            context.RepQuestionCusAction.AddOrUpdate(r => r.RepQuestionCusActionID,
                new RepQuestionCusAction
                {
                    RepQuestionCusActionAns = true,
                    RepQuestionCusActionDescription = "Some custom action",
                    RepQuestionCusActionOrder = 8,
                    Report = rep3,
                    Question = ques1,
                    RepQuestionCusActionDate = DateTime.Now
                },
                new RepQuestionCusAction
                {
                    RepQuestionCusActionAns = true,
                    RepQuestionCusActionDescription = "Other custom action",
                    RepQuestionCusActionOrder = 9,
                    Report = rep3,
                    Question = ques1,
                    RepQuestionCusActionDate = DateTime.Now
                }
            );
            context.SaveChanges();

            context.RepQuestion.AddOrUpdate(r => r.RepQuestionID,
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques1 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques2 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques3 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques4 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques5 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques6 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques7 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques8 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques9 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques10 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques11 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques12 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques13 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques14 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques15 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques16 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques17 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques18 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques19 },

                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques20 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques21 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques22 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques23 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques24 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques25 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques26 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques27 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques28 },
                new RepQuestion { RepQuestionAnswer = false, Report = rep4, Question = ques29 }
            );
            context.SaveChanges();

            context.RepQuestionAction.AddOrUpdate(r => r.RepQuestionActionID,
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act1, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act2, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act3, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act4, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act5, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act6, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act7, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act8, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act9, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act10, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act11, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act12, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act13, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act14, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act15, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act16, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act17, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act18, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act19, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act20, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act21, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act22, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act23, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act24, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act25, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act26, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act27, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act28, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act29, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act30, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act31, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act32, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act33, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act34, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act35, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act36, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act37, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act38, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act39, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act40, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act41, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act42, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act43, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act44, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act45, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act46, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act47, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act48, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act49, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act50, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act51, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act52, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act53, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act54, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act55, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act56, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act57, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act58, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act59, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act60, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act61, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act62, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act63, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act64, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act65, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act66, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act67, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act68, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act69, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act70, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act71, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act72, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act73, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act74, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act75, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act76, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act77, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act78, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act79, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act80, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act81, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act82, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act83, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act84, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act85, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act86, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act87, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act88, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act89, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act90, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act91, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act92, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act93, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act94, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act95, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act96, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act97, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act98, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act99, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act100, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act101, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act102, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act103, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act104, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act105, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act106, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act107, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act108, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act109, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act110, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act111, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act112, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act113, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act114, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act115, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act116, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act117, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act118, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act119, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act120, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act121, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act122, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act123, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act124, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act125, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = false, Report = rep4, QuestionAction = act126, RepQuestionActionDate = DateTime.Now }
            );
            context.SaveChanges();

            context.RepQuestion.AddOrUpdate(r => r.RepQuestionID,
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques1 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques2 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques3 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques4 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques5 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques6 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques7 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques8 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques9 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques10 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques11 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques12 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques13 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques14 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques15 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques16 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques17 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques18 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques19 },

                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques20 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques21 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques22 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques23 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques24 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques25 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques26 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques27 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques28 },
                new RepQuestion { RepQuestionAnswer = true, Report = rep5, Question = ques29 }
            );
            context.SaveChanges();

            context.RepQuestionAction.AddOrUpdate(r => r.RepQuestionActionID,
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act1, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act2, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act3, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act4, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act5, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act6, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act7, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act8, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act9, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act10, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act11, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act12, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act13, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act14, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act15, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act16, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act17, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act18, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act19, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act20, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act21, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act22, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act23, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act24, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act25, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act26, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act27, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act28, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act29, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act30, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act31, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act32, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act33, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act34, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act35, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act36, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act37, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act38, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act39, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act40, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act41, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act42, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act43, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act44, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act45, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act46, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act47, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act48, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act49, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act50, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act51, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act52, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act53, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act54, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act55, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act56, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act57, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act58, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act59, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act60, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act61, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act62, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act63, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act64, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act65, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act66, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act67, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act68, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act69, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act70, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act71, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act72, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act73, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act74, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act75, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act76, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act77, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act78, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act79, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act80, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act81, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act82, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act83, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act84, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act85, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act86, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act87, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act88, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act89, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act90, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act91, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act92, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act93, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act94, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act95, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act96, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act97, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act98, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act99, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act100, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act101, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act102, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act103, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act104, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act105, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act106, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act107, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act108, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act109, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act110, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act111, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act112, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act113, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act114, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act115, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act116, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act117, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act118, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act119, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act120, RepQuestionActionDate = DateTime.Now },

                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act121, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act122, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act123, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act124, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act125, RepQuestionActionDate = DateTime.Now },
                new RepQuestionAction { RepQuestionActionAns = true, Report = rep5, QuestionAction = act126, RepQuestionActionDate = DateTime.Now }
            );
            context.SaveChanges();
        }
    }
}
