// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPerformanceValueTypeINTEL
    {
        VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = 0,
        VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = 1,
        VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = 2,
        VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = 3,
        VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = 4,
        VK_PERFORMANCE_VALUE_TYPE_BEGIN_RANGE_INTEL = VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL,
        VK_PERFORMANCE_VALUE_TYPE_END_RANGE_INTEL = VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL,
        VK_PERFORMANCE_VALUE_TYPE_RANGE_SIZE_INTEL = (VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL - VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL + 1),
        VK_PERFORMANCE_VALUE_TYPE_MAX_ENUM_INTEL = 0x7FFFFFFF,
    }
}