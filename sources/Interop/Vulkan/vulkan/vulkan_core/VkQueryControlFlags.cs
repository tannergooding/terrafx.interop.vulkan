// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkQueryControlFlags : uint
    {
        VK_QUERY_CONTROL_PRECISE_BIT = 0x00000001,
        VK_QUERY_CONTROL_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
