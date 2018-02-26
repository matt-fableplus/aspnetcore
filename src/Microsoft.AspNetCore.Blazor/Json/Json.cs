﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Blazor
{
    /// <summary>
    /// Provides mechanisms for converting between .NET objects and JSON strings.
    /// </summary>
    public static class Json
    {
        /// <summary>
        /// Serializes the value as a JSON string.
        /// </summary>
        /// <param name="value">The value to serialize.</param>
        /// <returns>The JSON string.</returns>
        public static string Serialize(object value)
            => SimpleJson.SimpleJson.SerializeObject(value);

        /// <summary>
        /// Deserializes the JSON string, creating an object of the specified generic type.
        /// </summary>
        /// <typeparam name="T">The type of object to create.</typeparam>
        /// <param name="json">The JSON string.</param>
        /// <returns>An object of the specified type.</returns>
        public static T Deserialize<T>(string json)
            => SimpleJson.SimpleJson.DeserializeObject<T>(json);
    }
}
