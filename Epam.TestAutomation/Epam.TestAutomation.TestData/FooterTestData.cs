using Epam.TestAutomation.TestData.Models;

namespace Epam.TestAutomation.TestData
{
    public static class FooterTestData
    {
        public static List<FooterLinkModel> FooterPages = new List<FooterLinkModel>()
        {
            new FooterLinkModel
            {
                FooterLink = "EPAM CONTINUUM",
                Url = "/services/epam-continuum"
            },
            new FooterLinkModel
            {
                FooterLink = "INVESTORS",
                Url = "/investors"
            },
            new FooterLinkModel
            {
                FooterLink = "OPEN SOURCE",
                Url = "/services/engineering/open-source"
            }
        };

        public static List<FooterLinkModel> GetFooterLinks()
        {
            return new List<FooterLinkModel>()
            {
                new FooterLinkModel
                {
                    FooterLink = "EPAM CONTINUUM",
                    Url = "/services/epam-continuum"
                },
            new FooterLinkModel
            {
                FooterLink = "INVESTORS",
                Url = "/investors"
            },
            new FooterLinkModel
            {
                FooterLink = "OPEN SOURCE",
                Url = "/services/engineering/open-source"
            }
        };
        }
    }
}
