// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkAndroidHardwareBufferPropertiesANDROID" /> struct.</summary>
    public static unsafe class VkAndroidHardwareBufferPropertiesANDROIDTests
    {
        /// <summary>Validates that the <see cref="VkAndroidHardwareBufferPropertiesANDROID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkAndroidHardwareBufferPropertiesANDROID>(), Is.EqualTo(sizeof(VkAndroidHardwareBufferPropertiesANDROID)));
        }

        /// <summary>Validates that the <see cref="VkAndroidHardwareBufferPropertiesANDROID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkAndroidHardwareBufferPropertiesANDROID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkAndroidHardwareBufferPropertiesANDROID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkAndroidHardwareBufferPropertiesANDROID), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkAndroidHardwareBufferPropertiesANDROID), Is.EqualTo(24));
            }
        }
    }
}
