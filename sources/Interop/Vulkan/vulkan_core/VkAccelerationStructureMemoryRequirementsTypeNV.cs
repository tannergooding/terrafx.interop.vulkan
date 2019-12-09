// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkAccelerationStructureMemoryRequirementsTypeNV
    {
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = 0,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = 1,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = 2,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BEGIN_RANGE_NV = VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_END_RANGE_NV = VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_RANGE_SIZE_NV = (VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV - VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV + 1),
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
