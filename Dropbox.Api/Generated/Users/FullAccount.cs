// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Detailed information about the current user's account.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Users.Account" />
    public class FullAccount : Account
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FullAccount> Encoder = new FullAccountEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FullAccount> Decoder = new FullAccountDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FullAccount" /> class.</para>
        /// </summary>
        /// <param name="accountId">The user's unique Dropbox ID.</param>
        /// <param name="name">Details of a user's name.</param>
        /// <param name="email">The user's e-mail address. Do not rely on this without checking
        /// the <paramref name="emailVerified" /> field. Even then, it's possible that the user
        /// has since lost access to their e-mail.</param>
        /// <param name="emailVerified">Whether the user has verified their e-mail
        /// address.</param>
        /// <param name="disabled">Whether the user has been disabled.</param>
        /// <param name="locale">The language that the user specified. Locale tags will be <a
        /// href="http://en.wikipedia.org/wiki/IETF_language_tag">IETF language
        /// tags</a>.</param>
        /// <param name="referralLink">The user's <a
        /// href="https://www.dropbox.com/referrals">referral link</a>.</param>
        /// <param name="isPaired">Whether the user has a personal and work account. If the
        /// current account is personal, then <paramref name="team" /> will always be
        /// <c>null</c>, but <paramref name="isPaired" /> will indicate if a work account is
        /// linked.</param>
        /// <param name="accountType">What type of account this user has.</param>
        /// <param name="profilePhotoUrl">URL for the photo representing the user, if one is
        /// set.</param>
        /// <param name="country">The user's two-letter country code, if available. Country
        /// codes are based on <a href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO
        /// 3166-1</a>.</param>
        /// <param name="team">If this account is a member of a team, information about that
        /// team.</param>
        /// <param name="teamMemberId">This account's unique team member id. This field will
        /// only be present if <paramref name="team" /> is present.</param>
        public FullAccount(string accountId,
                           Name name,
                           string email,
                           bool emailVerified,
                           bool disabled,
                           string locale,
                           string referralLink,
                           bool isPaired,
                           AccountType accountType,
                           string profilePhotoUrl = null,
                           string country = null,
                           FullTeam team = null,
                           string teamMemberId = null)
            : base(accountId, name, email, emailVerified, disabled, profilePhotoUrl)
        {
            if (locale == null)
            {
                throw new sys.ArgumentNullException("locale");
            }
            if (locale.Length < 2)
            {
                throw new sys.ArgumentOutOfRangeException("locale", "Length should be at least 2");
            }

            if (referralLink == null)
            {
                throw new sys.ArgumentNullException("referralLink");
            }

            if (accountType == null)
            {
                throw new sys.ArgumentNullException("accountType");
            }

            if (country != null)
            {
                if (country.Length < 2)
                {
                    throw new sys.ArgumentOutOfRangeException("country", "Length should be at least 2");
                }
                if (country.Length > 2)
                {
                    throw new sys.ArgumentOutOfRangeException("country", "Length should be at most 2");
                }
            }

            this.Locale = locale;
            this.ReferralLink = referralLink;
            this.IsPaired = isPaired;
            this.AccountType = accountType;
            this.Country = country;
            this.Team = team;
            this.TeamMemberId = teamMemberId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FullAccount" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FullAccount()
        {
        }

        /// <summary>
        /// <para>The language that the user specified. Locale tags will be <a
        /// href="http://en.wikipedia.org/wiki/IETF_language_tag">IETF language
        /// tags</a>.</para>
        /// </summary>
        public string Locale { get; protected set; }

        /// <summary>
        /// <para>The user's <a href="https://www.dropbox.com/referrals">referral
        /// link</a>.</para>
        /// </summary>
        public string ReferralLink { get; protected set; }

        /// <summary>
        /// <para>Whether the user has a personal and work account. If the current account is
        /// personal, then <see cref="Team" /> will always be <c>null</c>, but <see
        /// cref="IsPaired" /> will indicate if a work account is linked.</para>
        /// </summary>
        public bool IsPaired { get; protected set; }

        /// <summary>
        /// <para>What type of account this user has.</para>
        /// </summary>
        public AccountType AccountType { get; protected set; }

        /// <summary>
        /// <para>The user's two-letter country code, if available. Country codes are based on
        /// <a href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO 3166-1</a>.</para>
        /// </summary>
        public string Country { get; protected set; }

        /// <summary>
        /// <para>If this account is a member of a team, information about that team.</para>
        /// </summary>
        public FullTeam Team { get; protected set; }

        /// <summary>
        /// <para>This account's unique team member id. This field will only be present if <see
        /// cref="Team" /> is present.</para>
        /// </summary>
        public string TeamMemberId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FullAccount" />.</para>
        /// </summary>
        private class FullAccountEncoder : enc.StructEncoder<FullAccount>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FullAccount value, enc.IJsonWriter writer)
            {
                WriteProperty("account_id", value.AccountId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, global::Dropbox.Api.Users.Name.Encoder);
                WriteProperty("email", value.Email, writer, enc.StringEncoder.Instance);
                WriteProperty("email_verified", value.EmailVerified, writer, enc.BooleanEncoder.Instance);
                WriteProperty("disabled", value.Disabled, writer, enc.BooleanEncoder.Instance);
                WriteProperty("locale", value.Locale, writer, enc.StringEncoder.Instance);
                WriteProperty("referral_link", value.ReferralLink, writer, enc.StringEncoder.Instance);
                WriteProperty("is_paired", value.IsPaired, writer, enc.BooleanEncoder.Instance);
                WriteProperty("account_type", value.AccountType, writer, global::Dropbox.Api.Users.AccountType.Encoder);
                if (value.ProfilePhotoUrl != null)
                {
                    WriteProperty("profile_photo_url", value.ProfilePhotoUrl, writer, enc.StringEncoder.Instance);
                }
                if (value.Country != null)
                {
                    WriteProperty("country", value.Country, writer, enc.StringEncoder.Instance);
                }
                if (value.Team != null)
                {
                    WriteProperty("team", value.Team, writer, global::Dropbox.Api.Users.FullTeam.Encoder);
                }
                if (value.TeamMemberId != null)
                {
                    WriteProperty("team_member_id", value.TeamMemberId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FullAccount" />.</para>
        /// </summary>
        private class FullAccountDecoder : enc.StructDecoder<FullAccount>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FullAccount" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FullAccount Create()
            {
                return new FullAccount();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FullAccount value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "account_id":
                        value.AccountId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = global::Dropbox.Api.Users.Name.Decoder.Decode(reader);
                        break;
                    case "email":
                        value.Email = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "email_verified":
                        value.EmailVerified = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "disabled":
                        value.Disabled = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "locale":
                        value.Locale = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "referral_link":
                        value.ReferralLink = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_paired":
                        value.IsPaired = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "account_type":
                        value.AccountType = global::Dropbox.Api.Users.AccountType.Decoder.Decode(reader);
                        break;
                    case "profile_photo_url":
                        value.ProfilePhotoUrl = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "country":
                        value.Country = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "team":
                        value.Team = global::Dropbox.Api.Users.FullTeam.Decoder.Decode(reader);
                        break;
                    case "team_member_id":
                        value.TeamMemberId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
