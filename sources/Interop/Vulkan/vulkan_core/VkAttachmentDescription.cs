// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkAttachmentDescription
    {
        [NativeTypeName("VkAttachmentDescriptionFlags")]
        public uint flags;

        public VkFormat format;

        public VkSampleCountFlagBits samples;

        public VkAttachmentLoadOp loadOp;

        public VkAttachmentStoreOp storeOp;

        public VkAttachmentLoadOp stencilLoadOp;

        public VkAttachmentStoreOp stencilStoreOp;

        public VkImageLayout initialLayout;

        public VkImageLayout finalLayout;
    }
}