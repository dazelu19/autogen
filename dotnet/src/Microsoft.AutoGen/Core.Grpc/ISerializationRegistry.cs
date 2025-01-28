// Copyright (c) Microsoft Corporation. All rights reserved.
// ISerializationRegistry.cs

namespace Microsoft.AutoGen.Core.Grpc;

public interface IProtoSerializationRegistry
{
    /// <summary>
    /// Registers a serializer for the specified type.
    /// </summary>
    /// <param name="type">The type to register.</param>
    void RegisterSerializer(System.Type type) => RegisterSerializer(type, new ProtobufMessageSerializer(type));

    void RegisterSerializer(System.Type type, IProtoMessageSerializer serializer);

    /// <summary>
    /// Gets the serializer for the specified type.
    /// </summary>
    /// <param name="type">The type to get the serializer for.</param>
    /// <returns>The serializer for the specified type.</returns>
    IProtoMessageSerializer? GetSerializer(System.Type type);

    bool Exists(System.Type type);
}
