﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EditUserProfileViewModel.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

using BetterCms.Module.MediaManager.ViewModels;

using BetterCms.Module.Root;
using BetterCms.Module.Root.Content.Resources;
using BetterCms.Module.Root.Mvc.Attributes;
using BetterCms.Module.Users.Content.Resources;
using BetterCms.Module.Users.Mvc.Attributes;

using BetterModules.Core.Models;

namespace BetterCms.Module.Users.ViewModels.User
{
    public class EditUserProfileViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditUserProfileViewModel" /> class.
        /// </summary>
        public EditUserProfileViewModel()
        {
            Image = new ImageSelectorViewModel();    
        }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [AllowHtml]
        [DisallowNonActiveDirectoryNameCompliant(ErrorMessageResourceType = typeof(RootGlobalization), ErrorMessageResourceName = "Validation_ActiveDirectoryCompliant_Message")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_UserName_RequiredMessage")]
        [StringLength(UsersModuleConstants.UserNameMaxLength, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_UserName_MaxLengthMessage")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [AllowHtml]
        [StringLength(MaxLength.Name, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_FirstName_MaxLengthMessage")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [AllowHtml]
        [StringLength(MaxLength.Name, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_LastName_MaxLengthMessage")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_Email_RequiredMessage")]
        [RegularExpression(RootModuleConstants.EmailRegularExpression, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_Email_ValidMessage")]
        [StringLength(MaxLength.Email, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_Email_MaxLengthMessage")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [StringLength(MaxLength.Password, ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_Password_MaxLengthMessage")]
        [PasswordValidation]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the retyped password.
        /// </summary>
        /// <value>
        /// The retyped password.
        /// </value>
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessageResourceType = typeof(UsersGlobalization), ErrorMessageResourceName = "User_Password_ShouldMatchMessage")]
        public string RetypedPassword { get; set; }

        /// <summary>
        /// Gets or sets the image view model.
        /// </summary>
        /// <value>
        /// The image view model.
        /// </value>
        public ImageSelectorViewModel Image { get; set; }

        /// <summary>
        /// Gets or sets the security hash.
        /// </summary>
        /// <value>
        /// The security hash.
        /// </value>
        public string SecurityHash { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Version: {0}, UserName: {1}, {2}", Version, UserName, base.ToString());
        }
    }
}