// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2020 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoDecodeH264MvcElement" /> struct.</summary>
    public static unsafe class StdVideoDecodeH264MvcElementTests
    {
        /// <summary>Validates that the <see cref="StdVideoDecodeH264MvcElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoDecodeH264MvcElement>(), Is.EqualTo(sizeof(StdVideoDecodeH264MvcElement)));
        }

        /// <summary>Validates that the <see cref="StdVideoDecodeH264MvcElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoDecodeH264MvcElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoDecodeH264MvcElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(StdVideoDecodeH264MvcElement), Is.EqualTo(140));
        }
    }
}
