// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkValidationCacheEXT : IEquatable<VkValidationCacheEXT>
    {
        private ulong _value;

        public VkValidationCacheEXT(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkValidationCacheEXT l, VkValidationCacheEXT r) => l._value == r._value;

        public static bool operator !=(VkValidationCacheEXT l, VkValidationCacheEXT r) => !(l == r);

        public static implicit operator VkValidationCacheEXT(ulong value) => new VkValidationCacheEXT(value);

        public static implicit operator ulong(VkValidationCacheEXT value) => value._value;

        public override bool Equals(object? obj) => (obj is VkValidationCacheEXT other) && Equals(other);

        public bool Equals(VkValidationCacheEXT other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
