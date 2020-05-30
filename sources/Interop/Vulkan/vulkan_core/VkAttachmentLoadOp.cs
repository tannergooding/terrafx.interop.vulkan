// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkAttachmentLoadOp
    {
        VK_ATTACHMENT_LOAD_OP_LOAD = 0,
        VK_ATTACHMENT_LOAD_OP_CLEAR = 1,
        VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,
        VK_ATTACHMENT_LOAD_OP_BEGIN_RANGE = VK_ATTACHMENT_LOAD_OP_LOAD,
        VK_ATTACHMENT_LOAD_OP_END_RANGE = VK_ATTACHMENT_LOAD_OP_DONT_CARE,
        VK_ATTACHMENT_LOAD_OP_RANGE_SIZE = (VK_ATTACHMENT_LOAD_OP_DONT_CARE - VK_ATTACHMENT_LOAD_OP_LOAD + 1),
        VK_ATTACHMENT_LOAD_OP_MAX_ENUM = 0x7FFFFFFF,
    }
}
