// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_ios.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        public const uint VK_MVK_ios_surface = 1;

        public const uint VK_MVK_IOS_SURFACE_SPEC_VERSION = 2;

        // VK_MVK_ios_surface
        public static ReadOnlySpan<sbyte> VK_MVK_IOS_SURFACE_EXTENSION_NAME => new sbyte[] { 0x56, 0x4B, 0x5F, 0x4D, 0x56, 0x4B, 0x5F, 0x69, 0x6F, 0x73, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
    }
}
