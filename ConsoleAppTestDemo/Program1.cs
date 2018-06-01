using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestDemo
{
    class Program1

    {
        //public Program1()
        //    {
        //    Rootobject root = new Rootobject();
        //    Primarynumber num = new Primarynumber();
           
        //    }
        static void Main(String [] args)
        {
            var shows = LoginAndDeserializeJson();
            Console.WriteLine(shows);

        }

        public static List<Primarynumber> JsonParseCounties(string jsonText)
        {
           
            return JsonConvert.DeserializeObject<Rootobject>(jsonText).Counties;
        }

        static string LoginAndDeserializeJson()
        {

            using (var client = new WebClientEx())
            {
                var values = new NameValueCollection
            {
                { "j_username", "patF@translation.ie" },
                { "j_password", "Watchm3n" },
            };
                Console.WriteLine("Validating username and password....\n");

                // Authenticate
                client.UploadValues("https://tie.interpreterintelligence.com/j_spring_security_check", values);
                Console.WriteLine("Successfully logged in to ii.....");
                Console.WriteLine();
                // Download desired page
                var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact/1347");
                Rootobject obj = new Rootobject();
                Primarynumber num = new Primarynumber();
                foreach (Primarynumber c in JsonParseCounties(json))
                {
                    Console.WriteLine(json);
                }

                return json;
            }

        }

        /// <summary>
        /// A custom WebClient featuring a cookie container
        /// </summary>

        public class WebClientEx : WebClient
        {
            public CookieContainer CookieContainer { get; private set; }

            public WebClientEx()
            {
                CookieContainer = new CookieContainer();
            }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request is HttpWebRequest)
                {
                    (request as HttpWebRequest).CookieContainer = CookieContainer;
                }
                return request;
            }
        }
    }
}

public class Rootobject
{
    public Rootobject()

    {

        Counties = new List<Primarynumber>();

    }





[JsonProperty("Everything")]
    public List<Primarynumber> Counties { get; set; }

   
    //public int id { get; set; }
    //public int versionValue { get; set; }
    //public string uuid { get; set; }
    //public string createdBy { get; set; }
    //public string createdDate { get; set; }
    //public string lastModifiedBy { get; set; }
    //public string lastModifiedDate { get; set; }
    //public int companyid { get; set; }
    //public string name { get; set; }
    //public string displayName { get; set; }
    //public string salutation { get; set; }
    //public string firstName { get; set; }
    //public string middleName { get; set; }
    //public string lastName { get; set; }
    //public string nickName { get; set; }
    //public string suffix { get; set; }
    //public int genderid { get; set; }
    //public string businessUnitid { get; set; }
    //public string dateOfBirth { get; set; }
    //public Contacttype[] contactTypes { get; set; }
    //public string accountingReference { get; set; }
    //public string referenceId { get; set; }
    //public Languagemapping[] languageMappings { get; set; }
    //public Primarynumber primaryNumber { get; set; }
    //public Number[] numbers { get; set; }
    //public Primaryaddress primaryAddress { get; set; }
    //public float lat { get; set; }
    //public float lng { get; set; }
    //public Address[] addresses { get; set; }
    //public Primaryemail primaryEmail { get; set; }
    //public Email[] emails { get; set; }
    //public Qualification[] qualifications { get; set; }
    //public Eligibility[] eligibilities { get; set; }
    //public object[] criteriaHierarchy { get; set; }
    //public bool hasTransportation { get; set; }
    //public bool hasChildren { get; set; }
    //public string notes { get; set; }
    //public object companyName { get; set; }
    //public string website { get; set; }
    //public object region { get; set; }
    //public string countryOfOrigin { get; set; }
    //public string countryOfResidence { get; set; }
    //public object countryOfNationality { get; set; }
    //public bool active { get; set; }
    //public string activeNote { get; set; }
    //public string availability { get; set; }
    //public string experience { get; set; }
    //public string registeredTaxId { get; set; }
    //public string bankAccount { get; set; }
    //public string sortCode { get; set; }
    //public string iban { get; set; }
    //public string swift { get; set; }
    //public string eftid { get; set; }
    //public string eftname { get; set; }
    //public int paymentMethodid { get; set; }
    //public string paymentMethodname { get; set; }
    //public object paymentAccount { get; set; }
    //public bool registeredTax { get; set; }
    //public string registeredTaxIdDescription { get; set; }
    //public int employmentCategoryid { get; set; }
    //public int assignmentTierid { get; set; }
    //public string timeZone { get; set; }
    //public string ethnicity { get; set; }
    //public object document { get; set; }
    //public string imagePath { get; set; }
    //public bool outOfOffice { get; set; }
    //public bool disableUpcomingReminder { get; set; }
    //public bool disableCloseReminder { get; set; }
    //public bool disableConfirmReminder { get; set; }
    //public object bankAccountDescription { get; set; }
    //public string timeWorked { get; set; }
    //public object activationDate { get; set; }
    //public object originalStartDate { get; set; }
    //public object datePhotoSentToPrinter { get; set; }
    //public object datePhotoSentToInterpreter { get; set; }
    //public object inductionDate { get; set; }
    //public object reActivationDate { get; set; }
    //public object iolNrcpdNumber { get; set; }
    //public object referralSource { get; set; }
    //public object refereeSourceName { get; set; }
    //public object recruiterName { get; set; }
    //public object taleoId { get; set; }
    //public object bankAccountReference { get; set; }
    //public Status status { get; set; }
    //public bool disableConfirmationEmails { get; set; }
    //public bool disableOfferEmails { get; set; }
    //public bool disableAutoOffers { get; set; }
    //public string currencyCodeid { get; set; }
    //public object currencySymbol { get; set; }
    //public string bankBranch { get; set; }
}

