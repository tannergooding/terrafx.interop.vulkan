// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkInternalAllocationType
    {
        VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE = 0,
        VK_INTERNAL_ALLOCATION_TYPE_BEGIN_RANGE = VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE,
        VK_INTERNAL_ALLOCATION_TYPE_END_RANGE = VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE,
        VK_INTERNAL_ALLOCATION_TYPE_RANGE_SIZE = (VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE - VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE + 1),
        VK_INTERNAL_ALLOCATION_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
