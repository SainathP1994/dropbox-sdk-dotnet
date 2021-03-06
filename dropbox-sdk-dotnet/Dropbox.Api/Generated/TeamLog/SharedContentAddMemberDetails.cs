// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Added users and/or groups to shared file/folder.</para>
    /// </summary>
    public class SharedContentAddMemberDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentAddMemberDetails> Encoder = new SharedContentAddMemberDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentAddMemberDetails> Decoder = new SharedContentAddMemberDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentAddMemberDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="sharedContentAccessLevel">Shared content access level.</param>
        public SharedContentAddMemberDetails(global::Dropbox.Api.Sharing.AccessLevel sharedContentAccessLevel)
        {
            if (sharedContentAccessLevel == null)
            {
                throw new sys.ArgumentNullException("sharedContentAccessLevel");
            }

            this.SharedContentAccessLevel = sharedContentAccessLevel;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentAddMemberDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentAddMemberDetails()
        {
        }

        /// <summary>
        /// <para>Shared content access level.</para>
        /// </summary>
        public global::Dropbox.Api.Sharing.AccessLevel SharedContentAccessLevel { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentAddMemberDetails" />.</para>
        /// </summary>
        private class SharedContentAddMemberDetailsEncoder : enc.StructEncoder<SharedContentAddMemberDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentAddMemberDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_content_access_level", value.SharedContentAccessLevel, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentAddMemberDetails" />.</para>
        /// </summary>
        private class SharedContentAddMemberDetailsDecoder : enc.StructDecoder<SharedContentAddMemberDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedContentAddMemberDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentAddMemberDetails Create()
            {
                return new SharedContentAddMemberDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentAddMemberDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_content_access_level":
                        value.SharedContentAccessLevel = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
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
