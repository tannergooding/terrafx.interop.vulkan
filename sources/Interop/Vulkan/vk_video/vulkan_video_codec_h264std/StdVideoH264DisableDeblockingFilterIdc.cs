// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum StdVideoH264DisableDeblockingFilterIdc
    {
        std_video_h264_disable_deblocking_filter_idc_disabled = 0,
        std_video_h264_disable_deblocking_filter_idc_enabled = 1,
        std_video_h264_disable_deblocking_filter_idc_partial = 2,
        std_video_h264_disable_deblocking_filter_idc_invalid = 0x7FFFFFFF,
    }
}
