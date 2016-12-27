﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.Core.Logging;
using AutoRest.Core.Properties;
using AutoRest.Core.Validation;
using System.Collections.Generic;
using AutoRest.Swagger.Model;

namespace AutoRest.Swagger.Validation
{
    public class ResourceModelValidation: TypedRule<Dictionary<string, Schema>>
    {
        /// <summary>
        /// The template message for this Rule. 
        /// </summary>
        /// <remarks>
        /// This may contain placeholders '{0}' for parameterized messages.
        /// </remarks>
        public override string MessageTemplate => Resources.ResourceModelIsNotValid;

        /// <summary>
        /// The severity of this message (ie, debug/info/warning/error/fatal, etc)
        /// </summary>
        public override Category Severity => Category.Warning;

        /// <summary>
        /// An <paramref name="definitions"/> fails this rule if it does not have all valid properties.
        /// </summary>
        /// <param name="definitions">Operation Definition to validate</param>
        /// <returns></returns>
        public override bool IsValid(Dictionary<string, Schema> definitions, RuleContext context)
        {
            foreach(string key in definitions.Keys)
            {
                if (key.ToLower().Equals("resource"))
                {
                    Schema resourceSchema = definitions.GetValueOrNull(key);
                    if (resourceSchema == null || resourceSchema.Properties.Count == 0)
                        return false;

                    if (!this.validateSchemaProperty(resourceSchema, "id", true)   ||
                        !this.validateSchemaProperty(resourceSchema, "name", true) ||
                        !this.validateSchemaProperty(resourceSchema, "type", true) ||
                        !this.validateSchemaProperty(resourceSchema, "location", false) ||
                        !this.validateSchemaProperty(resourceSchema, "tags", false))
                        return false;
                }
            }
            return true;
        }

        private bool validateSchemaProperty(Schema resourceSchema, string propertyName, bool checkForReadOnly)
        {
            Schema resultSchema = resourceSchema.Properties.GetValueOrNull(propertyName);
            if (resultSchema == null || (checkForReadOnly && !resultSchema.ReadOnly))
                return false;
            return true;
        }
    }
}
