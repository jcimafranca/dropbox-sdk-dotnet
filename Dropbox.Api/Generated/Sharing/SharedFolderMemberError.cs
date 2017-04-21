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
    /// <para>The shared folder member error object</para>
    /// </summary>
    public class SharedFolderMemberError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMemberError> Encoder = new SharedFolderMemberErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMemberError> Decoder = new SharedFolderMemberErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMemberError" />
        /// class.</para>
        /// </summary>
        public SharedFolderMemberError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidDropboxId</para>
        /// </summary>
        public bool IsInvalidDropboxId
        {
            get
            {
                return this is InvalidDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidDropboxId, or <c>null</c>.</para>
        /// </summary>
        public InvalidDropboxId AsInvalidDropboxId
        {
            get
            {
                return this as InvalidDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotAMember</para>
        /// </summary>
        public bool IsNotAMember
        {
            get
            {
                return this is NotAMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotAMember, or <c>null</c>.</para>
        /// </summary>
        public NotAMember AsNotAMember
        {
            get
            {
                return this as NotAMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoExplicitAccess</para>
        /// </summary>
        public bool IsNoExplicitAccess
        {
            get
            {
                return this is NoExplicitAccess;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoExplicitAccess, or <c>null</c>.</para>
        /// </summary>
        public NoExplicitAccess AsNoExplicitAccess
        {
            get
            {
                return this as NoExplicitAccess;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderMemberError" />.</para>
        /// </summary>
        private class SharedFolderMemberErrorEncoder : enc.StructEncoder<SharedFolderMemberError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMemberError value, enc.IJsonWriter writer)
            {
                if (value is InvalidDropboxId)
                {
                    WriteProperty(".tag", "invalid_dropbox_id", writer, enc.StringEncoder.Instance);
                    InvalidDropboxId.Encoder.EncodeFields((InvalidDropboxId)value, writer);
                    return;
                }
                if (value is NotAMember)
                {
                    WriteProperty(".tag", "not_a_member", writer, enc.StringEncoder.Instance);
                    NotAMember.Encoder.EncodeFields((NotAMember)value, writer);
                    return;
                }
                if (value is NoExplicitAccess)
                {
                    WriteProperty(".tag", "no_explicit_access", writer, enc.StringEncoder.Instance);
                    NoExplicitAccess.Encoder.EncodeFields((NoExplicitAccess)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderMemberError" />.</para>
        /// </summary>
        private class SharedFolderMemberErrorDecoder : enc.UnionDecoder<SharedFolderMemberError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMemberError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMemberError Create()
            {
                return new SharedFolderMemberError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharedFolderMemberError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_dropbox_id":
                        return InvalidDropboxId.Decoder.DecodeFields(reader);
                    case "not_a_member":
                        return NotAMember.Decoder.DecodeFields(reader);
                    case "no_explicit_access":
                        return NoExplicitAccess.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The target dropbox_id is invalid.</para>
        /// </summary>
        public sealed class InvalidDropboxId : SharedFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidDropboxId> Encoder = new InvalidDropboxIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidDropboxId> Decoder = new InvalidDropboxIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidDropboxId" />
            /// class.</para>
            /// </summary>
            private InvalidDropboxId()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidDropboxId</para>
            /// </summary>
            public static readonly InvalidDropboxId Instance = new InvalidDropboxId();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidDropboxId" />.</para>
            /// </summary>
            private class InvalidDropboxIdEncoder : enc.StructEncoder<InvalidDropboxId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidDropboxId value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidDropboxId" />.</para>
            /// </summary>
            private class InvalidDropboxIdDecoder : enc.StructDecoder<InvalidDropboxId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidDropboxId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidDropboxId Create()
                {
                    return new InvalidDropboxId();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InvalidDropboxId DecodeFields(enc.IJsonReader reader)
                {
                    return InvalidDropboxId.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The target dropbox_id is not a member of the shared folder.</para>
        /// </summary>
        public sealed class NotAMember : SharedFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotAMember> Encoder = new NotAMemberEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotAMember> Decoder = new NotAMemberDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotAMember" /> class.</para>
            /// </summary>
            private NotAMember()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotAMember</para>
            /// </summary>
            public static readonly NotAMember Instance = new NotAMember();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotAMember" />.</para>
            /// </summary>
            private class NotAMemberEncoder : enc.StructEncoder<NotAMember>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotAMember value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotAMember" />.</para>
            /// </summary>
            private class NotAMemberDecoder : enc.StructDecoder<NotAMember>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotAMember" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotAMember Create()
                {
                    return new NotAMember();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NotAMember DecodeFields(enc.IJsonReader reader)
                {
                    return NotAMember.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The target member only has inherited access to the shared folder.</para>
        /// </summary>
        public sealed class NoExplicitAccess : SharedFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoExplicitAccess> Encoder = new NoExplicitAccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoExplicitAccess> Decoder = new NoExplicitAccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoExplicitAccess" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public NoExplicitAccess(MemberAccessLevelResult value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoExplicitAccess" />
            /// class.</para>
            /// </summary>
            private NoExplicitAccess()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public MemberAccessLevelResult Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoExplicitAccess" />.</para>
            /// </summary>
            private class NoExplicitAccessEncoder : enc.StructEncoder<NoExplicitAccess>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoExplicitAccess value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.MemberAccessLevelResult.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoExplicitAccess" />.</para>
            /// </summary>
            private class NoExplicitAccessDecoder : enc.StructDecoder<NoExplicitAccess>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoExplicitAccess" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoExplicitAccess Create()
                {
                    return new NoExplicitAccess();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoExplicitAccess DecodeFields(enc.IJsonReader reader)
                {
                    return new NoExplicitAccess(global::Dropbox.Api.Sharing.MemberAccessLevelResult.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SharedFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
