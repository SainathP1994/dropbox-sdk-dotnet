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
    /// <para>Opened shared Paper doc.</para>
    /// </summary>
    public class SharedNoteOpenedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedNoteOpenedDetails> Encoder = new SharedNoteOpenedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedNoteOpenedDetails> Decoder = new SharedNoteOpenedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedNoteOpenedDetails" />
        /// class.</para>
        /// </summary>
        public SharedNoteOpenedDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedNoteOpenedDetails" />.</para>
        /// </summary>
        private class SharedNoteOpenedDetailsEncoder : enc.StructEncoder<SharedNoteOpenedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedNoteOpenedDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedNoteOpenedDetails" />.</para>
        /// </summary>
        private class SharedNoteOpenedDetailsDecoder : enc.StructDecoder<SharedNoteOpenedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedNoteOpenedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedNoteOpenedDetails Create()
            {
                return new SharedNoteOpenedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedNoteOpenedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
