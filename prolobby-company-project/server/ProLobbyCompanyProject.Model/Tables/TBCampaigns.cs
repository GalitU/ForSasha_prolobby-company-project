﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Tables\TBCampaigns.cs
//
// summary:	Implements the terabytes campaigns class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLobbyCompanyProject.Model
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   The terabytes campaigns. </summary>
    ///
    /// <remarks>   Sasha Pavlovski, 1/12/2023. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class TBCampaigns
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the campaigns. </summary>
        ///
        /// <value> The identifier of the campaigns. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [Key]
        public int Campaigns_Id { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the non profit organization. </summary>
        ///
        /// <value> The identifier of the non profit organization. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int NonProfitOrganization_Id { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name of the campaigns. </summary>
        ///
        /// <value> The name of the campaigns. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Campaigns_Name { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the hashtag. </summary>
        ///
        /// <value> The hashtag. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Hashtag { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the descreption. </summary>
        ///
        /// <value> The descreption. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Descreption { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the date. </summary>
        ///
        /// <value> The date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime Date { get { return DateTime.Now; } set { } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a value indicating whether the active. </summary>
        ///
        /// <value> True if active, false if not. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Active { get { return true; } set {  } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the user. </summary>
        ///
        /// <value> The identifier of the user. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string User_Id { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the money donations. </summary>
        ///
        /// <value> The money donations. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public double MoneyDonations { get { return 0; } set { } }


    }
}

