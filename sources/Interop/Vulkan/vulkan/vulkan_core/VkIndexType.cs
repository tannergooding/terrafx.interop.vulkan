// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkIndexType
    {
        VK_INDEX_TYPE_UINT16 = 0,
        VK_INDEX_TYPE_UINT32 = 1,
        VK_INDEX_TYPE_NONE_KHR = 1000165000,
        VK_INDEX_TYPE_UINT8_EXT = 1000265000,
        VK_INDEX_TYPE_NONE_NV = VK_INDEX_TYPE_NONE_KHR,
        VK_INDEX_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