public class Primarynumber
{
    public int id { get; set; }
    public string parsedNumber { get; set; }
    public object numberFormatted { get; set; }
    public object countryCode { get; set; }
    public object areaCode { get; set; }
    public object number { get; set; }
    public int typeid { get; set; }
    public bool primaryNumber { get; set; }

    public override string ToString()
    {
        return $"Id : {id}\nParsed Number : {parsedNumber}\nNumber Formatted : {numberFormatted}\nCountry Code : {countryCode}\nArea Code : {areaCode}\nNumber : {number}\nType Id : {typeid}" +
            $"Primary Number : {primaryNumber}";
    }
}

//public class Primaryaddress
//{
//    public int id { get; set; }
//    public string clientid { get; set; }
//    public object clientLabel { get; set; }
//    public int companyid { get; set; }
//    public string customerid { get; set; }
//    public string customerBillingid { get; set; }
//    public string displayLabel { get; set; }
//    public object description { get; set; }
//    public object notes { get; set; }
//    public string addrEntered { get; set; }
//    public string addrFormatted { get; set; }
//    public object aptUnit { get; set; }
//    public object preamble { get; set; }
//    public object street1 { get; set; }
//    public object street2 { get; set; }
//    public object street3 { get; set; }
//    public object cityTown { get; set; }
//    public object stateCounty { get; set; }
//    public object postalCode { get; set; }
//    public object country { get; set; }
//    public bool primaryAddress { get; set; }
//    public bool valid { get; set; }
//    public string validationStatus { get; set; }
//    public bool validated { get; set; }
//    public int typeid { get; set; }
//    public float lat { get; set; }
//    public float lng { get; set; }
//    public object addressPhone { get; set; }
//    public object addressFax { get; set; }
//    public object addressEmail { get; set; }
//    public object contactPerson { get; set; }
//    public object costCenter { get; set; }
//    public bool active { get; set; }
//    public string parentid { get; set; }
//    public string parentlabel { get; set; }
//    public object publicNotes { get; set; }
//    public string regionid { get; set; }
//    public string billingRegionid { get; set; }
//    public object costCenterName { get; set; }
//    public object timeZone { get; set; }
//}

//public class Primaryemail
//{
//    public int id { get; set; }
//    public string emailAddress { get; set; }
//    public object addressVerified { get; set; }
//    public object dateVerified { get; set; }
//    public bool primaryEmail { get; set; }
//    public int typeid { get; set; }
//}

//public class Status
//{
//    public string _class { get; set; }
//    public int id { get; set; }
//    public bool defaultOption { get; set; }
//    public string description { get; set; }
//    public object l10nKey { get; set; }
//    public string name { get; set; }
//    public string nameKey { get; set; }
//}

//public class Contacttype
//{
//    public string _class { get; set; }
//    public int id { get; set; }
//    public bool defaultOption { get; set; }
//    public object description { get; set; }
//    public object l10nKey { get; set; }
//    public string name { get; set; }
//    public string nameKey { get; set; }
//}

//public class Languagemapping
//{
//    public int id { get; set; }
//    public int contactid { get; set; }
//    public int languageid { get; set; }
//    public Language language { get; set; }
//    public string rating { get; set; }
//}

//public class Language
//{
//    public int id { get; set; }
//    public string label { get; set; }
//    public string description { get; set; }
//    public string alternates { get; set; }
//    public string value { get; set; }
//    public string subtag { get; set; }
//    public string iso639_3Tag { get; set; }
//    public string type { get; set; }
//    public object alias { get; set; }
//    public bool enabled { get; set; }
//}

