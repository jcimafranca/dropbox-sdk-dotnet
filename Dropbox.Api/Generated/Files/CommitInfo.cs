// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The commit info object</para>
    /// </summary>
    /// <seealso cref="CommitInfoWithProperties" />
    /// <seealso cref="UploadSessionFinishArg" />
    public class CommitInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CommitInfo> Encoder = new CommitInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CommitInfo> Decoder = new CommitInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CommitInfo" /> class.</para>
        /// </summary>
        /// <param name="path">Path in the user's Dropbox to save the file.</param>
        /// <param name="mode">Selects what to do if the file already exists.</param>
        /// <param name="autorename">If there's a conflict, as determined by <paramref
        /// name="mode" />, have the Dropbox server try to autorename the file to avoid
        /// conflict.</param>
        /// <param name="clientModified">The value to store as the <paramref
        /// name="clientModified" /> timestamp. Dropbox automatically records the time at which
        /// the file was written to the Dropbox servers. It can also record an additional
        /// timestamp, provided by Dropbox desktop clients, mobile clients, and API apps of
        /// when the file was actually created or modified.</param>
        /// <param name="mute">Normally, users are made aware of any file modifications in
        /// their Dropbox account via notifications in the client software. If <c>true</c>,
        /// this tells the clients that this modification shouldn't result in a user
        /// notification.</param>
        public CommitInfo(string path,
                          WriteMode mode = null,
                          bool autorename = false,
                          sys.DateTime? clientModified = null,
                          bool mute = false)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/(.|[\r\n])*)|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/(.|[\r\n])*)|(ns:[0-9]+(/.*)?))\z'");
            }

            if (mode == null)
            {
                mode = global::Dropbox.Api.Files.WriteMode.Add.Instance;
            }
            this.Path = path;
            this.Mode = mode;
            this.Autorename = autorename;
            this.ClientModified = clientModified;
            this.Mute = mute;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CommitInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CommitInfo()
        {
            this.Mode = global::Dropbox.Api.Files.WriteMode.Add.Instance;
            this.Autorename = false;
            this.Mute = false;
        }

        /// <summary>
        /// <para>Path in the user's Dropbox to save the file.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>Selects what to do if the file already exists.</para>
        /// </summary>
        public WriteMode Mode { get; protected set; }

        /// <summary>
        /// <para>If there's a conflict, as determined by <see cref="Mode" />, have the Dropbox
        /// server try to autorename the file to avoid conflict.</para>
        /// </summary>
        public bool Autorename { get; protected set; }

        /// <summary>
        /// <para>The value to store as the <see cref="ClientModified" /> timestamp. Dropbox
        /// automatically records the time at which the file was written to the Dropbox
        /// servers. It can also record an additional timestamp, provided by Dropbox desktop
        /// clients, mobile clients, and API apps of when the file was actually created or
        /// modified.</para>
        /// </summary>
        public sys.DateTime? ClientModified { get; protected set; }

        /// <summary>
        /// <para>Normally, users are made aware of any file modifications in their Dropbox
        /// account via notifications in the client software. If <c>true</c>, this tells the
        /// clients that this modification shouldn't result in a user notification.</para>
        /// </summary>
        public bool Mute { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CommitInfo" />.</para>
        /// </summary>
        private class CommitInfoEncoder : enc.StructEncoder<CommitInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CommitInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteProperty("mode", value.Mode, writer, global::Dropbox.Api.Files.WriteMode.Encoder);
                WriteProperty("autorename", value.Autorename, writer, enc.BooleanEncoder.Instance);
                if (value.ClientModified != null)
                {
                    WriteProperty("client_modified", value.ClientModified.Value, writer, enc.DateTimeEncoder.Instance);
                }
                WriteProperty("mute", value.Mute, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CommitInfo" />.</para>
        /// </summary>
        private class CommitInfoDecoder : enc.StructDecoder<CommitInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CommitInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CommitInfo Create()
            {
                return new CommitInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CommitInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "mode":
                        value.Mode = global::Dropbox.Api.Files.WriteMode.Decoder.Decode(reader);
                        break;
                    case "autorename":
                        value.Autorename = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "client_modified":
                        value.ClientModified = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "mute":
                        value.Mute = enc.BooleanDecoder.Instance.Decode(reader);
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
