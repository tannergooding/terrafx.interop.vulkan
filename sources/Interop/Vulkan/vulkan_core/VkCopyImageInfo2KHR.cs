// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkCopyImageInfo2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkImage")]
        public ulong srcImage;

        public VkImageLayout srcImageLayout;

        [NativeTypeName("VkImage")]
        public ulong dstImage;

        public VkImageLayout dstImageLayout;

        [NativeTypeName("uint32_t")]
        public uint regionCount;

        [NativeTypeName("const VkImageCopy2KHR *")]
        public VkImageCopy2KHR* pRegions;
    }
}
