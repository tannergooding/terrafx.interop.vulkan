// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct StdVideoDecodeH264MvcElement
    {
        public StdVideoDecodeH264MvcElementFlags flags;

        [NativeTypeName("uint16_t")]
        public ushort viewOrderIndex;

        [NativeTypeName("uint16_t")]
        public ushort viewId;

        [NativeTypeName("uint16_t")]
        public ushort temporalId;

        [NativeTypeName("uint16_t")]
        public ushort priorityId;

        [NativeTypeName("uint16_t")]
        public ushort numOfAnchorRefsInL0;

        [NativeTypeName("uint16_t [15]")]
        public fixed ushort viewIdOfAnchorRefsInL0[15];

        [NativeTypeName("uint16_t")]
        public ushort numOfAnchorRefsInL1;

        [NativeTypeName("uint16_t [15]")]
        public fixed ushort viewIdOfAnchorRefsInL1[15];

        [NativeTypeName("uint16_t")]
        public ushort numOfNonAnchorRefsInL0;

        [NativeTypeName("uint16_t [15]")]
        public fixed ushort viewIdOfNonAnchorRefsInL0[15];

        [NativeTypeName("uint16_t")]
        public ushort numOfNonAnchorRefsInL1;

        [NativeTypeName("uint16_t [15]")]
        public fixed ushort viewIdOfNonAnchorRefsInL1[15];
    }
}
