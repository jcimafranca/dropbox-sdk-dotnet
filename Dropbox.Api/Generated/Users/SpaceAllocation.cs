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
    /// <para>Space is allocated differently based on the type of account.</para>
    /// </summary>
    public class SpaceAllocation
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SpaceAllocation> Encoder = new SpaceAllocationEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SpaceAllocation> Decoder = new SpaceAllocationDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SpaceAllocation" />
        /// class.</para>
        /// </summary>
        public SpaceAllocation()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Individual</para>
        /// </summary>
        public bool IsIndividual
        {
            get
            {
                return this is Individual;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Individual, or <c>null</c>.</para>
        /// </summary>
        public Individual AsIndividual
        {
            get
            {
                return this as Individual;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Team</para>
        /// </summary>
        public bool IsTeam
        {
            get
            {
                return this is Team;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Team, or <c>null</c>.</para>
        /// </summary>
        public Team AsTeam
        {
            get
            {
                return this as Team;
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
        /// <para>Encoder for  <see cref="SpaceAllocation" />.</para>
        /// </summary>
        private class SpaceAllocationEncoder : enc.StructEncoder<SpaceAllocation>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SpaceAllocation value, enc.IJsonWriter writer)
            {
                if (value is Individual)
                {
                    WriteProperty(".tag", "individual", writer, enc.StringEncoder.Instance);
                    Individual.Encoder.EncodeFields((Individual)value, writer);
                    return;
                }
                if (value is Team)
                {
                    WriteProperty(".tag", "team", writer, enc.StringEncoder.Instance);
                    Team.Encoder.EncodeFields((Team)value, writer);
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
        /// <para>Decoder for  <see cref="SpaceAllocation" />.</para>
        /// </summary>
        private class SpaceAllocationDecoder : enc.UnionDecoder<SpaceAllocation>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SpaceAllocation" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SpaceAllocation Create()
            {
                return new SpaceAllocation();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SpaceAllocation Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "individual":
                        return Individual.Decoder.DecodeFields(reader);
                    case "team":
                        return Team.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The user's space allocation applies only to their individual account.</para>
        /// </summary>
        public sealed class Individual : SpaceAllocation
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Individual> Encoder = new IndividualEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Individual> Decoder = new IndividualDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Individual" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Individual(IndividualSpaceAllocation value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Individual" /> class.</para>
            /// </summary>
            private Individual()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public IndividualSpaceAllocation Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Individual" />.</para>
            /// </summary>
            private class IndividualEncoder : enc.StructEncoder<Individual>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Individual value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Users.IndividualSpaceAllocation.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Individual" />.</para>
            /// </summary>
            private class IndividualDecoder : enc.StructDecoder<Individual>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Individual" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Individual Create()
                {
                    return new Individual();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Individual DecodeFields(enc.IJsonReader reader)
                {
                    return new Individual(global::Dropbox.Api.Users.IndividualSpaceAllocation.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The user shares space with other members of their team.</para>
        /// </summary>
        public sealed class Team : SpaceAllocation
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Team> Encoder = new TeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Team> Decoder = new TeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Team" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Team(TeamSpaceAllocation value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Team" /> class.</para>
            /// </summary>
            private Team()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public TeamSpaceAllocation Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamEncoder : enc.StructEncoder<Team>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Team value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Users.TeamSpaceAllocation.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamDecoder : enc.StructDecoder<Team>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Team" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Team Create()
                {
                    return new Team();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Team DecodeFields(enc.IJsonReader reader)
                {
                    return new Team(global::Dropbox.Api.Users.TeamSpaceAllocation.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SpaceAllocation
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
