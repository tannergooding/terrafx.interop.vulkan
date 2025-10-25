// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH265RateControlLayerInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint useMinQp;

    public VkVideoEncodeH265QpEXT minQp;

    [NativeTypeName("VkBool32")]
    public uint useMaxQp;

    public VkVideoEncodeH265QpEXT maxQp;

    [NativeTypeName("VkBool32")]
    public uint useMaxFrameSize;

    public VkVideoEncodeH265FrameSizeEXT maxFrameSize;
}
