// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineDepthStencilStateCreateFlags")]
        public uint flags;

        [NativeTypeName("VkBool32")]
        public uint depthTestEnable;

        [NativeTypeName("VkBool32")]
        public uint depthWriteEnable;

        public VkCompareOp depthCompareOp;

        [NativeTypeName("VkBool32")]
        public uint depthBoundsTestEnable;

        [NativeTypeName("VkBool32")]
        public uint stencilTestEnable;

        public VkStencilOpState front;

        public VkStencilOpState back;

        public float minDepthBounds;

        public float maxDepthBounds;
    }
}
