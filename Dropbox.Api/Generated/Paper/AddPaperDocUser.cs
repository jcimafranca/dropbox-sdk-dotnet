// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The add paper doc user object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Paper.RefPaperDoc" />
    public class AddPaperDocUser : RefPaperDoc
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddPaperDocUser> Encoder = new AddPaperDocUserEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddPaperDocUser> Decoder = new AddPaperDocUserDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddPaperDocUser" />
        /// class.</para>
        /// </summary>
        /// <param name="docId">The doc id</param>
        /// <param name="members">User which should be added to the Paper doc. Specify only
        /// email or Dropbox account id.</param>
        /// <param name="customMessage">A personal message that will be emailed to each
        /// successfully added member.</param>
        /// <param name="quiet">Clients should set this to true if no email shall be sent to
        /// added users.</param>
        public AddPaperDocUser(string docId,
                               col.IEnumerable<AddMember> members,
                               string customMessage = null,
                               bool quiet = false)
            : base(docId)
        {
            var membersList = enc.Util.ToList(members);

            if (members == null)
            {
                throw new sys.ArgumentNullException("members");
            }
            if (membersList.Count > 20)
            {
                throw new sys.ArgumentOutOfRangeException("members", "List should at at most 20 items");
            }

            this.Members = membersList;
            this.CustomMessage = customMessage;
            this.Quiet = quiet;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddPaperDocUser" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AddPaperDocUser()
        {
            this.Quiet = false;
        }

        /// <summary>
        /// <para>User which should be added to the Paper doc. Specify only email or Dropbox
        /// account id.</para>
        /// </summary>
        public col.IList<AddMember> Members { get; protected set; }

        /// <summary>
        /// <para>A personal message that will be emailed to each successfully added
        /// member.</para>
        /// </summary>
        public string CustomMessage { get; protected set; }

        /// <summary>
        /// <para>Clients should set this to true if no email shall be sent to added
        /// users.</para>
        /// </summary>
        public bool Quiet { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AddPaperDocUser" />.</para>
        /// </summary>
        private class AddPaperDocUserEncoder : enc.StructEncoder<AddPaperDocUser>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddPaperDocUser value, enc.IJsonWriter writer)
            {
                WriteProperty("doc_id", value.DocId, writer, enc.StringEncoder.Instance);
                WriteListProperty("members", value.Members, writer, global::Dropbox.Api.Paper.AddMember.Encoder);
                if (value.CustomMessage != null)
                {
                    WriteProperty("custom_message", value.CustomMessage, writer, enc.StringEncoder.Instance);
                }
                WriteProperty("quiet", value.Quiet, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AddPaperDocUser" />.</para>
        /// </summary>
        private class AddPaperDocUserDecoder : enc.StructDecoder<AddPaperDocUser>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddPaperDocUser" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddPaperDocUser Create()
            {
                return new AddPaperDocUser();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AddPaperDocUser value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "doc_id":
                        value.DocId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "members":
                        value.Members = ReadList<AddMember>(reader, global::Dropbox.Api.Paper.AddMember.Decoder);
                        break;
                    case "custom_message":
                        value.CustomMessage = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "quiet":
                        value.Quiet = enc.BooleanDecoder.Instance.Decode(reader);
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
