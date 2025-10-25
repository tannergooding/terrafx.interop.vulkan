// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h264std_encode 1")]
    public const int vulkan_video_codec_h264std_encode = 1;

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_0_9_11 VK_MAKE_VIDEO_STD_VERSION(0, 9, 11)")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_0_9_11 = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(11)));

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_SPEC_VERSION VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_0_9_11")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_SPEC_VERSION = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(11)));

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_EXTENSION_NAME \"VK_STD_vulkan_video_codec_h264_encode\"")]
    public static ReadOnlySpan<byte> VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_EXTENSION_NAME => "VK_STD_vulkan_video_codec_h264_encode"u8;
}