//public class Number
//{
//    public int id { get; set; }
//    public string parsedNumber { get; set; }
//    public object numberFormatted { get; set; }
//    public object countryCode { get; set; }
//    public object areaCode { get; set; }
//    public object number { get; set; }
//    public int typeid { get; set; }
//    public bool primaryNumber { get; set; }
//}

//public class Address
//{
//    public int id { get; set; }
//    public string clientid { get; set; }
//    public object clientLabel { get; set; }
//    public int companyid { get; set; }
//    public string customerid { get; set; }
//    public string customerBillingid { get; set; }
//    public string displayLabel { get; set; }
//    public object description { get; set; }
//    public object notes { get; set; }
//    public string addrEntered { get; set; }
//    public string addrFormatted { get; set; }
//    public object aptUnit { get; set; }
//    public object preamble { get; set; }
//    public object street1 { get; set; }
//    public object street2 { get; set; }
//    public object street3 { get; set; }
//    public object cityTown { get; set; }
//    public object stateCounty { get; set; }
//    public object postalCode { get; set; }
//    public object country { get; set; }
//    public bool primaryAddress { get; set; }
//    public bool valid { get; set; }
//    public string validationStatus { get; set; }
//    public bool validated { get; set; }
//    public int typeid { get; set; }
//    public float lat { get; set; }
//    public float lng { get; set; }
//    public object addressPhone { get; set; }
//    public object addressFax { get; set; }
//    public object addressEmail { get; set; }
//    public object contactPerson { get; set; }
//    public object costCenter { get; set; }
//    public bool active { get; set; }
//    public string parentid { get; set; }
//    public string parentlabel { get; set; }
//    public object publicNotes { get; set; }
//    public string regionid { get; set; }
//    public string billingRegionid { get; set; }
//    public object costCenterName { get; set; }
//    public object timeZone { get; set; }
//}

//public class Email
//{
//    public int id { get; set; }
//    public string emailAddress { get; set; }
//    public object addressVerified { get; set; }
//    public object dateVerified { get; set; }
//    public bool primaryEmail { get; set; }
//    public int typeid { get; set; }
//}

//public class Qualification
//{
//    public int id { get; set; }
//    public string createdDate { get; set; }
//    public string createdBy { get; set; }
//    public string lastModifiedDate { get; set; }
//    public string lastModifiedBy { get; set; }
//    public int companyid { get; set; }
//    public int criteriaid { get; set; }
//    public bool customerSpecific { get; set; }
//    public string enforcementPolicy { get; set; }
//    public string name { get; set; }
//    public string description { get; set; }
//    public bool validated { get; set; }
//    public string validatedStatus { get; set; }
//    public string validatedDate { get; set; }
//    public string validatedBy { get; set; }
//    public string validUntil { get; set; }
//    public State state { get; set; }
//    public string stateDateSince { get; set; }
//    public string stateDateUntil { get; set; }
//    public string notes { get; set; }
//    public object[] documents { get; set; }
//    public string criteriaType { get; set; }
//    public string languageid { get; set; }
//    public string languageLabel { get; set; }
//    public string languageCode { get; set; }
//    public string supportingInformation { get; set; }
//}

//public class State
//{
//    public string _class { get; set; }
//    public int id { get; set; }
//    public bool defaultOption { get; set; }
//    public string description { get; set; }
//    public object l10nKey { get; set; }
//    public string name { get; set; }
//    public string nameKey { get; set; }
//}

//public class Eligibility
//{
//    public int id { get; set; }
//    public string createdDate { get; set; }
//    public string createdBy { get; set; }
//    public string lastModifiedDate { get; set; }
//    public string lastModifiedBy { get; set; }
//    public int companyid { get; set; }
//    public int criteriaid { get; set; }
//    public bool? customerSpecific { get; set; }
//    public string enforcementPolicy { get; set; }
//    public string name { get; set; }
//    public string description { get; set; }
//    public bool validated { get; set; }
//    public string validatedStatus { get; set; }
//    public string validatedDate { get; set; }
//    public string validatedBy { get; set; }
//    public string validUntil { get; set; }
//    public State1 state { get; set; }
//    public string stateDateSince { get; set; }
//    public string stateDateUntil { get; set; }
//    public string notes { get; set; }
//    public object[] documents { get; set; }
//    public string criteriaType { get; set; }
//    public string languageid { get; set; }
//    public string languageLabel { get; set; }
//    public string languageCode { get; set; }
//    public string supportingInformation { get; set; }
//}

//public class State1
//{
//    public string _class { get; set; }
//    public int id { get; set; }
//    public bool defaultOption { get; set; }
//    public string description { get; set; }
//    public object l10nKey { get; set; }
//    public string name { get; set; }
//    public string nameKey { get; set; }
//}



