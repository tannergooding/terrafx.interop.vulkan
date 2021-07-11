// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkImageCreateFlags : uint
    {
        VK_IMAGE_CREATE_SPARSE_BINDING_BIT = 0x00000001,
        VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = 0x00000002,
        VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = 0x00000004,
        VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = 0x00000008,
        VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = 0x00000010,
        VK_IMAGE_CREATE_ALIAS_BIT = 0x00000400,
        VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT = 0x00000040,
        VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT = 0x00000020,
        VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT = 0x00000080,
        VK_IMAGE_CREATE_EXTENDED_USAGE_BIT = 0x00000100,
        VK_IMAGE_CREATE_PROTECTED_BIT = 0x00000800,
        VK_IMAGE_CREATE_DISJOINT_BIT = 0x00000200,
        VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV = 0x00002000,
        VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x00001000,
        VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT = 0x00004000,
        VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT,
        VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT,
        VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT,
        VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR = VK_IMAGE_CREATE_EXTENDED_USAGE_BIT,
        VK_IMAGE_CREATE_DISJOINT_BIT_KHR = VK_IMAGE_CREATE_DISJOINT_BIT,
        VK_IMAGE_CREATE_ALIAS_BIT_KHR = VK_IMAGE_CREATE_ALIAS_BIT,
        VK_IMAGE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}