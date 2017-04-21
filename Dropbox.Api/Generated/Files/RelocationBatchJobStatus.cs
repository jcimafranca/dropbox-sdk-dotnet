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
    /// <para>The relocation batch job status object</para>
    /// </summary>
    public class RelocationBatchJobStatus
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelocationBatchJobStatus> Encoder = new RelocationBatchJobStatusEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelocationBatchJobStatus> Decoder = new RelocationBatchJobStatusDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationBatchJobStatus" />
        /// class.</para>
        /// </summary>
        public RelocationBatchJobStatus()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Complete</para>
        /// </summary>
        public bool IsComplete
        {
            get
            {
                return this is Complete;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Complete, or <c>null</c>.</para>
        /// </summary>
        public Complete AsComplete
        {
            get
            {
                return this as Complete;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Failed</para>
        /// </summary>
        public bool IsFailed
        {
            get
            {
                return this is Failed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Failed, or <c>null</c>.</para>
        /// </summary>
        public Failed AsFailed
        {
            get
            {
                return this as Failed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InProgress</para>
        /// </summary>
        public bool IsInProgress
        {
            get
            {
                return this is InProgress;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InProgress, or <c>null</c>.</para>
        /// </summary>
        public InProgress AsInProgress
        {
            get
            {
                return this as InProgress;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RelocationBatchJobStatus" />.</para>
        /// </summary>
        private class RelocationBatchJobStatusEncoder : enc.StructEncoder<RelocationBatchJobStatus>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelocationBatchJobStatus value, enc.IJsonWriter writer)
            {
                if (value is Complete)
                {
                    WriteProperty(".tag", "complete", writer, enc.StringEncoder.Instance);
                    Complete.Encoder.EncodeFields((Complete)value, writer);
                    return;
                }
                if (value is Failed)
                {
                    WriteProperty(".tag", "failed", writer, enc.StringEncoder.Instance);
                    Failed.Encoder.EncodeFields((Failed)value, writer);
                    return;
                }
                if (value is InProgress)
                {
                    WriteProperty(".tag", "in_progress", writer, enc.StringEncoder.Instance);
                    InProgress.Encoder.EncodeFields((InProgress)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RelocationBatchJobStatus" />.</para>
        /// </summary>
        private class RelocationBatchJobStatusDecoder : enc.UnionDecoder<RelocationBatchJobStatus>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelocationBatchJobStatus"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelocationBatchJobStatus Create()
            {
                return new RelocationBatchJobStatus();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RelocationBatchJobStatus Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "complete":
                        return Complete.Decoder.DecodeFields(reader);
                    case "failed":
                        return Failed.Decoder.DecodeFields(reader);
                    case "in_progress":
                        return InProgress.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The copy or move batch job has finished.</para>
        /// </summary>
        public sealed class Complete : RelocationBatchJobStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Complete> Encoder = new CompleteEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Complete> Decoder = new CompleteDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Complete(RelocationBatchResult value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            private Complete()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public RelocationBatchResult Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteEncoder : enc.StructEncoder<Complete>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Complete value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Files.RelocationBatchResult.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteDecoder : enc.StructDecoder<Complete>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Complete" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Complete Create()
                {
                    return new Complete();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Complete DecodeFields(enc.IJsonReader reader)
                {
                    return new Complete(global::Dropbox.Api.Files.RelocationBatchResult.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The copy or move batch job has failed with exception.</para>
        /// </summary>
        public sealed class Failed : RelocationBatchJobStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Failed> Encoder = new FailedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Failed> Decoder = new FailedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failed" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Failed(RelocationBatchError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Failed" /> class.</para>
            /// </summary>
            private Failed()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public RelocationBatchError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Failed" />.</para>
            /// </summary>
            private class FailedEncoder : enc.StructEncoder<Failed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Failed value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Files.RelocationBatchError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Failed" />.</para>
            /// </summary>
            private class FailedDecoder : enc.StructDecoder<Failed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Failed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Failed Create()
                {
                    return new Failed();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Failed value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "failed":
                            value.Value = global::Dropbox.Api.Files.RelocationBatchError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The asynchronous job is still in progress.</para>
        /// </summary>
        public sealed class InProgress : RelocationBatchJobStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InProgress> Encoder = new InProgressEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InProgress> Decoder = new InProgressDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InProgress" /> class.</para>
            /// </summary>
            private InProgress()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InProgress</para>
            /// </summary>
            public static readonly InProgress Instance = new InProgress();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InProgress" />.</para>
            /// </summary>
            private class InProgressEncoder : enc.StructEncoder<InProgress>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InProgress value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InProgress" />.</para>
            /// </summary>
            private class InProgressDecoder : enc.StructDecoder<InProgress>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InProgress" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InProgress Create()
                {
                    return new InProgress();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InProgress DecodeFields(enc.IJsonReader reader)
                {
                    return InProgress.Instance;
                }
            }

            #endregion
        }
    }
}
