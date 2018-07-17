﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SetupButtons
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("d5059cd9-286a-4060-8449-7f992c7718e4", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SetupButtonsRepository repository.
        /// </summary>
        public static SetupButtonsRepository repo = SetupButtonsRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 703;5.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.SnapXUntitled.Click("703;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(2));
            Keyboard.Press("c");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't'.", new RecordItemIndex(3));
            Keyboard.Press("t");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(4));
            Keyboard.Press("o");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.FeaturesText' at 26;6.", repo.SnapXUntitled.SNAPX.FeaturesTextInfo, new RecordItemIndex(5));
            repo.SnapXUntitled.SNAPX.FeaturesText.Click("26;6");
            Delay.Milliseconds(200);

            string strReadText1 = repo.SnapXUntitled.SNAPX.FeaturesText.TextValue;
            string strHardcodedText1 = "Features:";
            StringCopare.Text(strReadText1, strHardcodedText1);
            Delay.Milliseconds(200);


            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.BoxForValue' at 9;7.", repo.SnapXUntitled.SNAPX.BoxForValueInfo, new RecordItemIndex(6));
            repo.SnapXUntitled.SNAPX.BoxForValue.Click("9;7");
            Delay.Milliseconds(200);

            string strActualValue1 = repo.SnapXUntitled.SNAPX.BoxForValue.TextValue;
            string strHardcodedValue1 = "0";
            StringCopare.Text(strActualValue1, strHardcodedValue1);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Modifiers' at 34;41.", repo.SnapXUntitled.SNAPX.ModifiersInfo, new RecordItemIndex(7));
            repo.SnapXUntitled.SNAPX.Modifiers.Click("34;41");
            Delay.Milliseconds(200);

            string strReadText2 = repo.SnapXUntitled.SNAPX.Modifiers.Caption;
            string strHardcodedText2 = "Modifiers";
            StringCopare.Text(strReadText2, strHardcodedText2);
            Delay.Milliseconds(200);


            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AtNominalLocation' at 65;7.", repo.SnapXUntitled.SNAPX.AtNominalLocationInfo, new RecordItemIndex(8));
            repo.SnapXUntitled.SNAPX.AtNominalLocation.Click("65;7");
            Delay.Milliseconds(200);

            string strReadText3 = repo.SnapXUntitled.SNAPX.AtNominalLocation.Text;
            string strHardcodedText3 = "At Nominal Location";
            StringCopare.Text(strReadText3, strHardcodedText3);
            Delay.Milliseconds(200);


            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AtActualLocation' at 53;7.", repo.SnapXUntitled.SNAPX.AtActualLocationInfo, new RecordItemIndex(9));
            repo.SnapXUntitled.SNAPX.AtActualLocation.Click("53;7");
            Delay.Milliseconds(200);

            string strReadText4 = repo.SnapXUntitled.SNAPX.AtActualLocation.Text;
            string strHardcodedText4 = "At Actual Location";
            StringCopare.Text(strReadText4, strHardcodedText4);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.ZeroAxis' at 20;45.", repo.SnapXUntitled.SNAPX.ZeroAxisInfo, new RecordItemIndex(10));
            repo.SnapXUntitled.SNAPX.ZeroAxis.Click("20;45");
            Delay.Milliseconds(200);

            string strReadText5 = repo.SnapXUntitled.SNAPX.ZeroAxis.Caption;
            string strHardcodedText5 = "Zero Axis";
            StringCopare.Text(strReadText5, strHardcodedText5);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.ZeroXAxis' at 56;8.", repo.SnapXUntitled.SNAPX.ZeroXAxisInfo, new RecordItemIndex(11));
            repo.SnapXUntitled.SNAPX.ZeroXAxis.Click("56;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.ZeroXAxis' at 55;8.", repo.SnapXUntitled.SNAPX.ZeroXAxisInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.SNAPX.ZeroXAxis.Click("55;8");
            Delay.Milliseconds(200);

            string strReadText6 = repo.SnapXUntitled.SNAPX.ZeroXAxis.Text;
            string strHardcodedText6 = "Zero X Axis";
            StringCopare.Text(strReadText6, strHardcodedText6);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.ZeroYAxis' at 52;5.", repo.SnapXUntitled.SNAPX.ZeroYAxisInfo, new RecordItemIndex(13));
            repo.SnapXUntitled.SNAPX.ZeroYAxis.Click("52;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.ZeroYAxis' at 52;5.", repo.SnapXUntitled.SNAPX.ZeroYAxisInfo, new RecordItemIndex(14));
            repo.SnapXUntitled.SNAPX.ZeroYAxis.Click("52;5");
            Delay.Milliseconds(200);

            string strReadText7 = repo.SnapXUntitled.SNAPX.ZeroYAxis.Text;
            string strHardcodedText7 = "Zero Y Axis";
            StringCopare.Text(strReadText7, strHardcodedText7);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.SetAxis' at 17;57.", repo.SnapXUntitled.SNAPX.SetAxisInfo, new RecordItemIndex(15));
            repo.SnapXUntitled.SNAPX.SetAxis.Click("17;57");
            Delay.Milliseconds(200);

            string strReadText8 = repo.SnapXUntitled.SNAPX.SetAxis.Caption;
            string strHardcodedText8 = "Set Axis";
            StringCopare.Text(strReadText8, strHardcodedText8);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.SetXAxisToText' at 36;8.", repo.SnapXUntitled.SNAPX.SetXAxisToTextInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.SNAPX.SetXAxisToText.Click("36;8");
            Delay.Milliseconds(200);

            string strReadText9 = repo.SnapXUntitled.SNAPX.SetXAxisToText.TextValue;
            string strHardcodedText9 = "Set X Axis To:";
            StringCopare.Text(strReadText9, strHardcodedText9);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.SetYAxisToText' at 27;10.", repo.SnapXUntitled.SNAPX.SetYAxisToTextInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.SNAPX.SetYAxisToText.Click("27;10");
            Delay.Milliseconds(200);

            string strReadText10 = repo.SnapXUntitled.SNAPX.SetYAxisToText.TextValue;
            string strHardcodedText10 = "Set Y Axis To:";
            StringCopare.Text(strReadText10, strHardcodedText10);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(18));
            Keyboard.Press("c");
            Delay.Milliseconds(0);
                        
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 703;5.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(19));
            repo.SnapXUntitled.SnapXUntitled.Click("703;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(20));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(21));
            Keyboard.Press("c");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't'.", new RecordItemIndex(22));
            Keyboard.Press("t");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 's'.", new RecordItemIndex(23));
            Keyboard.Press("s");
            Delay.Milliseconds(200);            
                        
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.FeaturesText' at 36;5.", repo.SnapXUntitled.SNAPX.FeaturesTextInfo, new RecordItemIndex(25));
            repo.SnapXUntitled.SNAPX.FeaturesText.Click("36;5");
            Delay.Milliseconds(200);

            string strReadText11 = repo.SnapXUntitled.SNAPX.FeaturesText.TextValue;
            string strHardcodedText11 = "Features:";
            StringCopare.Text(strReadText11, strHardcodedText11);
            Delay.Milliseconds(200);


            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.BoxForValue' at 8;7.", repo.SnapXUntitled.SNAPX.BoxForValueInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.SNAPX.BoxForValue.Click("8;7");
            Delay.Milliseconds(200);

            string strReadVAlue2 = repo.SnapXUntitled.SNAPX.BoxForValue.TextValue;
            string strHardcodedValue2 = "0";
            StringCopare.Text(strReadVAlue2, strHardcodedValue2);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Modifiers' at 24;40.", repo.SnapXUntitled.SNAPX.ModifiersInfo, new RecordItemIndex(27));
            repo.SnapXUntitled.SNAPX.Modifiers.Click("24;40");
            Delay.Milliseconds(200);

            string strReadText12 = repo.SnapXUntitled.SNAPX.Modifiers.Caption;
            string strHardcodedText12 = "Modifiers";
            StringCopare.Text(strReadText12, strHardcodedText12);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AtFeatureOrientation' at 77;6.", repo.SnapXUntitled.SNAPX.AtFeatureOrientationInfo, new RecordItemIndex(28));
            repo.SnapXUntitled.SNAPX.AtFeatureOrientation.Click("77;6");
            Delay.Milliseconds(200);

            string strReadText13 = repo.SnapXUntitled.SNAPX.AtFeatureOrientation.Text;
            string strHardcodedText13 = "At Feature Orientation";
            StringCopare.Text(strReadText13, strHardcodedText13);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AtNominalLocation' at 76;6.", repo.SnapXUntitled.SNAPX.AtNominalLocationInfo, new RecordItemIndex(29));
            repo.SnapXUntitled.SNAPX.AtNominalLocation.Click("76;6");
            Delay.Milliseconds(200);

            string strReadText14 = repo.SnapXUntitled.SNAPX.AtNominalLocation.Text;
            string strHardcodedText14 = "At Nominal Location";
            StringCopare.Text(strReadText14, strHardcodedText14);
            Delay.Milliseconds(200);            

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AtActualLocation' at 110;7.", repo.SnapXUntitled.SNAPX.AtActualLocationInfo, new RecordItemIndex(30));
            repo.SnapXUntitled.SNAPX.AtActualLocation.Click("110;7");
            Delay.Milliseconds(200);

            string strReadText15 = repo.SnapXUntitled.SNAPX.AtActualLocation.Text;
            string strHardcoded15 = "At Actual Location";
            StringCopare.Text(strReadText15, strHardcoded15);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AlignAxis' at 173;29.", repo.SnapXUntitled.SNAPX.AlignAxisInfo, new RecordItemIndex(31));
            repo.SnapXUntitled.SNAPX.AlignAxis.Click("173;29");
            Delay.Milliseconds(200);

            string strReadText16 = repo.SnapXUntitled.SNAPX.AlignAxis.Caption;
            string strHardcodedText16 = "Align Axis";
            StringCopare.Text(strReadText16, strHardcodedText16);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.RadioButtonX' at 9;7.", repo.SnapXUntitled.SNAPX.RadioButtonXInfo, new RecordItemIndex(32));
            repo.SnapXUntitled.SNAPX.RadioButtonX.Click("9;7");
            Delay.Milliseconds(200);

            string strReadText17 = repo.SnapXUntitled.SNAPX.RadioButtonX.Text;
            string strHardcodedText17 = "X";
            StringCopare.Text(strReadText17, strHardcodedText17);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.RadioButtonY' at 6;7.", repo.SnapXUntitled.SNAPX.RadioButtonYInfo, new RecordItemIndex(33));
            repo.SnapXUntitled.SNAPX.RadioButtonY.Click("6;7");
            Delay.Milliseconds(200);

            string strRealText18 = repo.SnapXUntitled.SNAPX.RadioButtonY.Text;
            string strHardcodedText18 = "Y";
            StringCopare.Text(strRealText18, strHardcodedText18);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.SetAlignment' at 15;30.", repo.SnapXUntitled.SNAPX.SetAlignmentInfo, new RecordItemIndex(34));
            repo.SnapXUntitled.SNAPX.SetAlignment.Click("15;30");
            Delay.Milliseconds(200);

            string strRealText19 = repo.SnapXUntitled.SNAPX.SetAlignment.Caption;
            string strHardcodedText19 = "Set Alignment";
            StringCopare.Text(strRealText19, strHardcodedText19);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.AlignAxisToAngleText' at 42;11.", repo.SnapXUntitled.SNAPX.AlignAxisToAngleTextInfo, new RecordItemIndex(35));
            repo.SnapXUntitled.SNAPX.AlignAxisToAngleText.Click("42;11");
            Delay.Milliseconds(200);

            string strReadText20 = repo.SnapXUntitled.SNAPX.AlignAxisToAngleText.Caption;
            string strHardcodedText = "Align Axis To Angle";
            StringCopare.Text(strReadText20, strHardcodedText);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.SetBasicAlignment' at 21;55.", repo.SnapXUntitled.SNAPX.SetBasicAlignmentInfo, new RecordItemIndex(36));
            repo.SnapXUntitled.SNAPX.SetBasicAlignment.Click("21;55");
            Delay.Milliseconds(200);

            string strReadText21 = repo.SnapXUntitled.SNAPX.SetBasicAlignment.Caption;
            string strHardcodedText21 = "Set Basic Alignment";
            StringCopare.Text(strReadText21, strHardcodedText21);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.XBasic' at 49;6.", repo.SnapXUntitled.SNAPX.XBasicInfo, new RecordItemIndex(37));
            repo.SnapXUntitled.SNAPX.XBasic.Click("49;6");
            Delay.Milliseconds(200);

            string strReadText22 = repo.SnapXUntitled.SNAPX.XBasic.Text;
            string strHardcodedText22 = "X Basic";
            StringCopare.Text(strReadText22, strHardcodedText22);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.YBasic' at 51;6.", repo.SnapXUntitled.SNAPX.YBasicInfo, new RecordItemIndex(38));
            repo.SnapXUntitled.SNAPX.YBasic.Click("51;6");
            Delay.Milliseconds(200);

            string strReadText23 = repo.SnapXUntitled.SNAPX.YBasic.Text;
            string strHardcodedText23 = "Y Basic";
            StringCopare.Text(strReadText23, strHardcodedText23);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.SetBasicValueText' at 58;10.", repo.SnapXUntitled.SNAPX.SetBasicValueTextInfo, new RecordItemIndex(39));
            repo.SnapXUntitled.SNAPX.SetBasicValueText.Click("58;10");
            Delay.Milliseconds(200);

            string strReadText24 = repo.SnapXUntitled.SNAPX.SetBasicValueText.TextValue;
            string strHadcodedText24 = "Set Basic Value:";
            StringCopare.Text(strReadText24, strHadcodedText24);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(40));
            Keyboard.Press("c");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 703;5.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(41));
            repo.SnapXUntitled.SnapXUntitled.Click("703;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(42));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(43));
            Keyboard.Press("c");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't'.", new RecordItemIndex(44));
            Keyboard.Press("t");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(45));
            Keyboard.Press("r");
            Delay.Milliseconds(200);                        
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.FeaturesText' at 22;6.", repo.SnapXUntitled.SNAPX.FeaturesTextInfo, new RecordItemIndex(47));
            repo.SnapXUntitled.SNAPX.FeaturesText.Click("22;6");
            Delay.Milliseconds(200);

            string strReadText25 = repo.SnapXUntitled.SNAPX.FeaturesText.TextValue;
            string strHardcodedText25 = "Features:";
            StringCopare.Text(strReadText25, strHardcodedText25);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.BoxForValue' at 10;7.", repo.SnapXUntitled.SNAPX.BoxForValueInfo, new RecordItemIndex(48));
            repo.SnapXUntitled.SNAPX.BoxForValue.Click("10;7");
            Delay.Milliseconds(200);

            string strReadValue26 = repo.SnapXUntitled.SNAPX.BoxForValue.TextValue;
            string strHardcodedValue26 = "0";
            StringCopare.Text(strReadValue26, strHardcodedValue26);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Features' at 33;11.", repo.SnapXUntitled.SNAPX.FeaturesInfo, new RecordItemIndex(49));
            repo.SnapXUntitled.SNAPX.Features.Click("33;11");
            Delay.Milliseconds(200);

            string strReadText27 = repo.SnapXUntitled.SNAPX.Features.Text;
            string strhardcodedText27 = "Features";
            StringCopare.Text(strReadText27, strhardcodedText27);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at 49;11.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(50));
            repo.SnapXUntitled.ButtonOK.Click("49;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Datum' at 16;22.", repo.SnapXUntitled.SNAPX.DatumInfo, new RecordItemIndex(51));
            repo.SnapXUntitled.SNAPX.Datum.Click("16;22");
            Delay.Milliseconds(200);

            string strReadText28 = repo.SnapXUntitled.SNAPX.Datum.Caption;
            string strHardcodedText28 = "Datum";
            StringCopare.Text(strReadText28, strHardcodedText28);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.RecallText' at 22;7.", repo.SnapXUntitled.SNAPX.RecallTextInfo, new RecordItemIndex(52));
            repo.SnapXUntitled.SNAPX.RecallText.Click("22;7");
            Delay.Milliseconds(200);

            string strReadText29 = repo.SnapXUntitled.SNAPX.RecallText.TextValue;
            string strHardcodedText29 = "Recall";
            StringCopare.Text(strReadText29, strHardcodedText29);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.InputFromFile' at 206;10.", repo.SnapXUntitled.SNAPX.InputFromFileInfo, new RecordItemIndex(53));
            repo.SnapXUntitled.SNAPX.InputFromFile.Click("206;10");
            Delay.Milliseconds(200);

            string strReadText30 = repo.SnapXUntitled.SNAPX.InputFromFile.Caption;
            string strHardcodedText30 = "Input From File";
            StringCopare.Text(strReadText30, strHardcodedText30);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.InputFromFileText' at 74;6.", repo.SnapXUntitled.SNAPX.InputFromFileTextInfo, new RecordItemIndex(54));
            repo.SnapXUntitled.SNAPX.InputFromFileText.Click("74;6");
            Delay.Milliseconds(200);

            string strReadText31 = repo.SnapXUntitled.SNAPX.InputFromFileText.Text;
            string strHardcodedText31 = "Input From File";
            StringCopare.Text(strReadText31, strHardcodedText31);
            Delay.Milliseconds(200);
                                 
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.FilePathnameText' at 48;7.", repo.SnapXUntitled.SNAPX.FilePathnameTextInfo, new RecordItemIndex(57));
            repo.SnapXUntitled.SNAPX.FilePathnameText.Click("48;7");
            Delay.Milliseconds(200);

            string strReadText32 =  repo.SnapXUntitled.SNAPX.FilePathnameText.TextValue;
            string strHardcodedText32 = "File Pathname";
            StringCopare.Text(strReadText32, strHardcodedText32);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.KeepFile' at 40;9.", repo.SnapXUntitled.SNAPX.KeepFileInfo, new RecordItemIndex(58));
            repo.SnapXUntitled.SNAPX.KeepFile.Click("40;9");
            Delay.Milliseconds(200);

            string strReadText33 = repo.SnapXUntitled.SNAPX.KeepFile.Text;
            string strhardcodedText33 = "Keep File";
            StringCopare.Text(strReadText33, strhardcodedText33);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c' with focus on 'SnapXUntitled.SNAPX.KeepFile'.", repo.SnapXUntitled.SNAPX.KeepFileInfo, new RecordItemIndex(59));
            repo.SnapXUntitled.SNAPX.KeepFile.PressKeys("c");
            Delay.Milliseconds(0);            

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 703;5.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(60));
            repo.SnapXUntitled.SnapXUntitled.Click("703;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(61));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(62));
            Keyboard.Press("c");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't'.", new RecordItemIndex(63));
            Keyboard.Press("t");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(64));
            Keyboard.Press("c");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Method' at 21;59.", repo.SnapXUntitled.SNAPX.MethodInfo, new RecordItemIndex(65));
            repo.SnapXUntitled.SNAPX.Method.Click("21;59");
            Delay.Milliseconds(200);

            string strReadText34 = repo.SnapXUntitled.SNAPX.Method.Caption;
            string strHardcodedText34 = "Method";
            StringCopare.Text(strReadText34, strHardcodedText34);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Centroid' at 37;7.", repo.SnapXUntitled.SNAPX.CentroidInfo, new RecordItemIndex(66));
            repo.SnapXUntitled.SNAPX.Centroid.Click("37;7");
            Delay.Milliseconds(200);

            string strReadText35 = repo.SnapXUntitled.SNAPX.Centroid.Text;
            string strHardcodedText35 = "Centroid";
            StringCopare.Text(strReadText35, strHardcodedText35);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.EdgeMask' at 35;4.", repo.SnapXUntitled.SNAPX.EdgeMaskInfo, new RecordItemIndex(67));
            repo.SnapXUntitled.SNAPX.EdgeMask.Click("35;4");
            Delay.Milliseconds(200);

            string strReadText36 = repo.SnapXUntitled.SNAPX.EdgeMask.Text;
            string strHardcodedText36 = "Edge Mask";
            StringCopare.Text(strReadText36, strHardcodedText36);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Multiple' at 171;9.", repo.SnapXUntitled.SNAPX.MultipleInfo, new RecordItemIndex(68));
            repo.SnapXUntitled.SNAPX.Multiple.Click("171;9");
            Delay.Milliseconds(200);

            string strReadText37 = repo.SnapXUntitled.SNAPX.Multiple.Caption;
            string strHardcodedText37 = "Multiple";
            StringCopare.Text(strReadText37, strHardcodedText37);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Multiple1' at 28;5.", repo.SnapXUntitled.SNAPX.Multiple1Info, new RecordItemIndex(69));
            repo.SnapXUntitled.SNAPX.Multiple1.Click("28;5");
            Delay.Milliseconds(200);

            string strReadText38 = repo.SnapXUntitled.SNAPX.Multiple1.Text;
            string strHardcodedText38 = "Multiple";
            StringCopare.Text(strReadText38, strHardcodedText38);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Threshold' at 116;15.", repo.SnapXUntitled.SNAPX.ThresholdInfo, new RecordItemIndex(70));
            repo.SnapXUntitled.SNAPX.Threshold.Click("116;15");
            Delay.Milliseconds(200);

            string strReadText39 = repo.SnapXUntitled.SNAPX.Threshold.Caption;
            string strHardcodedText39 = "Threshold";
            StringCopare.Text(strReadText39, strHardcodedText39);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Filter' at 86;15.", repo.SnapXUntitled.SNAPX.FilterInfo, new RecordItemIndex(71));
            repo.SnapXUntitled.SNAPX.Filter.Click("86;15");
            Delay.Milliseconds(200);

            string strReadText40 = repo.SnapXUntitled.SNAPX.Filter.Caption;
            string strHardcodedText40 = "Filter";
            StringCopare.Text(strReadText40, strHardcodedText40);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.NoneText' at 11;5.", repo.SnapXUntitled.SNAPX.NoneTextInfo, new RecordItemIndex(72));
            repo.SnapXUntitled.SNAPX.NoneText.Click("11;5");
            Delay.Milliseconds(200);

            string strReadText41 = repo.SnapXUntitled.SNAPX.NoneText.TextValue;
            string strHardcodedText41 = "None";
            StringCopare.Text(strReadText41, strHardcodedText41);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.MaxText' at 11;6.", repo.SnapXUntitled.SNAPX.MaxTextInfo, new RecordItemIndex(73));
            repo.SnapXUntitled.SNAPX.MaxText.Click("11;6");
            Delay.Milliseconds(200);

            string strReadText42 = repo.SnapXUntitled.SNAPX.MaxText.TextValue;
            string strHardcodedText42 = "Max";
            StringCopare.Text(strReadText42, strHardcodedText42);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.Fill' at 28;6.", repo.SnapXUntitled.SNAPX.FillInfo, new RecordItemIndex(74));
            repo.SnapXUntitled.SNAPX.Fill.Click("28;6");
            Delay.Milliseconds(200);

            string strReadText43 = repo.SnapXUntitled.SNAPX.Fill.Text;
            string strHardcodedText43 = "Fill";
            StringCopare.Text(strReadText43, strHardcodedText43);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SNAPX.TouchBoundary' at 40;6.", repo.SnapXUntitled.SNAPX.TouchBoundaryInfo, new RecordItemIndex(75));
            repo.SnapXUntitled.SNAPX.TouchBoundary.Click("40;6");
            Delay.Milliseconds(200);

            string strReadText44 = repo.SnapXUntitled.SNAPX.TouchBoundary.Text;
            string strHardcodedText44 = "Touch Boundary";
            StringCopare.Text(strReadText44, strHardcodedText44);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c'.", new RecordItemIndex(76));
            Keyboard.Press("c");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
