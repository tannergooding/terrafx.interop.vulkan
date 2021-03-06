// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineViewportStateCreateFlags")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint viewportCount;

        [NativeTypeName("const VkViewport *")]
        public VkViewport* pViewports;

        [NativeTypeName("uint32_t")]
        public uint scissorCount;

        [NativeTypeName("const VkRect2D *")]
        public VkRect2D* pScissors;
    }
}
