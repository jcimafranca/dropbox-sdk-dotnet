// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.AddFileMemberAsync" />.</para>
    /// </summary>
    public class AddFileMemberArgs
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddFileMemberArgs> Encoder = new AddFileMemberArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddFileMemberArgs> Decoder = new AddFileMemberArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddFileMemberArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="file">File to which to add members.</param>
        /// <param name="members">Members to add. Note that even an email address is given,
        /// this may result in a user being directy added to the membership if that email is
        /// the user's main account email.</param>
        /// <param name="customMessage">Message to send to added members in their
        /// invitation.</param>
        /// <param name="quiet">Whether added members should be notified via device
        /// notifications of their invitation.</param>
        /// <param name="accessLevel">AccessLevel union object, describing what access level we
        /// want to give new members.</param>
        /// <param name="addMessageAsComment">If the custom message should be added as a
        /// comment on the file.</param>
        public AddFileMemberArgs(string file,
                                 col.IEnumerable<MemberSelector> members,
                                 string customMessage = null,
                                 bool quiet = false,
                                 AccessLevel accessLevel = null,
                                 bool addMessageAsComment = false)
        {
            if (file == null)
            {
                throw new sys.ArgumentNullException("file");
            }
            if (file.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("file", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(file, @"\A(?:((/|id:).*|nspath:[0-9]+:.*)|ns:[0-9]+(/.*)?)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("file", @"Value should match pattern '\A(?:((/|id:).*|nspath:[0-9]+:.*)|ns:[0-9]+(/.*)?)\z'");
            }

            var membersList = enc.Util.ToList(members);

            if (members == null)
            {
                throw new sys.ArgumentNullException("members");
            }

            if (accessLevel == null)
            {
                accessLevel = global::Dropbox.Api.Sharing.AccessLevel.Viewer.Instance;
            }
            this.File = file;
            this.Members = membersList;
            this.CustomMessage = customMessage;
            this.Quiet = quiet;
            this.AccessLevel = accessLevel;
            this.AddMessageAsComment = addMessageAsComment;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddFileMemberArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AddFileMemberArgs()
        {
            this.Quiet = false;
            this.AccessLevel = global::Dropbox.Api.Sharing.AccessLevel.Viewer.Instance;
            this.AddMessageAsComment = false;
        }

        /// <summary>
        /// <para>File to which to add members.</para>
        /// </summary>
        public string File { get; protected set; }

        /// <summary>
        /// <para>Members to add. Note that even an email address is given, this may result in
        /// a user being directy added to the membership if that email is the user's main
        /// account email.</para>
        /// </summary>
        public col.IList<MemberSelector> Members { get; protected set; }

        /// <summary>
        /// <para>Message to send to added members in their invitation.</para>
        /// </summary>
        public string CustomMessage { get; protected set; }

        /// <summary>
        /// <para>Whether added members should be notified via device notifications of their
        /// invitation.</para>
        /// </summary>
        public bool Quiet { get; protected set; }

        /// <summary>
        /// <para>AccessLevel union object, describing what access level we want to give new
        /// members.</para>
        /// </summary>
        public AccessLevel AccessLevel { get; protected set; }

        /// <summary>
        /// <para>If the custom message should be added as a comment on the file.</para>
        /// </summary>
        public bool AddMessageAsComment { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AddFileMemberArgs" />.</para>
        /// </summary>
        private class AddFileMemberArgsEncoder : enc.StructEncoder<AddFileMemberArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddFileMemberArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
                WriteListProperty("members", value.Members, writer, global::Dropbox.Api.Sharing.MemberSelector.Encoder);
                if (value.CustomMessage != null)
                {
                    WriteProperty("custom_message", value.CustomMessage, writer, enc.StringEncoder.Instance);
                }
                WriteProperty("quiet", value.Quiet, writer, enc.BooleanEncoder.Instance);
                WriteProperty("access_level", value.AccessLevel, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("add_message_as_comment", value.AddMessageAsComment, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AddFileMemberArgs" />.</para>
        /// </summary>
        private class AddFileMemberArgsDecoder : enc.StructDecoder<AddFileMemberArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddFileMemberArgs" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddFileMemberArgs Create()
            {
                return new AddFileMemberArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AddFileMemberArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "members":
                        value.Members = ReadList<MemberSelector>(reader, global::Dropbox.Api.Sharing.MemberSelector.Decoder);
                        break;
                    case "custom_message":
                        value.CustomMessage = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "quiet":
                        value.Quiet = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "access_level":
                        value.AccessLevel = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "add_message_as_comment":
                        value.AddMessageAsComment = enc.BooleanDecoder.Instance.Decode(reader);
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
