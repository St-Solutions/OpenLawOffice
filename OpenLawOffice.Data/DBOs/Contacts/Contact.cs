﻿// -----------------------------------------------------------------------
// <copyright file="Contact.cs" company="Nodine Legal, LLC">
// Licensed to Nodine Legal, LLC under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  Nodine Legal, LLC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>
// -----------------------------------------------------------------------

namespace OpenLawOffice.Data.DBOs.Contacts
{
    using System;
    using AutoMapper;

    /// <summary>
    /// Represents a system contact, loosely based on MS-OXONTC's message syntax for contact object properties
    /// http://msdn.microsoft.com/en-us/library/ee179200(v=exchg.80).aspx
    /// </summary>
    [Common.Models.MapMe]
    public class Contact : Core
    {
        [ColumnMapping(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the contact is an organization.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the contact is an organization; otherwise, <c>false</c>.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "is_organization")]
        public bool IsOrganization { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the contact is an employee of the firm, this
        /// allows for booking of time.
        /// </summary>
        /// <value>
        ///   <c>true</c> if a firm employee; otherwise, <c>false</c>.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "is_our_employee")]
        public bool IsOurEmployee { get; set; }

        [ColumnMapping(Name = "billing_rate_id")]
        public int? BillingRateId { get; set; }

        #region Contact Name

        /// <summary>
        /// Gets or sets the nickname of the contact.
        /// </summary>
        /// <value>
        /// The nickname.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the generation suffix of the contact, such as "Jr.", "Sr.", or "III".
        /// </summary>
        /// <value>
        /// The generation.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "generation")]
        public string Generation { get; set; }

        /// <summary>
        /// Gets or sets the title of the contact, such as "Mr." or "Mrs.".
        /// </summary>
        /// <value>
        /// The display name prefix.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "display_name_prefix")]
        public string DisplayNamePrefix { get; set; }

        /// <summary>
        /// Gets or sets the surname (family name) of the contact.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the middle name(s) of the contact.
        /// </summary>
        /// <value>
        /// The middle name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the given name (first name) of the contact.
        /// </summary>
        /// <value>
        /// The given name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the initials of the contact.
        /// </summary>
        /// <value>
        /// The initials.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "initials")]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or sets the full name of the contact.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "display_name")]
        public string DisplayName { get; set; }

        #endregion Contact Name

        #region Electronic Address Properties

        /// <summary>
        /// Gets or sets the user-readable display name for the e-mail address of the contact such as "Home", "Work", "Phone", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "email1_display_name")]
        public string Email1DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "email1_email_address")]
        public string Email1EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the e-mail address of the contact such as "Home", "Work", "Phone", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "email2_display_name")]
        public string Email2DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "email2_email_address")]
        public string Email2EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the e-mail address of the contact such as "Home", "Work", "Phone", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "email3_display_name")]
        public string Email3DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "email3_email_address")]
        public string Email3EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the e-mail address of the contact such as "Home", "Work", "Phone", etc..
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "fax1_display_name")]
        public string Fax1DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the fax number for the contact.
        /// </summary>
        /// <value>
        /// The fax number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "fax1_fax_number")]
        public string Fax1FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the e-mail address of the contact such as "Home", "Work", "Phone", etc..
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "fax2_display_name")]
        public string Fax2DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the fax number for the contact.
        /// </summary>
        /// <value>
        /// The fax number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "fax2_fax_number")]
        public string Fax2FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the e-mail address of the contact such as "Home", "Work", "Phone", etc..
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "fax3_display_name")]
        public string Fax3DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the fax number for the contact.
        /// </summary>
        /// <value>
        /// The fax number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "fax3_fax_number")]
        public string Fax3FaxNumber { get; set; }

        #endregion Electronic Address Properties

        #region Physical Address Properties

        /// <summary>
        /// Gets or sets the user-readable display name for the address of the contact such as "Home", "Work", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_display_name")]
        public string Address1DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the street portion of the address.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_street")]
        public string Address1AddressStreet { get; set; }

        /// <summary>
        /// Gets or sets the city portion of the address.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_city")]
        public string Address1AddressCity { get; set; }

        /// <summary>
        /// Gets or sets the state or province portion of the address.
        /// </summary>
        /// <value>
        /// The state or province.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_state_or_province")]
        public string Address1AddressStateOrProvince { get; set; }

        /// <summary>
        /// Gets or sets the postal code portion of the address.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_postal_code")]
        public string Address1AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country portion of the address.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_country")]
        public string Address1AddressCountry { get; set; }

        /// <summary>
        /// Gets or sets the country/region code portion of the address.
        /// </summary>
        /// <value>
        /// The country/region code.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_country_code")]
        public string Address1AddressCountryCode { get; set; }

        /// <summary>
        /// Gets or sets the post office box portion of the address.
        /// </summary>
        /// <value>
        /// The post office box.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address1_address_post_office_box")]
        public string Address1AddressPostOfficeBox { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the address of the contact such as "Home", "Work", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_display_name")]
        public string Address2DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the street portion of the address.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_street")]
        public string Address2AddressStreet { get; set; }

        /// <summary>
        /// Gets or sets the city portion of the address.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_city")]
        public string Address2AddressCity { get; set; }

        /// <summary>
        /// Gets or sets the state or province portion of the address.
        /// </summary>
        /// <value>
        /// The state or province.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_state_or_province")]
        public string Address2AddressStateOrProvince { get; set; }

        /// <summary>
        /// Gets or sets the postal code portion of the address.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_postal_code")]
        public string Address2AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country portion of the address.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_country")]
        public string Address2AddressCountry { get; set; }

        /// <summary>
        /// Gets or sets the country/region code portion of the address.
        /// </summary>
        /// <value>
        /// The country/region code.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_country_code")]
        public string Address2AddressCountryCode { get; set; }

        /// <summary>
        /// Gets or sets the post office box portion of the address.
        /// </summary>
        /// <value>
        /// The post office box.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address2_address_post_office_box")]
        public string Address2AddressPostOfficeBox { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the address of the contact such as "Home", "Work", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_display_name")]
        public string Address3DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the street portion of the address.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_street")]
        public string Address3AddressStreet { get; set; }

        /// <summary>
        /// Gets or sets the city portion of the address.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_city")]
        public string Address3AddressCity { get; set; }

        /// <summary>
        /// Gets or sets the state or province portion of the address.
        /// </summary>
        /// <value>
        /// The state or province.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_state_or_province")]
        public string Address3AddressStateOrProvince { get; set; }

        /// <summary>
        /// Gets or sets the postal code portion of the address.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_postal_code")]
        public string Address3AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country portion of the address.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_country")]
        public string Address3AddressCountry { get; set; }

        /// <summary>
        /// Gets or sets the country/region code portion of the address.
        /// </summary>
        /// <value>
        /// The country/region code.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_country_code")]
        public string Address3AddressCountryCode { get; set; }

        /// <summary>
        /// Gets or sets the post office box portion of the address.
        /// </summary>
        /// <value>
        /// The post office box.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "address3_address_post_office_box")]
        public string Address3AddressPostOfficeBox { get; set; }

        #endregion Physical Address Properties

        #region Telephone Properties

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone1_display_name")]
        public string Telephone1DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone1_telephone_number")]
        public string Telephone1TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone2_display_name")]
        public string Telephone2DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone2_telephone_number")]
        public string Telephone2TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone3_display_name")]
        public string Telephone3DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone3_telephone_number")]
        public string Telephone3TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone4_display_name")]
        public string Telephone4DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone4_telephone_number")]
        public string Telephone4TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone5_display_name")]
        public string Telephone5DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone5_telephone_number")]
        public string Telephone5TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone6_display_name")]
        public string Telephone6DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone6_telephone_number")]
        public string Telephone6TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone7_display_name")]
        public string Telephone7DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone7_telephone_number")]
        public string Telephone7TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone8_display_name")]
        public string Telephone8DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone_8_telephone_number")]
        public string Telephone8TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone9_display_name")]
        public string Telephone9DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone9_telephone_number")]
        public string Telephone9TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user-readable display name for the telephone number of the contact such as "Home", "Work", "Mobile", "Assistant", etc.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone10_display_name")]
        public string Telephone10DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        /// <value>
        /// The telephone number.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "telephone10_telephone_number")]
        public string Telephone10TelephoneNumber { get; set; }

        #endregion Telephone Properties

        #region Event Properties

        /// <summary>
        /// Gets or sets the birthday of the contact.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the wedding anniversary of the contact.
        /// </summary>
        /// <value>
        /// The wedding anniversary.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "wedding")]
        public DateTime? Wedding { get; set; }

        #endregion Event Properties

        #region Professional Properties

        /// <summary>
        /// Gets or sets the job title of the contact.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the company that employs the contact.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the name of the department to which the contact belongs.
        /// </summary>
        /// <value>
        /// The name of the department.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets the location of the office that the contact works in.
        /// </summary>
        /// <value>
        /// The office location.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "office_location")]
        public string OfficeLocation { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact's manager.
        /// </summary>
        /// <value>
        /// The name of the manager.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "manager_name")]
        public string ManagerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact's assistant.
        /// </summary>
        /// <value>
        /// The name of the assistant.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "assistant_name")]
        public string AssistantName { get; set; }

        /// <summary>
        /// Gets or sets the profession of the contact.
        /// </summary>
        /// <value>
        /// The profession.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "profession")]
        public string Profession { get; set; }

        #endregion Professional Properties

        #region Other Contact Properties

        /// <summary>
        /// Gets or sets the name of the contact's spouse/partner.
        /// </summary>
        /// <value>
        /// The name of the spouse/partner.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "spouse_name")]
        public string SpouseName { get; set; }

        /// <summary>
        /// Gets or sets the language that the contact uses.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the contact's instant messaging address.
        /// </summary>
        /// <value>
        /// The instant messaging address.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "instant_messaging_address")]
        public string InstantMessagingAddress { get; set; }

        /// <summary>
        /// Gets or sets the personal home page URL.
        /// </summary>
        /// <value>
        /// The personal home page.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "personal_home_page")]
        public string PersonalHomePage { get; set; }

        /// <summary>
        /// Gets or sets the business home page URL.
        /// </summary>
        /// <value>
        /// The business home page.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "business_home_page")]
        public string BusinessHomePage { get; set; }

        /// <summary>
        /// Gets or sets the gender of the contact.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the name of the person who referred this contact.
        /// </summary>
        /// <value>
        /// The referrer.
        /// </value>
        /// <author>Lucas Nodine</author>
        [ColumnMapping(Name = "referred_by_name")]
        public string ReferredByName { get; set; }

        #endregion Other Contact Properties

        public void BuildMappings()
        {
            Dapper.SqlMapper.SetTypeMap(typeof(Contact), new ColumnAttributeTypeMapper<Contact>());
            Mapper.CreateMap<DBOs.Contacts.Contact, Common.Models.Contacts.Contact>()
                .ForMember(dst => dst.IsStub, opt => opt.UseValue(false))
                .ForMember(dst => dst.Created, opt => opt.ResolveUsing(db =>
                {
                    return db.UtcCreated.ToSystemTime();
                }))
                .ForMember(dst => dst.Modified, opt => opt.ResolveUsing(db =>
                {
                    return db.UtcModified.ToSystemTime();
                }))
                .ForMember(dst => dst.Disabled, opt => opt.ResolveUsing(db =>
                {
                    return db.UtcDisabled.ToSystemTime();
                }))
                .ForMember(dst => dst.CreatedBy, opt => opt.ResolveUsing(db =>
                {
                    return new Common.Models.Account.Users()
                    {
                        PId = db.CreatedByUserPId,
                        IsStub = true
                    };
                }))
                .ForMember(dst => dst.ModifiedBy, opt => opt.ResolveUsing(db =>
                {
                    return new Common.Models.Account.Users()
                    {
                        PId = db.ModifiedByUserPId,
                        IsStub = true
                    };
                }))
                .ForMember(dst => dst.DisabledBy, opt => opt.ResolveUsing(db =>
                {
                    if (!db.DisabledByUserPId.HasValue) return null;
                    return new Common.Models.Account.Users()
                    {
                        PId = db.DisabledByUserPId.Value,
                        IsStub = true
                    };
                }))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.IsOrganization, opt => opt.MapFrom(src => src.IsOrganization))
                .ForMember(dst => dst.IsOurEmployee, opt => opt.MapFrom(src => src.IsOurEmployee))
                .ForMember(dst => dst.BillingRate, opt => opt.ResolveUsing(db =>
                {
                    return new Common.Models.Billing.BillingRate()
                    {
                        Id = db.BillingRateId,
                        IsStub = true
                    };
                }))
                .ForMember(dst => dst.Nickname, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dst => dst.Generation, opt => opt.MapFrom(src => src.Generation))
                .ForMember(dst => dst.DisplayNamePrefix, opt => opt.MapFrom(src => src.DisplayNamePrefix))
                .ForMember(dst => dst.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dst => dst.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dst => dst.GivenName, opt => opt.MapFrom(src => src.GivenName))
                .ForMember(dst => dst.Initials, opt => opt.MapFrom(src => src.Initials))
                .ForMember(dst => dst.DisplayName, opt => opt.MapFrom(src => src.DisplayName))
                .ForMember(dst => dst.Email1DisplayName, opt => opt.MapFrom(src => src.Email1DisplayName))
                .ForMember(dst => dst.Email1EmailAddress, opt => opt.MapFrom(src => src.Email1EmailAddress))
                .ForMember(dst => dst.Email2DisplayName, opt => opt.MapFrom(src => src.Email2DisplayName))
                .ForMember(dst => dst.Email2EmailAddress, opt => opt.MapFrom(src => src.Email2EmailAddress))
                .ForMember(dst => dst.Email3DisplayName, opt => opt.MapFrom(src => src.Email3DisplayName))
                .ForMember(dst => dst.Fax1DisplayName, opt => opt.MapFrom(src => src.Fax1DisplayName))
                .ForMember(dst => dst.Fax1FaxNumber, opt => opt.MapFrom(src => src.Fax1FaxNumber))
                .ForMember(dst => dst.Fax2DisplayName, opt => opt.MapFrom(src => src.Fax2DisplayName))
                .ForMember(dst => dst.Fax2FaxNumber, opt => opt.MapFrom(src => src.Fax2FaxNumber))
                .ForMember(dst => dst.Fax3DisplayName, opt => opt.MapFrom(src => src.Fax3DisplayName))
                .ForMember(dst => dst.Fax3FaxNumber, opt => opt.MapFrom(src => src.Fax3FaxNumber))
                .ForMember(dst => dst.Address1DisplayName, opt => opt.MapFrom(src => src.Address1DisplayName))
                .ForMember(dst => dst.Address1AddressStreet, opt => opt.MapFrom(src => src.Address1AddressStreet))
                .ForMember(dst => dst.Address1AddressCity, opt => opt.MapFrom(src => src.Address1AddressCity))
                .ForMember(dst => dst.Address1AddressStateOrProvince, opt => opt.MapFrom(src => src.Address1AddressStateOrProvince))
                .ForMember(dst => dst.Address1AddressPostalCode, opt => opt.MapFrom(src => src.Address1AddressPostalCode))
                .ForMember(dst => dst.Address1AddressCountry, opt => opt.MapFrom(src => src.Address1AddressCountry))
                .ForMember(dst => dst.Address1AddressCountryCode, opt => opt.MapFrom(src => src.Address1AddressCountryCode))
                .ForMember(dst => dst.Address1AddressPostOfficeBox, opt => opt.MapFrom(src => src.Address1AddressPostOfficeBox))
                .ForMember(dst => dst.Address2DisplayName, opt => opt.MapFrom(src => src.Address2DisplayName))
                .ForMember(dst => dst.Address2AddressStreet, opt => opt.MapFrom(src => src.Address2AddressStreet))
                .ForMember(dst => dst.Address2AddressCity, opt => opt.MapFrom(src => src.Address2AddressCity))
                .ForMember(dst => dst.Address2AddressStateOrProvince, opt => opt.MapFrom(src => src.Address2AddressStateOrProvince))
                .ForMember(dst => dst.Address2AddressPostalCode, opt => opt.MapFrom(src => src.Address2AddressPostalCode))
                .ForMember(dst => dst.Address2AddressCountry, opt => opt.MapFrom(src => src.Address2AddressCountry))
                .ForMember(dst => dst.Address2AddressCountryCode, opt => opt.MapFrom(src => src.Address2AddressCountryCode))
                .ForMember(dst => dst.Address2AddressPostOfficeBox, opt => opt.MapFrom(src => src.Address2AddressPostOfficeBox))
                .ForMember(dst => dst.Address3DisplayName, opt => opt.MapFrom(src => src.Address3DisplayName))
                .ForMember(dst => dst.Address3AddressStreet, opt => opt.MapFrom(src => src.Address3AddressStreet))
                .ForMember(dst => dst.Address3AddressCity, opt => opt.MapFrom(src => src.Address3AddressCity))
                .ForMember(dst => dst.Address3AddressStateOrProvince, opt => opt.MapFrom(src => src.Address3AddressStateOrProvince))
                .ForMember(dst => dst.Address3AddressPostalCode, opt => opt.MapFrom(src => src.Address3AddressPostalCode))
                .ForMember(dst => dst.Address3AddressCountry, opt => opt.MapFrom(src => src.Address3AddressCountry))
                .ForMember(dst => dst.Address3AddressCountryCode, opt => opt.MapFrom(src => src.Address3AddressCountryCode))
                .ForMember(dst => dst.Address3AddressPostOfficeBox, opt => opt.MapFrom(src => src.Address3AddressPostOfficeBox))
                .ForMember(dst => dst.Telephone1DisplayName, opt => opt.MapFrom(src => src.Telephone1DisplayName))
                .ForMember(dst => dst.Telephone1TelephoneNumber, opt => opt.MapFrom(src => src.Telephone1TelephoneNumber))
                .ForMember(dst => dst.Telephone2DisplayName, opt => opt.MapFrom(src => src.Telephone2DisplayName))
                .ForMember(dst => dst.Telephone2TelephoneNumber, opt => opt.MapFrom(src => src.Telephone2TelephoneNumber))
                .ForMember(dst => dst.Telephone3DisplayName, opt => opt.MapFrom(src => src.Telephone3DisplayName))
                .ForMember(dst => dst.Telephone3TelephoneNumber, opt => opt.MapFrom(src => src.Telephone3TelephoneNumber))
                .ForMember(dst => dst.Telephone4DisplayName, opt => opt.MapFrom(src => src.Telephone4DisplayName))
                .ForMember(dst => dst.Telephone4TelephoneNumber, opt => opt.MapFrom(src => src.Telephone4TelephoneNumber))
                .ForMember(dst => dst.Telephone5DisplayName, opt => opt.MapFrom(src => src.Telephone5DisplayName))
                .ForMember(dst => dst.Telephone5TelephoneNumber, opt => opt.MapFrom(src => src.Telephone5TelephoneNumber))
                .ForMember(dst => dst.Telephone6DisplayName, opt => opt.MapFrom(src => src.Telephone6DisplayName))
                .ForMember(dst => dst.Telephone6TelephoneNumber, opt => opt.MapFrom(src => src.Telephone6TelephoneNumber))
                .ForMember(dst => dst.Telephone7DisplayName, opt => opt.MapFrom(src => src.Telephone7DisplayName))
                .ForMember(dst => dst.Telephone7TelephoneNumber, opt => opt.MapFrom(src => src.Telephone7TelephoneNumber))
                .ForMember(dst => dst.Telephone8DisplayName, opt => opt.MapFrom(src => src.Telephone8DisplayName))
                .ForMember(dst => dst.Telephone8TelephoneNumber, opt => opt.MapFrom(src => src.Telephone8TelephoneNumber))
                .ForMember(dst => dst.Telephone9DisplayName, opt => opt.MapFrom(src => src.Telephone9DisplayName))
                .ForMember(dst => dst.Telephone9TelephoneNumber, opt => opt.MapFrom(src => src.Telephone9TelephoneNumber))
                .ForMember(dst => dst.Telephone10DisplayName, opt => opt.MapFrom(src => src.Telephone10DisplayName))
                .ForMember(dst => dst.Telephone10TelephoneNumber, opt => opt.MapFrom(src => src.Telephone10TelephoneNumber))
                .ForMember(dst => dst.Birthday, opt => opt.ResolveUsing(db =>
                {
                    return db.Birthday.ToSystemTime();
                }))
                .ForMember(dst => dst.Wedding, opt => opt.ResolveUsing(db =>
                {
                    return db.Wedding.ToSystemTime();
                }))
                .ForMember(dst => dst.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dst => dst.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
                .ForMember(dst => dst.DepartmentName, opt => opt.MapFrom(src => src.DepartmentName))
                .ForMember(dst => dst.OfficeLocation, opt => opt.MapFrom(src => src.OfficeLocation))
                .ForMember(dst => dst.ManagerName, opt => opt.MapFrom(src => src.ManagerName))
                .ForMember(dst => dst.AssistantName, opt => opt.MapFrom(src => src.AssistantName))
                .ForMember(dst => dst.Profession, opt => opt.MapFrom(src => src.Profession))
                .ForMember(dst => dst.SpouseName, opt => opt.MapFrom(src => src.SpouseName))
                .ForMember(dst => dst.Language, opt => opt.MapFrom(src => src.Language))
                .ForMember(dst => dst.InstantMessagingAddress, opt => opt.MapFrom(src => src.InstantMessagingAddress))
                .ForMember(dst => dst.PersonalHomePage, opt => opt.MapFrom(src => src.PersonalHomePage))
                .ForMember(dst => dst.BusinessHomePage, opt => opt.MapFrom(src => src.BusinessHomePage))
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dst => dst.ReferredByName, opt => opt.MapFrom(src => src.ReferredByName));

            Mapper.CreateMap<Common.Models.Contacts.Contact, DBOs.Contacts.Contact>()
                .ForMember(dst => dst.UtcCreated, opt => opt.ResolveUsing(db =>
                {
                    return db.Created.ToDbTime();
                }))
                .ForMember(dst => dst.UtcModified, opt => opt.ResolveUsing(db =>
                {
                    return db.Modified.ToDbTime();
                }))
                .ForMember(dst => dst.UtcDisabled, opt => opt.ResolveUsing(db =>
                {
                    return db.Disabled.ToDbTime();
                }))
                .ForMember(dst => dst.CreatedByUserPId, opt => opt.ResolveUsing(model =>
                {
                    if (model.CreatedBy == null || !model.CreatedBy.PId.HasValue)
                        return Guid.Empty;
                    return model.CreatedBy.PId.Value;
                }))
                .ForMember(dst => dst.ModifiedByUserPId, opt => opt.ResolveUsing(model =>
                {
                    if (model.ModifiedBy == null || !model.ModifiedBy.PId.HasValue)
                        return Guid.Empty;
                    return model.ModifiedBy.PId.Value;
                }))
                .ForMember(dst => dst.DisabledByUserPId, opt => opt.ResolveUsing(model =>
                {
                    if (model.DisabledBy == null) return null;
                    return model.DisabledBy.PId;
                }))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.IsOrganization, opt => opt.MapFrom(src => src.IsOrganization))
                .ForMember(dst => dst.IsOurEmployee, opt => opt.MapFrom(src => src.IsOurEmployee))
                .ForMember(dst => dst.BillingRateId, opt => opt.ResolveUsing(model =>
                {
                    if (model.BillingRate == null || !model.BillingRate.Id.HasValue)
                        return null;
                    return model.BillingRate.Id.Value;
                }))
                .ForMember(dst => dst.Nickname, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dst => dst.Generation, opt => opt.MapFrom(src => src.Generation))
                .ForMember(dst => dst.DisplayNamePrefix, opt => opt.MapFrom(src => src.DisplayNamePrefix))
                .ForMember(dst => dst.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dst => dst.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dst => dst.GivenName, opt => opt.MapFrom(src => src.GivenName))
                .ForMember(dst => dst.Initials, opt => opt.MapFrom(src => src.Initials))
                .ForMember(dst => dst.DisplayName, opt => opt.MapFrom(src => src.DisplayName))
                .ForMember(dst => dst.Email1DisplayName, opt => opt.MapFrom(src => src.Email1DisplayName))
                .ForMember(dst => dst.Email1EmailAddress, opt => opt.MapFrom(src => src.Email1EmailAddress))
                .ForMember(dst => dst.Email2DisplayName, opt => opt.MapFrom(src => src.Email2DisplayName))
                .ForMember(dst => dst.Email2EmailAddress, opt => opt.MapFrom(src => src.Email2EmailAddress))
                .ForMember(dst => dst.Email3DisplayName, opt => opt.MapFrom(src => src.Email3DisplayName))
                .ForMember(dst => dst.Fax1DisplayName, opt => opt.MapFrom(src => src.Fax1DisplayName))
                .ForMember(dst => dst.Fax1FaxNumber, opt => opt.MapFrom(src => src.Fax1FaxNumber))
                .ForMember(dst => dst.Fax2DisplayName, opt => opt.MapFrom(src => src.Fax2DisplayName))
                .ForMember(dst => dst.Fax2FaxNumber, opt => opt.MapFrom(src => src.Fax2FaxNumber))
                .ForMember(dst => dst.Fax3DisplayName, opt => opt.MapFrom(src => src.Fax3DisplayName))
                .ForMember(dst => dst.Fax3FaxNumber, opt => opt.MapFrom(src => src.Fax3FaxNumber))
                .ForMember(dst => dst.Address1DisplayName, opt => opt.MapFrom(src => src.Address1DisplayName))
                .ForMember(dst => dst.Address1AddressStreet, opt => opt.MapFrom(src => src.Address1AddressStreet))
                .ForMember(dst => dst.Address1AddressCity, opt => opt.MapFrom(src => src.Address1AddressCity))
                .ForMember(dst => dst.Address1AddressStateOrProvince, opt => opt.MapFrom(src => src.Address1AddressStateOrProvince))
                .ForMember(dst => dst.Address1AddressPostalCode, opt => opt.MapFrom(src => src.Address1AddressPostalCode))
                .ForMember(dst => dst.Address1AddressCountry, opt => opt.MapFrom(src => src.Address1AddressCountry))
                .ForMember(dst => dst.Address1AddressCountryCode, opt => opt.MapFrom(src => src.Address1AddressCountryCode))
                .ForMember(dst => dst.Address1AddressPostOfficeBox, opt => opt.MapFrom(src => src.Address1AddressPostOfficeBox))
                .ForMember(dst => dst.Address2DisplayName, opt => opt.MapFrom(src => src.Address2DisplayName))
                .ForMember(dst => dst.Address2AddressStreet, opt => opt.MapFrom(src => src.Address2AddressStreet))
                .ForMember(dst => dst.Address2AddressCity, opt => opt.MapFrom(src => src.Address2AddressCity))
                .ForMember(dst => dst.Address2AddressStateOrProvince, opt => opt.MapFrom(src => src.Address2AddressStateOrProvince))
                .ForMember(dst => dst.Address2AddressPostalCode, opt => opt.MapFrom(src => src.Address2AddressPostalCode))
                .ForMember(dst => dst.Address2AddressCountry, opt => opt.MapFrom(src => src.Address2AddressCountry))
                .ForMember(dst => dst.Address2AddressCountryCode, opt => opt.MapFrom(src => src.Address2AddressCountryCode))
                .ForMember(dst => dst.Address2AddressPostOfficeBox, opt => opt.MapFrom(src => src.Address2AddressPostOfficeBox))
                .ForMember(dst => dst.Address3DisplayName, opt => opt.MapFrom(src => src.Address3DisplayName))
                .ForMember(dst => dst.Address3AddressStreet, opt => opt.MapFrom(src => src.Address3AddressStreet))
                .ForMember(dst => dst.Address3AddressCity, opt => opt.MapFrom(src => src.Address3AddressCity))
                .ForMember(dst => dst.Address3AddressStateOrProvince, opt => opt.MapFrom(src => src.Address3AddressStateOrProvince))
                .ForMember(dst => dst.Address3AddressPostalCode, opt => opt.MapFrom(src => src.Address3AddressPostalCode))
                .ForMember(dst => dst.Address3AddressCountry, opt => opt.MapFrom(src => src.Address3AddressCountry))
                .ForMember(dst => dst.Address3AddressCountryCode, opt => opt.MapFrom(src => src.Address3AddressCountryCode))
                .ForMember(dst => dst.Address3AddressPostOfficeBox, opt => opt.MapFrom(src => src.Address3AddressPostOfficeBox))
                .ForMember(dst => dst.Telephone1DisplayName, opt => opt.MapFrom(src => src.Telephone1DisplayName))
                .ForMember(dst => dst.Telephone1TelephoneNumber, opt => opt.MapFrom(src => src.Telephone1TelephoneNumber))
                .ForMember(dst => dst.Telephone2DisplayName, opt => opt.MapFrom(src => src.Telephone2DisplayName))
                .ForMember(dst => dst.Telephone2TelephoneNumber, opt => opt.MapFrom(src => src.Telephone2TelephoneNumber))
                .ForMember(dst => dst.Telephone3DisplayName, opt => opt.MapFrom(src => src.Telephone3DisplayName))
                .ForMember(dst => dst.Telephone3TelephoneNumber, opt => opt.MapFrom(src => src.Telephone3TelephoneNumber))
                .ForMember(dst => dst.Telephone4DisplayName, opt => opt.MapFrom(src => src.Telephone4DisplayName))
                .ForMember(dst => dst.Telephone4TelephoneNumber, opt => opt.MapFrom(src => src.Telephone4TelephoneNumber))
                .ForMember(dst => dst.Telephone5DisplayName, opt => opt.MapFrom(src => src.Telephone5DisplayName))
                .ForMember(dst => dst.Telephone5TelephoneNumber, opt => opt.MapFrom(src => src.Telephone5TelephoneNumber))
                .ForMember(dst => dst.Telephone6DisplayName, opt => opt.MapFrom(src => src.Telephone6DisplayName))
                .ForMember(dst => dst.Telephone6TelephoneNumber, opt => opt.MapFrom(src => src.Telephone6TelephoneNumber))
                .ForMember(dst => dst.Telephone7DisplayName, opt => opt.MapFrom(src => src.Telephone7DisplayName))
                .ForMember(dst => dst.Telephone7TelephoneNumber, opt => opt.MapFrom(src => src.Telephone7TelephoneNumber))
                .ForMember(dst => dst.Telephone8DisplayName, opt => opt.MapFrom(src => src.Telephone8DisplayName))
                .ForMember(dst => dst.Telephone8TelephoneNumber, opt => opt.MapFrom(src => src.Telephone8TelephoneNumber))
                .ForMember(dst => dst.Telephone9DisplayName, opt => opt.MapFrom(src => src.Telephone9DisplayName))
                .ForMember(dst => dst.Telephone9TelephoneNumber, opt => opt.MapFrom(src => src.Telephone9TelephoneNumber))
                .ForMember(dst => dst.Telephone10DisplayName, opt => opt.MapFrom(src => src.Telephone10DisplayName))
                .ForMember(dst => dst.Telephone10TelephoneNumber, opt => opt.MapFrom(src => src.Telephone10TelephoneNumber))
                .ForMember(dst => dst.Birthday, opt => opt.ResolveUsing(db =>
                {
                    return db.Birthday.ToDbTime();
                }))
                .ForMember(dst => dst.Wedding, opt => opt.ResolveUsing(db =>
                {
                    return db.Wedding.ToDbTime();
                }))
                .ForMember(dst => dst.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dst => dst.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
                .ForMember(dst => dst.DepartmentName, opt => opt.MapFrom(src => src.DepartmentName))
                .ForMember(dst => dst.OfficeLocation, opt => opt.MapFrom(src => src.OfficeLocation))
                .ForMember(dst => dst.ManagerName, opt => opt.MapFrom(src => src.ManagerName))
                .ForMember(dst => dst.AssistantName, opt => opt.MapFrom(src => src.AssistantName))
                .ForMember(dst => dst.Profession, opt => opt.MapFrom(src => src.Profession))
                .ForMember(dst => dst.SpouseName, opt => opt.MapFrom(src => src.SpouseName))
                .ForMember(dst => dst.Language, opt => opt.MapFrom(src => src.Language))
                .ForMember(dst => dst.InstantMessagingAddress, opt => opt.MapFrom(src => src.InstantMessagingAddress))
                .ForMember(dst => dst.PersonalHomePage, opt => opt.MapFrom(src => src.PersonalHomePage))
                .ForMember(dst => dst.BusinessHomePage, opt => opt.MapFrom(src => src.BusinessHomePage))
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dst => dst.ReferredByName, opt => opt.MapFrom(src => src.ReferredByName));
        }
    }
}