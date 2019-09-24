// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSubpassDependency2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint srcSubpass;

        [NativeTypeName("uint32_t")]
        public uint dstSubpass;

        [NativeTypeName("VkPipelineStageFlags")]
        public uint srcStageMask;

        [NativeTypeName("VkPipelineStageFlags")]
        public uint dstStageMask;

        [NativeTypeName("VkAccessFlags")]
        public uint srcAccessMask;

        [NativeTypeName("VkAccessFlags")]
        public uint dstAccessMask;

        [NativeTypeName("VkDependencyFlags")]
        public uint dependencyFlags;

        [NativeTypeName("int32_t")]
        public int viewOffset;
    }
}