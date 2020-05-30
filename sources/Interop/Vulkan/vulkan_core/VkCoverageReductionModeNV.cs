// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkCoverageReductionModeNV
    {
        VK_COVERAGE_REDUCTION_MODE_MERGE_NV = 0,
        VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = 1,
        VK_COVERAGE_REDUCTION_MODE_BEGIN_RANGE_NV = VK_COVERAGE_REDUCTION_MODE_MERGE_NV,
        VK_COVERAGE_REDUCTION_MODE_END_RANGE_NV = VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV,
        VK_COVERAGE_REDUCTION_MODE_RANGE_SIZE_NV = (VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV - VK_COVERAGE_REDUCTION_MODE_MERGE_NV + 1),
        VK_COVERAGE_REDUCTION_MODE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
