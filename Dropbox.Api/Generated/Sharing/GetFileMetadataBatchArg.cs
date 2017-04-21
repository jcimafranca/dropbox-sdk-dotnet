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
    /// <para>Arguments of <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.GetFileMetadataBatchAsync"
    /// />.</para>
    /// </summary>
    public class GetFileMetadataBatchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetFileMetadataBatchArg> Encoder = new GetFileMetadataBatchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetFileMetadataBatchArg> Decoder = new GetFileMetadataBatchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetFileMetadataBatchArg" />
        /// class.</para>
        /// </summary>
        /// <param name="files">The files to query.</param>
        /// <param name="actions">File actions to query.</param>
        public GetFileMetadataBatchArg(col.IEnumerable<string> files,
                                       col.IEnumerable<FileAction> actions = null)
        {
            var filesList = enc.Util.ToList(files);

            if (files == null)
            {
                throw new sys.ArgumentNullException("files");
            }
            if (filesList.Count > 100)
            {
                throw new sys.ArgumentOutOfRangeException("files", "List should at at most 100 items");
            }

            var actionsList = enc.Util.ToList(actions);

            this.Files = filesList;
            this.Actions = actionsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetFileMetadataBatchArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetFileMetadataBatchArg()
        {
        }

        /// <summary>
        /// <para>The files to query.</para>
        /// </summary>
        public col.IList<string> Files { get; protected set; }

        /// <summary>
        /// <para>File actions to query.</para>
        /// </summary>
        public col.IList<FileAction> Actions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetFileMetadataBatchArg" />.</para>
        /// </summary>
        private class GetFileMetadataBatchArgEncoder : enc.StructEncoder<GetFileMetadataBatchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetFileMetadataBatchArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("files", value.Files, writer, enc.StringEncoder.Instance);
                if (value.Actions.Count > 0)
                {
                    WriteListProperty("actions", value.Actions, writer, global::Dropbox.Api.Sharing.FileAction.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetFileMetadataBatchArg" />.</para>
        /// </summary>
        private class GetFileMetadataBatchArgDecoder : enc.StructDecoder<GetFileMetadataBatchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetFileMetadataBatchArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetFileMetadataBatchArg Create()
            {
                return new GetFileMetadataBatchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetFileMetadataBatchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "files":
                        value.Files = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "actions":
                        value.Actions = ReadList<FileAction>(reader, global::Dropbox.Api.Sharing.FileAction.Decoder);
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
