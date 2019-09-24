// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkShaderStatisticsInfoAMD
    {
        [NativeTypeName("VkShaderStageFlags")]
        public uint shaderStageMask;

        public VkShaderResourceUsageAMD resourceUsage;

        [NativeTypeName("uint32_t")]
        public uint numPhysicalVgprs;

        [NativeTypeName("uint32_t")]
        public uint numPhysicalSgprs;

        [NativeTypeName("uint32_t")]
        public uint numAvailableVgprs;

        [NativeTypeName("uint32_t")]
        public uint numAvailableSgprs;

        [NativeTypeName("uint32_t [3]")]
        public fixed uint computeWorkGroupSize[3];
    }
}