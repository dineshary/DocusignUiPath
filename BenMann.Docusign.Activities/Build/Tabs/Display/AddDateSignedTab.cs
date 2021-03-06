using Docusign.DocusignTypes;
using System.Activities;
using System.ComponentModel;

namespace Docusign.Tabs.Display
{
    [DisplayName("Add Date Signed Tab")]
    public sealed class AddDateSignedTab : AddDisplayItemTab
    {
        [Browsable(false)]
        public override InArgument<string> Value { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            Initialize(context);
            DateSignedTab dateSignedTab;

            if (anchorText != null)
                dateSignedTab = new DateSignedTab(anchorText, offsetX, offsetY, doc.documentId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value);
            else
                dateSignedTab = new DateSignedTab(sigX, sigY, doc.documentId, pageNumber, toolTip, tabLabel, bold, italic, underline, font, fontColor, fontSize, width, value);

            AddTabToRecipient(dateSignedTab);
        }
    }
}
