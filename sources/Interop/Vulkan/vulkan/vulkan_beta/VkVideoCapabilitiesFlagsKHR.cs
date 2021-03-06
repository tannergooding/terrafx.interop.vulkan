// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum VkVideoCapabilitiesFlagsKHR : uint
    {
        VK_VIDEO_CAPABILITIES_PROTECTED_CONTENT_BIT_KHR = 0x00000001,
        VK_VIDEO_CAPABILITIES_SEPARATE_REFERENCE_IMAGES_BIT_KHR = 0x00000002,
        VK_VIDEO_CAPABILITIES_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
