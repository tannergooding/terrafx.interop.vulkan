// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkBindImageMemoryInfo" /> struct.</summary>
    public static unsafe class VkBindImageMemoryInfoTests
    {
        /// <summary>Validates that the <see cref="VkBindImageMemoryInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkBindImageMemoryInfo>(), Is.EqualTo(sizeof(VkBindImageMemoryInfo)));
        }

        /// <summary>Validates that the <see cref="VkBindImageMemoryInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkBindImageMemoryInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkBindImageMemoryInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkBindImageMemoryInfo), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(VkBindImageMemoryInfo), Is.EqualTo(32));
            }
        }
    }
}
