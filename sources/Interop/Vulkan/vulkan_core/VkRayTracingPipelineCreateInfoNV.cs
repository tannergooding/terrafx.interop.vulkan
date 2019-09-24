// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineCreateFlags")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint stageCount;

        [NativeTypeName("const VkPipelineShaderStageCreateInfo *")]
        public VkPipelineShaderStageCreateInfo* pStages;

        [NativeTypeName("uint32_t")]
        public uint groupCount;

        [NativeTypeName("const VkRayTracingShaderGroupCreateInfoNV *")]
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;

        [NativeTypeName("uint32_t")]
        public uint maxRecursionDepth;

        [NativeTypeName("VkPipelineLayout")]
        public ulong layout;

        [NativeTypeName("VkPipeline")]
        public ulong basePipelineHandle;

        [NativeTypeName("int32_t")]
        public int basePipelineIndex;
    }
}