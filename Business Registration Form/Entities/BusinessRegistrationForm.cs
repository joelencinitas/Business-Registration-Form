using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Business_Registration_Form.Entities
{
    public class BusinessRegistrationForm
    {
        private string companyName;
        private string companyType;
        private string streetAddress;
        private string city;
        private string state;
        private string zipCode;
        private string county;
        private string businessEmailAddress;
        private string businessPhone;
        private string businessDescription;
        private string businessContactPreference;
        private string dba;
        private string rentalBooth;
        private string homeBased;
        private string ein1;
        private string ein2;
        private string dateOpenedMonth;
        private string dateOpenedYear;
        private string website;
        private string nonProfit;
        private string mailingAddress;
        private string mailingCity;
        private string mailingState;
        private string mailingZipCode;
        private string mailingCounty;
        private string ownerFirstName;
        private string ownerMiddleName;
        private string ownerLastName;
        private string ownerTitle;
        private string ownerEmail;
        private string ownerBusinessPhone;
        private string ownerHomePhone;
        private string ownerMobilePhone;
        private string ownerContactPreference;
        private string ownerStreetAddress;
        private string ownerCity;
        private string ownerState;
        private string ownerZipCode;
        private string agentFirstName;
        private string agentMiddleName;
        private string agentLastName;
        private string agentTitle;
        private string agentEmail;
        private string agentMobilePhone;
        private string agentBusinessPhone;
        private string agentHomePhone;
        private string agentContactPreference;
        private string agentStreetAddress;
        private string agentCity;
        private string agentState;
        private string agentZipCode;
        private string chooseOne;
        private string perjury;
        private string signature;




        [Required(ErrorMessage = "Company Name is Required")]
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        [Required(ErrorMessage = "A Company Type is Required")]
        public string CompanyType
        {
            get
            {
                return companyType;
            }
            set
            {
                companyType = value;
            }
        }

        [Required(ErrorMessage = "Street Address is Required")]
        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }
            set
            {
                streetAddress = value;
            }
        }

        [Required(ErrorMessage = "City is Required")]
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        [Required(ErrorMessage = "State is Required")]
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }


        [Required(ErrorMessage = "Zip Code is Required")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please Enter a valid Zip Code")]
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

        public string County
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
            }
        }

        [Required(ErrorMessage = "A Business email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid Business Email Address")]
        public string BusinessEmailAddress
        {
            get
            {
                return businessEmailAddress;
            }
            set
            {
                businessEmailAddress = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string BusinessPhone
        {
            get
            {
                return businessPhone;
            }
            set
            {
                businessPhone = value;
            }
        }

        public string BusinessDescription
        {
            get
            {
                return businessDescription;
            }
            set
            {
                businessDescription = value;
            }
        }

        [Required(ErrorMessage = "A valid selection for Business Contact Preference is required")]
        public string BusinessContactPreference
        {
            get
            {
                return businessContactPreference;
            }
            set
            {
                businessContactPreference = value;
            }
        }

        public string DBA
        {
            get
            {
                return dba;
            }
            set
            {
                dba = value;
            }
        }

        [Required(ErrorMessage = "A valid selection for Rental Booth field is required")]
        public string RentalBooth
        {
            get
            {
                return rentalBooth;
            }
            set
            {
                rentalBooth = value;
            }
        }

        [Required(ErrorMessage = "A valid selection for Home Based Business field is required")]
        public string HomeBased
        {
            get
            {
                return homeBased;
            }
            set
            {
                homeBased = value;
            }
        }

        [RegularExpression(@"^(?!00)[0-9]{2,2}$", ErrorMessage = "Please Enter a valid first portion of your EIN")]
        public string EIN1
        {
            get
            {
                return ein1;
            }
            set
            {
                ein1 = value;
            }
        }

        [RegularExpression(@"^(?!0000000)[0-9]{7,7}$", ErrorMessage = "Please Enter a valid second portion of your EIN")]
        public string EIN2
        {
            get
            {
                return ein2;
            }
            set
            {
                ein2 = value;
            }
        }

        public string DateOpenedMonth
        {
            get
            {
                return dateOpenedMonth;
            }
            set
            {
                dateOpenedMonth = value;
            }
        }

        public string DateOpenedYear
        {
            get
            {
                return dateOpenedYear;
            }
            set
            {
                dateOpenedYear = value;
            }
        }

        [RegularExpression(@"(http://)?(www\.)?\w+\.(com|net|edu|org|gov|info|me)", ErrorMessage = "Please enter a valid url")]
        public string Website
        {
            get
            {
                return website;
            }
            set
            {
                website = value;
            }
        }


        [Required(ErrorMessage = "A valid selection for Non Profit field is required")]
        public string NonProfit
        {
            get
            {
                return nonProfit;
            }
            set
            {
                nonProfit = value;
            }
        }

        public string MailingAddress
        {
            get
            {
                return mailingAddress;
            }
            set
            {
                mailingAddress = value;
            }
        }

        public string MailingCity
        {
            get
            {
                return mailingCity;
            }
            set
            {
                mailingCity = value;
            }
        }

        public string MailingState
        {
            get
            {
                return mailingState;
            }
            set
            {
                mailingState = value;
            }
        }

        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please Enter a valid mailing zip code")]
        public string MailingZipCode
        {
            get
            {
                return mailingZipCode;
            }
            set
            {
                mailingZipCode = value;
            }
        }

        public string MailingCounty
        {
            get
            {
                return mailingCounty;
            }
            set
            {
                mailingCounty = value;
            }
        }

        [Required(ErrorMessage = "Owner First Name is required")]
        public string OwnerFirstName
        {
            get
            {
                return ownerFirstName;
            }
            set
            {
                ownerFirstName = value;
            }
        }

        public string OwnerMiddleName
        {
            get
            {
                return ownerMiddleName;
            }
            set
            {
                ownerMiddleName = value;
            }
        }

        [Required(ErrorMessage = "Owner Last Name is required")]
        public string OwnerLastName
        {
            get
            {
                return ownerLastName;
            }
            set
            {
                ownerLastName = value;
            }
        }

        public string OwnerTitle
        {
            get
            {
                return ownerTitle;
            }
            set
            {
                ownerTitle = value;
            }
        }

        [EmailAddress(ErrorMessage = "Please enter a valid Owner Email Address")]
        public string OwnerEmail
        {
            get
            {
                return ownerEmail;
            }
            set
            {
                ownerEmail = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string OwnerBusinessPhone
        {
            get
            {
                return ownerBusinessPhone;
            }
            set
            {
                ownerBusinessPhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string OwnerHomePhone
        {
            get
            {
                return ownerHomePhone;
            }
            set
            {
                ownerHomePhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string OwnerMobilePhone
        {
            get
            {
                return ownerMobilePhone;
            }
            set
            {
                ownerMobilePhone = value;
            }
        }

        [Required(ErrorMessage = "A valid selection for the Owner Contact Preference is required")]
        public string OwnerContactPreference
        {
            get
            {
                return ownerContactPreference;
            }
            set
            {
                ownerContactPreference = value;
            }
        }

        [Required(ErrorMessage = "Owner Street Address is required")]
        public string OwnerStreetAddress
        {
            get
            {
                return ownerStreetAddress;
            }
            set
            {
                ownerStreetAddress = value;
            }
        }


        [Required(ErrorMessage = "Owner City is required")]
        public string OwnerCity
        {
            get
            {
                return ownerCity;
            }
            set
            {
                ownerCity = value;
            }
        }

        [Required(ErrorMessage = "Owner State is required")]
        public string OwnerState
        {
            get
            {
                return ownerState;
            }
            set
            {
                ownerState = value;
            }
        }

        [Required(ErrorMessage = "Business Owner Zip Code is required")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please enter a valid Business Owner zip code")]
        public string OwnerZipCode
        {
            get
            {
                return ownerZipCode;
            }
            set
            {
                ownerZipCode = value;
            }
        }

        public string AgentFirstName
        {
            get
            {
                return agentFirstName;
            }
            set
            {
                agentFirstName = value;
            }
        }

        public string AgentMiddleName
        {
            get
            {
                return agentMiddleName;
            }
            set
            {
                agentMiddleName = value;
            }
        }

        public string AgentLastName
        {
            get
            {
                return agentLastName;
            }
            set
            {
                agentLastName = value;
            }
        }

        public string AgentTitle
        {
            get
            {
                return agentTitle;
            }
            set
            {
                agentTitle = value;
            }
        }

        [EmailAddress(ErrorMessage = "Please enter a valid agent email address")]
        public string AgentEmail
        {
            get
            {
                return agentEmail;
            }
            set
            {
                agentEmail = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid agent mobile number")]
        public string AgentMobilePhone
        {
            get
            {
                return agentMobilePhone;
            }
            set
            {
                agentMobilePhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid agent busines number")]
        public string AgentBusinessPhone
        {
            get
            {
                return agentBusinessPhone;
            }
            set
            {
                agentBusinessPhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid agent home phone number")]
        public string AgentHomePhone
        {
            get
            {
                return agentHomePhone;
            }
            set
            {
                agentHomePhone = value;
            }
        }

        public string AgentContactPreference
        {
            get
            {
                return agentContactPreference;
            }
            set
            {
                agentContactPreference = value;
            }
        }


        public string AgentStreetAddress
        {
            get
            {
                return agentStreetAddress;
            }
            set
            {
                agentStreetAddress = value;
            }
        }

        public string AgentCity
        {
            get
            {
                return agentCity;
            }
            set
            {
                agentCity = value;
            }
        }

        public string AgentState
        {
            get
            {
                return agentState;
            }
            set
            {
                agentState = value;
            }
        }

        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please enter a valid zip code")]
        public string AgentZipCode
        {
            get
            {
                return agentZipCode;
            }
            set
            {
                agentZipCode = value;
            }
        }

        public string ChooseOne
        {
            get
            {
                return chooseOne;
            }
            set
            {
                chooseOne = value;
            }
        }

        public string Perjury
        {
            get
            {
                return perjury;
            }
            set
            {
                perjury = value;
            }
        }

        [Required(ErrorMessage = "The signature field is required")]
        public string Signature
        {
            get
            {
                return signature;
            }
            set
            {
                signature = value;
            }
        }

    }
}