﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docusign.Revamped.DocusignTypes
{
    public class Tabs
    {
        public List<ApproveTab> approveTabs;
        public List<CheckboxTab> checkboxTabs;
        public List<CompanyTab> companyTabs;
        public List<DateSignedTab> dateSignedTabs;
        public List<DateTab> dateTabs;
        public List<DeclineTab> declineTabs;
        public List<EmailAddressTab> emailAddressTabs;
        public List<EmailTab> emailTabs;
        public List<EnvelopeIDTab> envelopeIdTabs;
        public List<FirstNameTab> firstNameTabs;
        public List<FormulaTab> formulaTabs;
        public List<FullNameTab> fullNameTabs;
        public List<InitialHereTab> initialHereTabs;
        public List<LastNameTab> lastNameTabs;
        public List<ListTab> listTabs;
        public List<NoteTab> noteTabs;
        public List<NumberTab> numberTabs;
        public List<RadioGroupTab> radioGroupTabs;
        public List<SignHereTab> signHereTabs;
        public List<SignerAttachmentTab> signerAttachmentTabs;
        public List<SSNTab> ssnTabs;
        public List<TextTab> textTabs;
        public List<TitleTab> titleTabs;
        public List<ZipTab> zipTabs;


        public void Add(List<Tab> tabs)
        {
            foreach (Tab tab in tabs)
            {
                Add(tab);
            }
        }
        public void Add(Tab tab)
        {
            if (tab.GetType() == typeof(ApproveTab))
            {
                if (approveTabs == null) approveTabs = new List<ApproveTab>();
                approveTabs.Add((ApproveTab)tab);
            }

            else if (tab.GetType() == typeof(CheckboxTab))
            {
                if (checkboxTabs == null) checkboxTabs = new List<CheckboxTab>();
                checkboxTabs.Add((CheckboxTab)tab);
            }

            else if (tab.GetType() == typeof(CompanyTab))
            {
                if (companyTabs == null) companyTabs = new List<CompanyTab>();
                companyTabs.Add((CompanyTab)tab);
            }

            else if (tab.GetType() == typeof(DateSignedTab))
            {
                if (dateSignedTabs == null) dateSignedTabs = new List<DateSignedTab>();
                dateSignedTabs.Add((DateSignedTab)tab);
            }

            else if (tab.GetType() == typeof(DateTab))
            {
                if (dateTabs == null) dateTabs = new List<DateTab>();
                dateTabs.Add((DateTab)tab);
            }

            else if (tab.GetType() == typeof(DeclineTab))
            {
                if (declineTabs == null) declineTabs = new List<DeclineTab>();
                declineTabs.Add((DeclineTab)tab);
            }

            else if (tab.GetType() == typeof(EmailAddressTab))
            {
                if (emailAddressTabs == null) emailAddressTabs = new List<EmailAddressTab>();
                emailAddressTabs.Add((EmailAddressTab)tab);
            }

            else if (tab.GetType() == typeof(EmailTab))
            {
                if (emailTabs == null) emailTabs = new List<EmailTab>();
                emailTabs.Add((EmailTab)tab);
            }

            else if (tab.GetType() == typeof(EnvelopeIDTab))
            {
                if (envelopeIdTabs == null) envelopeIdTabs = new List<EnvelopeIDTab>();
                envelopeIdTabs.Add((EnvelopeIDTab)tab);
            }

            else if (tab.GetType() == typeof(FirstNameTab))
            {
                if (firstNameTabs == null) firstNameTabs = new List<FirstNameTab>();
                firstNameTabs.Add((FirstNameTab)tab);
            }

            else if (tab.GetType() == typeof(FormulaTab))
            {
                if (formulaTabs == null) formulaTabs = new List<FormulaTab>();
                formulaTabs.Add((FormulaTab)tab);
            }

            else if (tab.GetType() == typeof(FullNameTab))
            {
                if (fullNameTabs == null) fullNameTabs = new List<FullNameTab>();
                fullNameTabs.Add((FullNameTab)tab);
            }

            else if (tab.GetType() == typeof(InitialHereTab))
            {
                if (initialHereTabs == null) initialHereTabs = new List<InitialHereTab>();
                initialHereTabs.Add((InitialHereTab)tab);
            }

            else if (tab.GetType() == typeof(LastNameTab))
            {
                if (lastNameTabs == null) lastNameTabs = new List<LastNameTab>();
                lastNameTabs.Add((LastNameTab)tab);
            }

            else if (tab.GetType() == typeof(ListTab))
            {
                if (listTabs == null) listTabs = new List<ListTab>();
                listTabs.Add((ListTab)tab);
            }

            else if (tab.GetType() == typeof(NoteTab))
            {
                if (noteTabs == null) noteTabs = new List<NoteTab>();
                noteTabs.Add((NoteTab)tab);
            }

            else if (tab.GetType() == typeof(NumberTab))
            {
                if (numberTabs == null) numberTabs = new List<NumberTab>();
                numberTabs.Add((NumberTab)tab);
            }

            else if (tab.GetType() == typeof(RadioGroupTab))
            {
                if (radioGroupTabs == null) radioGroupTabs = new List<RadioGroupTab>();
                radioGroupTabs.Add((RadioGroupTab)tab);
            }

            else if (tab.GetType() == typeof(SignHereTab))
            {
                if (signHereTabs == null) signHereTabs = new List<SignHereTab>();
                signHereTabs.Add((SignHereTab)tab);
            }

            else if (tab.GetType() == typeof(SignerAttachmentTab))
            {
                if (signerAttachmentTabs == null) signerAttachmentTabs = new List<SignerAttachmentTab>();
                signerAttachmentTabs.Add((SignerAttachmentTab)tab);
            }

            else if (tab.GetType() == typeof(SSNTab))
            {
                if (ssnTabs == null) ssnTabs = new List<SSNTab>();
                ssnTabs.Add((SSNTab)tab);
            }

            else if (tab.GetType() == typeof(TextTab))
            {
                if (textTabs == null) textTabs = new List<TextTab>();
                textTabs.Add((TextTab)tab);
            }

            else if (tab.GetType() == typeof(TitleTab))
            {
                if (titleTabs == null) titleTabs = new List<TitleTab>();
                titleTabs.Add((TitleTab)tab);
            }


            else if (tab.GetType() == typeof(ZipTab))
            {
                if (zipTabs == null) zipTabs = new List<ZipTab>();
                zipTabs.Add((ZipTab)tab);
            }
        }
    }

    //Tab Base Types
    public class Tab
    {
        public int documentId;

        //Absolute positioning
        public int xPosition;
        public int yPosition;

        //Relative positioning
        public string anchorString;
        public int anchorXOffset;
        public int anchorYOffset;

        public int pageNumber;
        public string name;
        public string tabLabel;



        public Tab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel)
        {
            this.xPosition = xPos;
            this.yPosition = yPos;
            this.documentId = docId;
            this.tabLabel = tabLabel;
            this.name = toolTip;

            if (pageNumber == 0) this.pageNumber = 1;
            else this.pageNumber = pageNumber;
        }

        public Tab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel)
        {
            this.anchorString = anchorString;
            this.anchorXOffset = anchorXOffset;
            this.anchorYOffset = anchorYOffset;
            this.documentId = docId;
            this.tabLabel = tabLabel;
            this.name = toolTip;
            this.pageNumber = pageNumber;
        }

        public bool ShouldSerializeanchorXOffset()
        {
            return (anchorString != null);
        }
        public bool ShouldSerializeanchorYOffset()
        {
            return (anchorString != null);
        }
        public bool ShouldSerializexPosition()
        {
            return (anchorString == null);
        }

        public bool ShouldSerializeyPosition()
        {
            return (anchorString == null);
        }

        public bool ShouldSerializepageNumber()
        {
            return (anchorString == null);
        }
    }

    public class ConstDisplayTab : Tab
    {
        public string bold;
        public string italic;
        public string underline;
        public string font;
        public string fontColor;
        public int fontSize;
        public ConstDisplayTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel)
        {
            this.bold = bold.ToString();
            this.italic = italic.ToString();
            this.underline = underline.ToString();
            this.font = font;
            this.fontColor = fontColor;
            this.fontSize = fontSize;
        }

        public ConstDisplayTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel)
        {

            this.bold = bold.ToString();
            this.italic = italic.ToString();
            this.underline = underline.ToString();
            this.font = font;
            this.fontColor = fontColor;
            this.fontSize = fontSize;
        }
    }
    public class DisplayItemTab : ConstDisplayTab
    {
        public int width;
        public string value;
        public DisplayItemTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.width = width;
            this.value = value;
        }

        public DisplayItemTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.width = width;
            this.value = value;
        }
        public DisplayItemTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, float value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.width = width;
            this.value = value.ToString();
        }

        public DisplayItemTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, float value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.width = width;
            this.value = value.ToString();
        }
        public bool ShouldSerializewidth()
        {
            return (this.width != 0);
        }

    }
    public class BigDisplayItemTab : DisplayItemTab
    {
        public int height;
        public BigDisplayItemTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, int height) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
            this.height = height;
        }

        public BigDisplayItemTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, int height) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
            this.height = height;
        }
        public bool ShouldSerializeheight()
        {
            return (this.height != 0);
        }
    }
    public class ButtonTab : ConstDisplayTab
    {
        public int width;
        public string buttonText;
        public ButtonTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string buttonText) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.width = width;
            this.buttonText = buttonText;
        }

        public ButtonTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string buttonText) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.width = width;
            this.buttonText = buttonText;
        }
        public bool ShouldSerializewidth()
        {
            return (this.width != 0);
        }
    }

    //Signing Tabs
    public class SignHereTab : Tab
    {
        public int scaleValue;

        public SignHereTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, int scaleValue) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel)
        {
            this.scaleValue = scaleValue;
        }

        public SignHereTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, int scaleValue) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel)
        {
            this.scaleValue = scaleValue;
        }
        public bool ShouldSerializescaleValue()
        {
            return (this.scaleValue != 0);
        }
    }
    public class InitialHereTab : Tab
    {
        public int scaleValue;

        public InitialHereTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, int scaleValue) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel)
        {
            this.scaleValue = scaleValue;
        }

        public InitialHereTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, int scaleValue) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel)
        {
            this.scaleValue = scaleValue;
        }
        public bool ShouldSerializescaleValue()
        {
            return (this.scaleValue != 0);
        }
    }
    public class ApproveTab : ButtonTab
    {
        public ApproveTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string buttonText) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, buttonText)
        {
        }

        public ApproveTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string buttonText) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, buttonText)
        {
        }
    }
    public class DeclineTab : ButtonTab
    {
        public DeclineTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string buttonText) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, buttonText)
        {
        }

        public DeclineTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string buttonText) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, buttonText)
        {
        }
    }

    //Attachments
    public class SignerAttachmentTab : Tab
    {
        public int scaleValue;

        public SignerAttachmentTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, int scaleValue) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel)
        {
            this.scaleValue = scaleValue;
        }

        public SignerAttachmentTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, int scaleValue) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel)
        {
            this.scaleValue = scaleValue;
        }
        public bool ShouldSerializescaleValue()
        {
            return (this.scaleValue != 0);
        }
    }

    //GUI Tabs
    public class CheckboxTab : Tab
    {
        public CheckboxTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel)
        {
        }

        public CheckboxTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel)
        {
        }
    }
    public class FormulaTab : DisplayItemTab
    {
        public string formula;
        public FormulaTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, string formula) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
            this.formula = formula;
        }

        public FormulaTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, string formula) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
            this.formula = formula;
        }
    }
    public class ListTab : ConstDisplayTab
    {
        public List<ListItem> listItems;

        public ListTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, string listItems) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            CreateList(listItems);
        }

        public ListTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, string listItems) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            CreateList(listItems);
        }
        public void CreateList(string listItems)
        {
            this.listItems = new List<ListItem>();
            var i = 0;
            foreach (string item in listItems.Split(','))
            {
                var trimmed_item = item.Trim();
                this.listItems.Add(new ListItem(trimmed_item, i.ToString()));
                i++;
            }
        }
    }
    public class ListItem
    {
        public string selected, text, value;

        public ListItem(string text, string value)
        {
            this.text = text;
            this.value = value;
        }
    }
    public class RadioGroupTab : Tab
    {
        public List<Radio> radios;

        public RadioGroupTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, int spacing, int radioItemCount) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel)
        {
            if (radios == null) radios = new List<Radio>();
            if (pageNumber == 0) pageNumber = 1;
            for (var i = 0; i< radioItemCount; i++)
                this.radios.Add(new Radio(xPos, yPos + spacing * i, docId, pageNumber));
        }

        public RadioGroupTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, int spacing, int radioItemCount) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel)
        {
            if (radios == null) radios = new List<Radio>();
            if (pageNumber == 0) pageNumber = 1;
            for (var i = 0; i< radioItemCount; i++)
                this.radios.Add(new Radio(anchorString, anchorXOffset, anchorYOffset + spacing * i, docId, pageNumber));
        }
    }
    public class Radio : Tab
    {
        public Radio(int xPos, int yPos, int docId, int pageNumber) : base(xPos, yPos, docId, pageNumber, null, null)
        {
        }

        public Radio(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, null, null)
        {
        }
    }

    //DisplayItem Tabs
    public class CompanyTab : DisplayItemTab
    {
        public CompanyTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public CompanyTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class DateSignedTab : DisplayItemTab
    {
        public DateSignedTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public DateSignedTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class DateTab : DisplayItemTab
    {
        public DateTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public DateTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class EmailTab : DisplayItemTab
    {
        public EmailTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public EmailTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class NumberTab : DisplayItemTab
    {
        public string locked = "false";
        public NumberTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, float value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public NumberTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, float value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class SSNTab : DisplayItemTab
    {
        public SSNTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public SSNTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class TitleTab : DisplayItemTab
    {
        public TitleTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public TitleTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }
    public class ZipTab : DisplayItemTab
    {
        public ZipTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }

        public ZipTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value)
        {
        }
    }

    //ConstDisplay Tabs
    public class EmailAddressTab : ConstDisplayTab
    {
        public string value;
        public EmailAddressTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, string value) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.value = value;
        }

        public EmailAddressTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, string value) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
            this.value = value;

        }
    }
    public class EnvelopeIDTab : ConstDisplayTab
    {
        public EnvelopeIDTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }

        public EnvelopeIDTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }
    }
    public class FirstNameTab : ConstDisplayTab
    {
        public FirstNameTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }

        public FirstNameTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }
    }
    public class LastNameTab : ConstDisplayTab
    {
        public LastNameTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }

        public LastNameTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }
    }
    public class FullNameTab : ConstDisplayTab
    {
        public FullNameTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }

        public FullNameTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize)
        {
        }
    }

    //Big Display Tabs
    public class NoteTab : BigDisplayItemTab
    {
        public NoteTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, int height) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value, height)
        {
        }

        public NoteTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, int height) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value, height)
        {
        }
    }
    public class TextTab : BigDisplayItemTab
    {
        public TextTab(int xPos, int yPos, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, int height) : base(xPos, yPos, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value, height)
        {
        }

        public TextTab(string anchorString, int anchorXOffset, int anchorYOffset, int docId, int pageNumber, string toolTip, string tabLabel, bool bold, bool italic, bool underline, string font, string fontColor, int fontSize, int width, string value, int height) : base(anchorString, anchorXOffset, anchorYOffset, docId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value, height)
        {
        }
    }
}
