// This file was generated, don't manually edit
namespace Vulkan_1_2;

#pragma warning disable CS0618 // Type or member is obsolete
public static unsafe class VK
{
	public const uint UuidSize = 16;
	public const uint AttachmentUnused = ~0U;
	public const uint False = 0;
	public const float LodClampNone = 1000F;
	public const uint QueueFamilyIgnored = ~0U;
	public const uint RemainingArrayLayers = ~0U;
	public const uint RemainingMipLevels = ~0U;
	public const uint SubpassExternal = ~0U;
	public const uint True = 1;
	public const ulong WholeSize = ~0UL;
	public const uint MaxPhysicalDeviceNameSize = 256;
	public const uint MaxMemoryTypes = 32;
	public const uint MaxMemoryHeaps = 16;
	public const uint MaxExtensionNameSize = 256;
	public const uint MaxDescriptionSize = 256;
	public const uint MaxDeviceGroupSize = 32;
	public const uint LuidSize = 8;
	public const uint QueueFamilyExternal = ~1U;
	public const uint MaxDriverNameSize = 256;
	public const uint MaxDriverInfoSize = 256;
	public const uint KhrSurfaceSpecVersion = 25;
	public const string KhrSurfaceExtensionName = "VK_KHR_surface";
	public const uint KhrSwapchainSpecVersion = 70;
	public const string KhrSwapchainExtensionName = "VK_KHR_swapchain";
	public const uint KhrDisplaySpecVersion = 23;
	public const string KhrDisplayExtensionName = "VK_KHR_display";
	public const uint KhrDisplaySwapchainSpecVersion = 10;
	public const string KhrDisplaySwapchainExtensionName = "VK_KHR_display_swapchain";
	public const uint KhrXlibSurfaceSpecVersion = 6;
	public const string KhrXlibSurfaceExtensionName = "VK_KHR_xlib_surface";
	public const uint KhrXcbSurfaceSpecVersion = 6;
	public const string KhrXcbSurfaceExtensionName = "VK_KHR_xcb_surface";
	public const uint KhrWaylandSurfaceSpecVersion = 6;
	public const string KhrWaylandSurfaceExtensionName = "VK_KHR_wayland_surface";
	public const uint KhrAndroidSurfaceSpecVersion = 6;
	public const string KhrAndroidSurfaceExtensionName = "VK_KHR_android_surface";
	public const uint KhrWin32SurfaceSpecVersion = 6;
	public const string KhrWin32SurfaceExtensionName = "VK_KHR_win32_surface";
	public const uint ExtDebugReportSpecVersion = 10;
	public const string ExtDebugReportExtensionName = "VK_EXT_debug_report";
	public const uint NvGlslShaderSpecVersion = 1;
	public const string NvGlslShaderExtensionName = "VK_NV_glsl_shader";
	public const uint ExtDepthRangeUnrestrictedSpecVersion = 1;
	public const string ExtDepthRangeUnrestrictedExtensionName = "VK_EXT_depth_range_unrestricted";
	public const uint KhrSamplerMirrorClampToEdgeSpecVersion = 3;
	public const string KhrSamplerMirrorClampToEdgeExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
	public const uint ImgFilterCubicSpecVersion = 1;
	public const string ImgFilterCubicExtensionName = "VK_IMG_filter_cubic";
	public const uint AmdRasterizationOrderSpecVersion = 1;
	public const string AmdRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
	public const uint AmdShaderTrinaryMinmaxSpecVersion = 1;
	public const string AmdShaderTrinaryMinmaxExtensionName = "VK_AMD_shader_trinary_minmax";
	public const uint AmdShaderExplicitVertexParameterSpecVersion = 1;
	public const string AmdShaderExplicitVertexParameterExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
	public const uint ExtDebugMarkerSpecVersion = 4;
	public const string ExtDebugMarkerExtensionName = "VK_EXT_debug_marker";
	public const uint AmdGcnShaderSpecVersion = 1;
	public const string AmdGcnShaderExtensionName = "VK_AMD_gcn_shader";
	public const uint NvDedicatedAllocationSpecVersion = 1;
	public const string NvDedicatedAllocationExtensionName = "VK_NV_dedicated_allocation";
	public const uint ExtTransformFeedbackSpecVersion = 1;
	public const string ExtTransformFeedbackExtensionName = "VK_EXT_transform_feedback";
	public const uint NvxBinaryImportSpecVersion = 1;
	public const string NvxBinaryImportExtensionName = "VK_NVX_binary_import";
	public const uint NvxImageViewHandleSpecVersion = 2;
	public const string NvxImageViewHandleExtensionName = "VK_NVX_image_view_handle";
	public const uint AmdDrawIndirectCountSpecVersion = 2;
	public const string AmdDrawIndirectCountExtensionName = "VK_AMD_draw_indirect_count";
	public const uint AmdNegativeViewportHeightSpecVersion = 1;
	public const string AmdNegativeViewportHeightExtensionName = "VK_AMD_negative_viewport_height";
	public const uint AmdGpuShaderHalfFloatSpecVersion = 2;
	public const string AmdGpuShaderHalfFloatExtensionName = "VK_AMD_gpu_shader_half_float";
	public const uint AmdShaderBallotSpecVersion = 1;
	public const string AmdShaderBallotExtensionName = "VK_AMD_shader_ballot";
	public const uint AmdTextureGatherBiasLodSpecVersion = 1;
	public const string AmdTextureGatherBiasLodExtensionName = "VK_AMD_texture_gather_bias_lod";
	public const uint AmdShaderInfoSpecVersion = 1;
	public const string AmdShaderInfoExtensionName = "VK_AMD_shader_info";
	public const uint KhrDynamicRenderingSpecVersion = 1;
	public const string KhrDynamicRenderingExtensionName = "VK_KHR_dynamic_rendering";
	public const uint AmdShaderImageLoadStoreLodSpecVersion = 1;
	public const string AmdShaderImageLoadStoreLodExtensionName = "VK_AMD_shader_image_load_store_lod";
	public const uint NvCornerSampledImageSpecVersion = 2;
	public const string NvCornerSampledImageExtensionName = "VK_NV_corner_sampled_image";
	public const uint KhrMultiviewSpecVersion = 1;
	public const string KhrMultiviewExtensionName = "VK_KHR_multiview";
	public const uint ImgFormatPvrtcSpecVersion = 1;
	public const string ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
	public const uint NvExternalMemoryCapabilitiesSpecVersion = 1;
	public const string NvExternalMemoryCapabilitiesExtensionName = "VK_NV_external_memory_capabilities";
	public const uint NvExternalMemorySpecVersion = 1;
	public const string NvExternalMemoryExtensionName = "VK_NV_external_memory";
	public const uint NvExternalMemoryWin32SpecVersion = 1;
	public const string NvExternalMemoryWin32ExtensionName = "VK_NV_external_memory_win32";
	public const uint NvWin32KeyedMutexSpecVersion = 2;
	public const string NvWin32KeyedMutexExtensionName = "VK_NV_win32_keyed_mutex";
	public const uint KhrGetPhysicalDeviceProperties2SpecVersion = 2;
	public const string KhrGetPhysicalDeviceProperties2ExtensionName = "VK_KHR_get_physical_device_properties2";
	public const uint KhrDeviceGroupSpecVersion = 4;
	public const string KhrDeviceGroupExtensionName = "VK_KHR_device_group";
	public const uint ExtValidationFlagsSpecVersion = 2;
	public const string ExtValidationFlagsExtensionName = "VK_EXT_validation_flags";
	public const uint KhrShaderDrawParametersSpecVersion = 1;
	public const string KhrShaderDrawParametersExtensionName = "VK_KHR_shader_draw_parameters";
	public const uint ExtShaderSubgroupBallotSpecVersion = 1;
	public const string ExtShaderSubgroupBallotExtensionName = "VK_EXT_shader_subgroup_ballot";
	public const uint ExtShaderSubgroupVoteSpecVersion = 1;
	public const string ExtShaderSubgroupVoteExtensionName = "VK_EXT_shader_subgroup_vote";
	public const uint ExtTextureCompressionAstcHdrSpecVersion = 1;
	public const string ExtTextureCompressionAstcHdrExtensionName = "VK_EXT_texture_compression_astc_hdr";
	public const uint ExtAstcDecodeModeSpecVersion = 1;
	public const string ExtAstcDecodeModeExtensionName = "VK_EXT_astc_decode_mode";
	public const uint KhrMaintenance1SpecVersion = 2;
	public const string KhrMaintenance1ExtensionName = "VK_KHR_maintenance1";
	[Obsolete("Use MaxDeviceGroupSize")]
	public const uint MaxDeviceGroupSizeKhr = MaxDeviceGroupSize;
	public const uint KhrDeviceGroupCreationSpecVersion = 1;
	public const string KhrDeviceGroupCreationExtensionName = "VK_KHR_device_group_creation";
	[Obsolete("Use LuidSize")]
	public const uint LuidSizeKhr = LuidSize;
	public const uint KhrExternalMemoryCapabilitiesSpecVersion = 1;
	public const string KhrExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
	[Obsolete("Use QueueFamilyExternal")]
	public const uint QueueFamilyExternalKhr = QueueFamilyExternal;
	public const uint KhrExternalMemorySpecVersion = 1;
	public const string KhrExternalMemoryExtensionName = "VK_KHR_external_memory";
	public const uint KhrExternalMemoryWin32SpecVersion = 1;
	public const string KhrExternalMemoryWin32ExtensionName = "VK_KHR_external_memory_win32";
	public const uint KhrExternalMemoryFdSpecVersion = 1;
	public const string KhrExternalMemoryFdExtensionName = "VK_KHR_external_memory_fd";
	public const uint KhrWin32KeyedMutexSpecVersion = 1;
	public const string KhrWin32KeyedMutexExtensionName = "VK_KHR_win32_keyed_mutex";
	public const uint KhrExternalSemaphoreCapabilitiesSpecVersion = 1;
	public const string KhrExternalSemaphoreCapabilitiesExtensionName = "VK_KHR_external_semaphore_capabilities";
	public const uint KhrExternalSemaphoreSpecVersion = 1;
	public const string KhrExternalSemaphoreExtensionName = "VK_KHR_external_semaphore";
	public const uint KhrExternalSemaphoreWin32SpecVersion = 1;
	public const string KhrExternalSemaphoreWin32ExtensionName = "VK_KHR_external_semaphore_win32";
	public const uint KhrExternalSemaphoreFdSpecVersion = 1;
	public const string KhrExternalSemaphoreFdExtensionName = "VK_KHR_external_semaphore_fd";
	public const uint KhrPushDescriptorSpecVersion = 2;
	public const string KhrPushDescriptorExtensionName = "VK_KHR_push_descriptor";
	public const uint ExtConditionalRenderingSpecVersion = 2;
	public const string ExtConditionalRenderingExtensionName = "VK_EXT_conditional_rendering";
	public const uint KhrShaderFloat16Int8SpecVersion = 1;
	public const string KhrShaderFloat16Int8ExtensionName = "VK_KHR_shader_float16_int8";
	public const uint Khr16bitStorageSpecVersion = 1;
	public const string Khr16bitStorageExtensionName = "VK_KHR_16bit_storage";
	public const uint KhrIncrementalPresentSpecVersion = 2;
	public const string KhrIncrementalPresentExtensionName = "VK_KHR_incremental_present";
	public const uint KhrDescriptorUpdateTemplateSpecVersion = 1;
	public const string KhrDescriptorUpdateTemplateExtensionName = "VK_KHR_descriptor_update_template";
	public const uint NvClipSpaceWScalingSpecVersion = 1;
	public const string NvClipSpaceWScalingExtensionName = "VK_NV_clip_space_w_scaling";
	public const uint ExtDirectModeDisplaySpecVersion = 1;
	public const string ExtDirectModeDisplayExtensionName = "VK_EXT_direct_mode_display";
	public const uint ExtDisplaySurfaceCounterSpecVersion = 1;
	public const string ExtDisplaySurfaceCounterExtensionName = "VK_EXT_display_surface_counter";
	public const uint ExtDisplayControlSpecVersion = 1;
	public const string ExtDisplayControlExtensionName = "VK_EXT_display_control";
	public const uint GoogleDisplayTimingSpecVersion = 1;
	public const string GoogleDisplayTimingExtensionName = "VK_GOOGLE_display_timing";
	public const uint NvSampleMaskOverrideCoverageSpecVersion = 1;
	public const string NvSampleMaskOverrideCoverageExtensionName = "VK_NV_sample_mask_override_coverage";
	public const uint NvGeometryShaderPassthroughSpecVersion = 1;
	public const string NvGeometryShaderPassthroughExtensionName = "VK_NV_geometry_shader_passthrough";
	public const uint NvViewportArray2SpecVersion = 1;
	public const string NvViewportArray2ExtensionName = "VK_NV_viewport_array2";
	public const uint NvxMultiviewPerViewAttributesSpecVersion = 1;
	public const string NvxMultiviewPerViewAttributesExtensionName = "VK_NVX_multiview_per_view_attributes";
	public const uint NvViewportSwizzleSpecVersion = 1;
	public const string NvViewportSwizzleExtensionName = "VK_NV_viewport_swizzle";
	public const uint ExtDiscardRectanglesSpecVersion = 1;
	public const string ExtDiscardRectanglesExtensionName = "VK_EXT_discard_rectangles";
	public const uint ExtConservativeRasterizationSpecVersion = 1;
	public const string ExtConservativeRasterizationExtensionName = "VK_EXT_conservative_rasterization";
	public const uint ExtDepthClipEnableSpecVersion = 1;
	public const string ExtDepthClipEnableExtensionName = "VK_EXT_depth_clip_enable";
	public const uint ExtSwapchainColorSpaceSpecVersion = 4;
	public const string ExtSwapchainColorSpaceExtensionName = "VK_EXT_swapchain_colorspace";
	public const uint ExtHdrMetadataSpecVersion = 2;
	public const string ExtHdrMetadataExtensionName = "VK_EXT_hdr_metadata";
	public const uint KhrImagelessFramebufferSpecVersion = 1;
	public const string KhrImagelessFramebufferExtensionName = "VK_KHR_imageless_framebuffer";
	public const uint KhrCreateRenderpass2SpecVersion = 1;
	public const string KhrCreateRenderpass2ExtensionName = "VK_KHR_create_renderpass2";
	public const uint KhrSharedPresentableImageSpecVersion = 1;
	public const string KhrSharedPresentableImageExtensionName = "VK_KHR_shared_presentable_image";
	public const uint KhrExternalFenceCapabilitiesSpecVersion = 1;
	public const string KhrExternalFenceCapabilitiesExtensionName = "VK_KHR_external_fence_capabilities";
	public const uint KhrExternalFenceSpecVersion = 1;
	public const string KhrExternalFenceExtensionName = "VK_KHR_external_fence";
	public const uint KhrExternalFenceWin32SpecVersion = 1;
	public const string KhrExternalFenceWin32ExtensionName = "VK_KHR_external_fence_win32";
	public const uint KhrExternalFenceFdSpecVersion = 1;
	public const string KhrExternalFenceFdExtensionName = "VK_KHR_external_fence_fd";
	public const uint KhrPerformanceQuerySpecVersion = 1;
	public const string KhrPerformanceQueryExtensionName = "VK_KHR_performance_query";
	public const uint KhrMaintenance2SpecVersion = 1;
	public const string KhrMaintenance2ExtensionName = "VK_KHR_maintenance2";
	public const uint KhrGetSurfaceCapabilities2SpecVersion = 1;
	public const string KhrGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
	public const uint KhrVariablePointersSpecVersion = 1;
	public const string KhrVariablePointersExtensionName = "VK_KHR_variable_pointers";
	public const uint KhrGetDisplayProperties2SpecVersion = 1;
	public const string KhrGetDisplayProperties2ExtensionName = "VK_KHR_get_display_properties2";
	public const uint MvkMacosSurfaceSpecVersion = 3;
	public const string MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
	public const uint ExtExternalMemoryDmaBufSpecVersion = 1;
	public const string ExtExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
	public const uint QueueFamilyForeignExt = ~2U;
	public const uint ExtQueueFamilyForeignSpecVersion = 1;
	public const string ExtQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
	public const uint KhrDedicatedAllocationSpecVersion = 3;
	public const string KhrDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
	public const uint ExtDebugUtilsSpecVersion = 2;
	public const string ExtDebugUtilsExtensionName = "VK_EXT_debug_utils";
	public const uint AndroidExternalMemoryAndroidHardwareBufferSpecVersion = 4;
	public const string AndroidExternalMemoryAndroidHardwareBufferExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
	public const uint ExtSamplerFilterMinmaxSpecVersion = 2;
	public const string ExtSamplerFilterMinmaxExtensionName = "VK_EXT_sampler_filter_minmax";
	public const uint KhrStorageBufferStorageClassSpecVersion = 1;
	public const string KhrStorageBufferStorageClassExtensionName = "VK_KHR_storage_buffer_storage_class";
	public const uint AmdGpuShaderInt16SpecVersion = 2;
	public const string AmdGpuShaderInt16ExtensionName = "VK_AMD_gpu_shader_int16";
	public const uint AmdMixedAttachmentSamplesSpecVersion = 1;
	public const string AmdMixedAttachmentSamplesExtensionName = "VK_AMD_mixed_attachment_samples";
	public const uint AmdShaderFragmentMaskSpecVersion = 1;
	public const string AmdShaderFragmentMaskExtensionName = "VK_AMD_shader_fragment_mask";
	public const uint ExtInlineUniformBlockSpecVersion = 1;
	public const string ExtInlineUniformBlockExtensionName = "VK_EXT_inline_uniform_block";
	public const uint ExtShaderStencilExportSpecVersion = 1;
	public const string ExtShaderStencilExportExtensionName = "VK_EXT_shader_stencil_export";
	public const uint ExtSampleLocationsSpecVersion = 1;
	public const string ExtSampleLocationsExtensionName = "VK_EXT_sample_locations";
	public const uint KhrRelaxedBlockLayoutSpecVersion = 1;
	public const string KhrRelaxedBlockLayoutExtensionName = "VK_KHR_relaxed_block_layout";
	public const uint KhrGetMemoryRequirements2SpecVersion = 1;
	public const string KhrGetMemoryRequirements2ExtensionName = "VK_KHR_get_memory_requirements2";
	public const uint KhrImageFormatListSpecVersion = 1;
	public const string KhrImageFormatListExtensionName = "VK_KHR_image_format_list";
	public const uint ExtBlendOperationAdvancedSpecVersion = 2;
	public const string ExtBlendOperationAdvancedExtensionName = "VK_EXT_blend_operation_advanced";
	public const uint NvFragmentCoverageToColorSpecVersion = 1;
	public const string NvFragmentCoverageToColorExtensionName = "VK_NV_fragment_coverage_to_color";
	public const uint KhrAccelerationStructureSpecVersion = 13;
	public const string KhrAccelerationStructureExtensionName = "VK_KHR_acceleration_structure";
	public const uint ShaderUnusedKhr = ~0U;
	public const uint KhrRayTracingPipelineSpecVersion = 1;
	public const string KhrRayTracingPipelineExtensionName = "VK_KHR_ray_tracing_pipeline";
	public const uint KhrRayQuerySpecVersion = 1;
	public const string KhrRayQueryExtensionName = "VK_KHR_ray_query";
	public const uint NvFramebufferMixedSamplesSpecVersion = 1;
	public const string NvFramebufferMixedSamplesExtensionName = "VK_NV_framebuffer_mixed_samples";
	public const uint NvFillRectangleSpecVersion = 1;
	public const string NvFillRectangleExtensionName = "VK_NV_fill_rectangle";
	public const uint NvShaderSmBuiltinsSpecVersion = 1;
	public const string NvShaderSmBuiltinsExtensionName = "VK_NV_shader_sm_builtins";
	public const uint ExtPostDepthCoverageSpecVersion = 1;
	public const string ExtPostDepthCoverageExtensionName = "VK_EXT_post_depth_coverage";
	public const uint KhrSamplerYcbcrConversionSpecVersion = 14;
	public const string KhrSamplerYcbcrConversionExtensionName = "VK_KHR_sampler_ycbcr_conversion";
	public const uint KhrBindMemory2SpecVersion = 1;
	public const string KhrBindMemory2ExtensionName = "VK_KHR_bind_memory2";
	public const uint ExtImageDrmFormatModifierSpecVersion = 2;
	public const string ExtImageDrmFormatModifierExtensionName = "VK_EXT_image_drm_format_modifier";
	public const uint ExtValidationCacheSpecVersion = 1;
	public const string ExtValidationCacheExtensionName = "VK_EXT_validation_cache";
	public const uint ExtDescriptorIndexingSpecVersion = 2;
	public const string ExtDescriptorIndexingExtensionName = "VK_EXT_descriptor_indexing";
	public const uint ExtShaderViewportIndexLayerSpecVersion = 1;
	public const string ExtShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
	public const uint NvShadingRateImageSpecVersion = 3;
	public const string NvShadingRateImageExtensionName = "VK_NV_shading_rate_image";
	[Obsolete("Use ShaderUnusedKhr")]
	public const uint ShaderUnusedNv = ShaderUnusedKhr;
	public const uint NvRayTracingSpecVersion = 3;
	public const string NvRayTracingExtensionName = "VK_NV_ray_tracing";
	public const uint NvRepresentativeFragmentTestSpecVersion = 2;
	public const string NvRepresentativeFragmentTestExtensionName = "VK_NV_representative_fragment_test";
	public const uint KhrMaintenance3SpecVersion = 1;
	public const string KhrMaintenance3ExtensionName = "VK_KHR_maintenance3";
	public const uint KhrDrawIndirectCountSpecVersion = 1;
	public const string KhrDrawIndirectCountExtensionName = "VK_KHR_draw_indirect_count";
	public const uint ExtFilterCubicSpecVersion = 3;
	public const string ExtFilterCubicExtensionName = "VK_EXT_filter_cubic";
	public const uint QcomRenderPassShaderResolveSpecVersion = 4;
	public const string QcomRenderPassShaderResolveExtensionName = "VK_QCOM_render_pass_shader_resolve";
	public const uint ExtGlobalPrioritySpecVersion = 2;
	public const string ExtGlobalPriorityExtensionName = "VK_EXT_global_priority";
	public const uint KhrShaderSubgroupExtendedTypesSpecVersion = 1;
	public const string KhrShaderSubgroupExtendedTypesExtensionName = "VK_KHR_shader_subgroup_extended_types";
	public const uint Khr8bitStorageSpecVersion = 1;
	public const string Khr8bitStorageExtensionName = "VK_KHR_8bit_storage";
	public const uint ExtExternalMemoryHostSpecVersion = 1;
	public const string ExtExternalMemoryHostExtensionName = "VK_EXT_external_memory_host";
	public const uint AmdBufferMarkerSpecVersion = 1;
	public const string AmdBufferMarkerExtensionName = "VK_AMD_buffer_marker";
	public const uint KhrShaderAtomicInt64SpecVersion = 1;
	public const string KhrShaderAtomicInt64ExtensionName = "VK_KHR_shader_atomic_int64";
	public const uint KhrShaderClockSpecVersion = 1;
	public const string KhrShaderClockExtensionName = "VK_KHR_shader_clock";
	public const uint AmdPipelineCompilerControlSpecVersion = 1;
	public const string AmdPipelineCompilerControlExtensionName = "VK_AMD_pipeline_compiler_control";
	public const uint ExtCalibratedTimestampsSpecVersion = 2;
	public const string ExtCalibratedTimestampsExtensionName = "VK_EXT_calibrated_timestamps";
	public const uint AmdShaderCorePropertiesSpecVersion = 2;
	public const string AmdShaderCorePropertiesExtensionName = "VK_AMD_shader_core_properties";
	public const uint AmdMemoryOverallocationBehaviorSpecVersion = 1;
	public const string AmdMemoryOverallocationBehaviorExtensionName = "VK_AMD_memory_overallocation_behavior";
	public const uint ExtVertexAttributeDivisorSpecVersion = 3;
	public const string ExtVertexAttributeDivisorExtensionName = "VK_EXT_vertex_attribute_divisor";
	public const uint ExtPipelineCreationFeedbackSpecVersion = 1;
	public const string ExtPipelineCreationFeedbackExtensionName = "VK_EXT_pipeline_creation_feedback";
	[Obsolete("Use MaxDriverNameSize")]
	public const uint MaxDriverNameSizeKhr = MaxDriverNameSize;
	[Obsolete("Use MaxDriverInfoSize")]
	public const uint MaxDriverInfoSizeKhr = MaxDriverInfoSize;
	public const uint KhrDriverPropertiesSpecVersion = 1;
	public const string KhrDriverPropertiesExtensionName = "VK_KHR_driver_properties";
	public const uint KhrShaderFloatControlsSpecVersion = 4;
	public const string KhrShaderFloatControlsExtensionName = "VK_KHR_shader_float_controls";
	public const uint NvShaderSubgroupPartitionedSpecVersion = 1;
	public const string NvShaderSubgroupPartitionedExtensionName = "VK_NV_shader_subgroup_partitioned";
	public const uint KhrDepthStencilResolveSpecVersion = 1;
	public const string KhrDepthStencilResolveExtensionName = "VK_KHR_depth_stencil_resolve";
	public const uint KhrSwapchainMutableFormatSpecVersion = 1;
	public const string KhrSwapchainMutableFormatExtensionName = "VK_KHR_swapchain_mutable_format";
	public const uint NvComputeShaderDerivativesSpecVersion = 1;
	public const string NvComputeShaderDerivativesExtensionName = "VK_NV_compute_shader_derivatives";
	public const uint NvMeshShaderSpecVersion = 1;
	public const string NvMeshShaderExtensionName = "VK_NV_mesh_shader";
	public const uint NvFragmentShaderBarycentricSpecVersion = 1;
	public const string NvFragmentShaderBarycentricExtensionName = "VK_NV_fragment_shader_barycentric";
	public const uint NvShaderImageFootprintSpecVersion = 2;
	public const string NvShaderImageFootprintExtensionName = "VK_NV_shader_image_footprint";
	public const uint NvScissorExclusiveSpecVersion = 1;
	public const string NvScissorExclusiveExtensionName = "VK_NV_scissor_exclusive";
	public const uint NvDeviceDiagnosticCheckpointsSpecVersion = 2;
	public const string NvDeviceDiagnosticCheckpointsExtensionName = "VK_NV_device_diagnostic_checkpoints";
	public const uint KhrTimelineSemaphoreSpecVersion = 2;
	public const string KhrTimelineSemaphoreExtensionName = "VK_KHR_timeline_semaphore";
	public const uint IntelShaderIntegerFunctions2SpecVersion = 1;
	public const string IntelShaderIntegerFunctions2ExtensionName = "VK_INTEL_shader_integer_functions2";
	public const uint IntelPerformanceQuerySpecVersion = 2;
	public const string IntelPerformanceQueryExtensionName = "VK_INTEL_performance_query";
	public const uint KhrVulkanMemoryModelSpecVersion = 3;
	public const string KhrVulkanMemoryModelExtensionName = "VK_KHR_vulkan_memory_model";
	public const uint ExtPciBusInfoSpecVersion = 2;
	public const string ExtPciBusInfoExtensionName = "VK_EXT_pci_bus_info";
	public const uint AmdDisplayNativeHdrSpecVersion = 1;
	public const string AmdDisplayNativeHdrExtensionName = "VK_AMD_display_native_hdr";
	public const uint KhrShaderTerminateInvocationSpecVersion = 1;
	public const string KhrShaderTerminateInvocationExtensionName = "VK_KHR_shader_terminate_invocation";
	public const uint ExtFragmentDensityMapSpecVersion = 2;
	public const string ExtFragmentDensityMapExtensionName = "VK_EXT_fragment_density_map";
	public const uint ExtScalarBlockLayoutSpecVersion = 1;
	public const string ExtScalarBlockLayoutExtensionName = "VK_EXT_scalar_block_layout";
	public const uint GoogleHlslFunctionality1SpecVersion = 1;
	public const string GoogleHlslFunctionality1ExtensionName = "VK_GOOGLE_hlsl_functionality1";
	public const uint GoogleDecorateStringSpecVersion = 1;
	public const string GoogleDecorateStringExtensionName = "VK_GOOGLE_decorate_string";
	public const uint ExtSubgroupSizeControlSpecVersion = 2;
	public const string ExtSubgroupSizeControlExtensionName = "VK_EXT_subgroup_size_control";
	public const uint KhrFragmentShadingRateSpecVersion = 2;
	public const string KhrFragmentShadingRateExtensionName = "VK_KHR_fragment_shading_rate";
	public const uint AmdShaderCoreProperties2SpecVersion = 1;
	public const string AmdShaderCoreProperties2ExtensionName = "VK_AMD_shader_core_properties2";
	public const uint AmdDeviceCoherentMemorySpecVersion = 1;
	public const string AmdDeviceCoherentMemoryExtensionName = "VK_AMD_device_coherent_memory";
	public const uint ExtShaderImageAtomicInt64SpecVersion = 1;
	public const string ExtShaderImageAtomicInt64ExtensionName = "VK_EXT_shader_image_atomic_int64";
	public const uint KhrSpirv14SpecVersion = 1;
	public const string KhrSpirv14ExtensionName = "VK_KHR_spirv_1_4";
	public const uint ExtMemoryBudgetSpecVersion = 1;
	public const string ExtMemoryBudgetExtensionName = "VK_EXT_memory_budget";
	public const uint ExtMemoryPrioritySpecVersion = 1;
	public const string ExtMemoryPriorityExtensionName = "VK_EXT_memory_priority";
	public const uint KhrSurfaceProtectedCapabilitiesSpecVersion = 1;
	public const string KhrSurfaceProtectedCapabilitiesExtensionName = "VK_KHR_surface_protected_capabilities";
	public const uint NvDedicatedAllocationImageAliasingSpecVersion = 1;
	public const string NvDedicatedAllocationImageAliasingExtensionName = "VK_NV_dedicated_allocation_image_aliasing";
	public const uint KhrSeparateDepthStencilLayoutsSpecVersion = 1;
	public const string KhrSeparateDepthStencilLayoutsExtensionName = "VK_KHR_separate_depth_stencil_layouts";
	public const uint ExtBufferDeviceAddressSpecVersion = 2;
	public const string ExtBufferDeviceAddressExtensionName = "VK_EXT_buffer_device_address";
	public const uint ExtToolingInfoSpecVersion = 1;
	public const string ExtToolingInfoExtensionName = "VK_EXT_tooling_info";
	public const uint ExtSeparateStencilUsageSpecVersion = 1;
	public const string ExtSeparateStencilUsageExtensionName = "VK_EXT_separate_stencil_usage";
	public const uint ExtValidationFeaturesSpecVersion = 5;
	public const string ExtValidationFeaturesExtensionName = "VK_EXT_validation_features";
	public const uint KhrPresentWaitSpecVersion = 1;
	public const string KhrPresentWaitExtensionName = "VK_KHR_present_wait";
	public const uint NvCooperativeMatrixSpecVersion = 1;
	public const string NvCooperativeMatrixExtensionName = "VK_NV_cooperative_matrix";
	public const uint NvCoverageReductionModeSpecVersion = 1;
	public const string NvCoverageReductionModeExtensionName = "VK_NV_coverage_reduction_mode";
	public const uint ExtFragmentShaderInterlockSpecVersion = 1;
	public const string ExtFragmentShaderInterlockExtensionName = "VK_EXT_fragment_shader_interlock";
	public const uint ExtYcbcrImageArraysSpecVersion = 1;
	public const string ExtYcbcrImageArraysExtensionName = "VK_EXT_ycbcr_image_arrays";
	public const uint KhrUniformBufferStandardLayoutSpecVersion = 1;
	public const string KhrUniformBufferStandardLayoutExtensionName = "VK_KHR_uniform_buffer_standard_layout";
	public const uint ExtProvokingVertexSpecVersion = 1;
	public const string ExtProvokingVertexExtensionName = "VK_EXT_provoking_vertex";
	public const uint ExtFullScreenExclusiveSpecVersion = 4;
	public const string ExtFullScreenExclusiveExtensionName = "VK_EXT_full_screen_exclusive";
	public const uint ExtHeadlessSurfaceSpecVersion = 1;
	public const string ExtHeadlessSurfaceExtensionName = "VK_EXT_headless_surface";
	public const uint KhrBufferDeviceAddressSpecVersion = 1;
	public const string KhrBufferDeviceAddressExtensionName = "VK_KHR_buffer_device_address";
	public const uint ExtLineRasterizationSpecVersion = 1;
	public const string ExtLineRasterizationExtensionName = "VK_EXT_line_rasterization";
	public const uint ExtShaderAtomicFloatSpecVersion = 1;
	public const string ExtShaderAtomicFloatExtensionName = "VK_EXT_shader_atomic_float";
	public const uint ExtHostQueryResetSpecVersion = 1;
	public const string ExtHostQueryResetExtensionName = "VK_EXT_host_query_reset";
	public const uint ExtIndexTypeUint8SpecVersion = 1;
	public const string ExtIndexTypeUint8ExtensionName = "VK_EXT_index_type_uint8";
	public const uint ExtExtendedDynamicStateSpecVersion = 1;
	public const string ExtExtendedDynamicStateExtensionName = "VK_EXT_extended_dynamic_state";
	public const uint KhrDeferredHostOperationsSpecVersion = 4;
	public const string KhrDeferredHostOperationsExtensionName = "VK_KHR_deferred_host_operations";
	public const uint KhrPipelineExecutablePropertiesSpecVersion = 1;
	public const string KhrPipelineExecutablePropertiesExtensionName = "VK_KHR_pipeline_executable_properties";
	public const uint ExtShaderAtomicFloat2SpecVersion = 1;
	public const string ExtShaderAtomicFloat2ExtensionName = "VK_EXT_shader_atomic_float2";
	public const uint ExtShaderDemoteToHelperInvocationSpecVersion = 1;
	public const string ExtShaderDemoteToHelperInvocationExtensionName = "VK_EXT_shader_demote_to_helper_invocation";
	public const uint NvDeviceGeneratedCommandsSpecVersion = 3;
	public const string NvDeviceGeneratedCommandsExtensionName = "VK_NV_device_generated_commands";
	public const uint NvInheritedViewportScissorSpecVersion = 1;
	public const string NvInheritedViewportScissorExtensionName = "VK_NV_inherited_viewport_scissor";
	public const uint KhrShaderIntegerDotProductSpecVersion = 1;
	public const string KhrShaderIntegerDotProductExtensionName = "VK_KHR_shader_integer_dot_product";
	public const uint ExtTexelBufferAlignmentSpecVersion = 1;
	public const string ExtTexelBufferAlignmentExtensionName = "VK_EXT_texel_buffer_alignment";
	public const uint QcomRenderPassTransformSpecVersion = 2;
	public const string QcomRenderPassTransformExtensionName = "VK_QCOM_render_pass_transform";
	public const uint ExtDeviceMemoryReportSpecVersion = 2;
	public const string ExtDeviceMemoryReportExtensionName = "VK_EXT_device_memory_report";
	public const uint ExtAcquireDrmDisplaySpecVersion = 1;
	public const string ExtAcquireDrmDisplayExtensionName = "VK_EXT_acquire_drm_display";
	public const uint ExtRobustness2SpecVersion = 1;
	public const string ExtRobustness2ExtensionName = "VK_EXT_robustness2";
	public const uint ExtCustomBorderColorSpecVersion = 12;
	public const string ExtCustomBorderColorExtensionName = "VK_EXT_custom_border_color";
	public const uint GoogleUserTypeSpecVersion = 1;
	public const string GoogleUserTypeExtensionName = "VK_GOOGLE_user_type";
	public const uint KhrPipelineLibrarySpecVersion = 1;
	public const string KhrPipelineLibraryExtensionName = "VK_KHR_pipeline_library";
	public const uint KhrShaderNonSemanticInfoSpecVersion = 1;
	public const string KhrShaderNonSemanticInfoExtensionName = "VK_KHR_shader_non_semantic_info";
	public const uint KhrPresentIdSpecVersion = 1;
	public const string KhrPresentIdExtensionName = "VK_KHR_present_id";
	public const uint ExtPrivateDataSpecVersion = 1;
	public const string ExtPrivateDataExtensionName = "VK_EXT_private_data";
	public const uint ExtPipelineCreationCacheControlSpecVersion = 3;
	public const string ExtPipelineCreationCacheControlExtensionName = "VK_EXT_pipeline_creation_cache_control";
	public const uint NvDeviceDiagnosticsConfigSpecVersion = 1;
	public const string NvDeviceDiagnosticsConfigExtensionName = "VK_NV_device_diagnostics_config";
	public const uint QcomRenderPassStoreOpsSpecVersion = 2;
	public const string QcomRenderPassStoreOpsExtensionName = "VK_QCOM_render_pass_store_ops";
	public const uint KhrSynchronization2SpecVersion = 1;
	public const string KhrSynchronization2ExtensionName = "VK_KHR_synchronization2";
	public const uint KhrShaderSubgroupUniformControlFlowSpecVersion = 1;
	public const string KhrShaderSubgroupUniformControlFlowExtensionName = "VK_KHR_shader_subgroup_uniform_control_flow";
	public const uint KhrZeroInitializeWorkgroupMemorySpecVersion = 1;
	public const string KhrZeroInitializeWorkgroupMemoryExtensionName = "VK_KHR_zero_initialize_workgroup_memory";
	public const uint NvFragmentShadingRateEnumsSpecVersion = 1;
	public const string NvFragmentShadingRateEnumsExtensionName = "VK_NV_fragment_shading_rate_enums";
	public const uint NvRayTracingMotionBlurSpecVersion = 1;
	public const string NvRayTracingMotionBlurExtensionName = "VK_NV_ray_tracing_motion_blur";
	public const uint ExtYcbcr2plane444FormatsSpecVersion = 1;
	public const string ExtYcbcr2plane444FormatsExtensionName = "VK_EXT_ycbcr_2plane_444_formats";
	public const uint ExtFragmentDensityMap2SpecVersion = 1;
	public const string ExtFragmentDensityMap2ExtensionName = "VK_EXT_fragment_density_map2";
	public const uint QcomRotatedCopyCommandsSpecVersion = 1;
	public const string QcomRotatedCopyCommandsExtensionName = "VK_QCOM_rotated_copy_commands";
	public const uint ExtImageRobustnessSpecVersion = 1;
	public const string ExtImageRobustnessExtensionName = "VK_EXT_image_robustness";
	public const uint KhrWorkgroupMemoryExplicitLayoutSpecVersion = 1;
	public const string KhrWorkgroupMemoryExplicitLayoutExtensionName = "VK_KHR_workgroup_memory_explicit_layout";
	public const uint KhrCopyCommands2SpecVersion = 1;
	public const string KhrCopyCommands2ExtensionName = "VK_KHR_copy_commands2";
	public const uint Ext4444FormatsSpecVersion = 1;
	public const string Ext4444FormatsExtensionName = "VK_EXT_4444_formats";
	public const uint ArmRasterizationOrderAttachmentAccessSpecVersion = 1;
	public const string ArmRasterizationOrderAttachmentAccessExtensionName = "VK_ARM_rasterization_order_attachment_access";
	public const uint ExtRgba10x6FormatsSpecVersion = 1;
	public const string ExtRgba10x6FormatsExtensionName = "VK_EXT_rgba10x6_formats";
	public const uint NvAcquireWinrtDisplaySpecVersion = 1;
	public const string NvAcquireWinrtDisplayExtensionName = "VK_NV_acquire_winrt_display";
	public const uint ValveMutableDescriptorTypeSpecVersion = 1;
	public const string ValveMutableDescriptorTypeExtensionName = "VK_VALVE_mutable_descriptor_type";
	public const uint ExtVertexInputDynamicStateSpecVersion = 2;
	public const string ExtVertexInputDynamicStateExtensionName = "VK_EXT_vertex_input_dynamic_state";
	public const uint ExtPhysicalDeviceDrmSpecVersion = 1;
	public const string ExtPhysicalDeviceDrmExtensionName = "VK_EXT_physical_device_drm";
	public const uint ExtDepthClipControlSpecVersion = 1;
	public const string ExtDepthClipControlExtensionName = "VK_EXT_depth_clip_control";
	public const uint ExtPrimitiveTopologyListRestartSpecVersion = 1;
	public const string ExtPrimitiveTopologyListRestartExtensionName = "VK_EXT_primitive_topology_list_restart";
	public const uint KhrFormatFeatureFlags2SpecVersion = 1;
	public const string KhrFormatFeatureFlags2ExtensionName = "VK_KHR_format_feature_flags2";
	public const uint HuaweiSubpassShadingSpecVersion = 2;
	public const string HuaweiSubpassShadingExtensionName = "VK_HUAWEI_subpass_shading";
	public const uint HuaweiInvocationMaskSpecVersion = 1;
	public const string HuaweiInvocationMaskExtensionName = "VK_HUAWEI_invocation_mask";
	public const uint NvExternalMemoryRdmaSpecVersion = 1;
	public const string NvExternalMemoryRdmaExtensionName = "VK_NV_external_memory_rdma";
	public const uint ExtExtendedDynamicState2SpecVersion = 1;
	public const string ExtExtendedDynamicState2ExtensionName = "VK_EXT_extended_dynamic_state2";
	public const uint ExtColorWriteEnableSpecVersion = 1;
	public const string ExtColorWriteEnableExtensionName = "VK_EXT_color_write_enable";
	public const uint MaxGlobalPrioritySizeExt = 16;
	public const uint ExtGlobalPriorityQuerySpecVersion = 1;
	public const string ExtGlobalPriorityQueryExtensionName = "VK_EXT_global_priority_query";
	public const uint ExtImageViewMinLodSpecVersion = 1;
	public const string ExtImageViewMinLodExtensionName = "VK_EXT_image_view_min_lod";
	public const uint ExtMultiDrawSpecVersion = 1;
	public const string ExtMultiDrawExtensionName = "VK_EXT_multi_draw";
	public const uint ExtLoadStoreOpNoneSpecVersion = 1;
	public const string ExtLoadStoreOpNoneExtensionName = "VK_EXT_load_store_op_none";
	public const uint ExtBorderColorSwizzleSpecVersion = 1;
	public const string ExtBorderColorSwizzleExtensionName = "VK_EXT_border_color_swizzle";
	public const uint ExtPageableDeviceLocalMemorySpecVersion = 1;
	public const string ExtPageableDeviceLocalMemoryExtensionName = "VK_EXT_pageable_device_local_memory";
	public const uint KhrMaintenance4SpecVersion = 2;
	public const string KhrMaintenance4ExtensionName = "VK_KHR_maintenance4";
	public const uint QcomFragmentDensityMapOffsetSpecVersion = 1;
	public const string QcomFragmentDensityMapOffsetExtensionName = "VK_QCOM_fragment_density_map_offset";
	public const uint NvLinearColorAttachmentSpecVersion = 1;
	public const string NvLinearColorAttachmentExtensionName = "VK_NV_linear_color_attachment";
	public const uint GoogleSurfacelessQuerySpecVersion = 1;
	public const string GoogleSurfacelessQueryExtensionName = "VK_GOOGLE_surfaceless_query";
	public static VkResult CreateInstance(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) => CreateInstance_0(createInfo, allocator, out instance);
	public static bool CreateInstance(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance, out VkResult result)
	{
		result = CreateInstance_0(createInfo, allocator, out instance);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateInstanceDelegate_0(VkInstanceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkInstance instance);
	private static CreateInstanceDelegate_0 CreateInstance_0;
	public static VkResult CreateInstance(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) => CreateInstance_1(createInfo, ref allocator, out instance);
	public static bool CreateInstance(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance, out VkResult result)
	{
		result = CreateInstance_1(createInfo, ref allocator, out instance);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateInstanceDelegate_1(VkInstanceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance);
	private static CreateInstanceDelegate_1 CreateInstance_1;
	public static VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance) => CreateInstance_2(ref createInfo, allocator, out instance);
	public static bool CreateInstance(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance, out VkResult result)
	{
		result = CreateInstance_2(ref createInfo, allocator, out instance);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateInstanceDelegate_2(ref VkInstanceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkInstance instance);
	private static CreateInstanceDelegate_2 CreateInstance_2;
	public static VkResult CreateInstance(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance) => CreateInstance_3(ref createInfo, ref allocator, out instance);
	public static bool CreateInstance(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance, out VkResult result)
	{
		result = CreateInstance_3(ref createInfo, ref allocator, out instance);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateInstanceDelegate_3(ref VkInstanceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkInstance instance);
	private static CreateInstanceDelegate_3 CreateInstance_3;
	public static void DestroyInstance(VkInstance instance, VkAllocationCallbacks* allocator) => DestroyInstance_0(instance, allocator);
	private delegate void DestroyInstanceDelegate_0(VkInstance instance, VkAllocationCallbacks* allocator);
	private static DestroyInstanceDelegate_0 DestroyInstance_0;
	public static void DestroyInstance(VkInstance instance, ref VkAllocationCallbacks allocator) => DestroyInstance_1(instance, ref allocator);
	private delegate void DestroyInstanceDelegate_1(VkInstance instance, ref VkAllocationCallbacks allocator);
	private static DestroyInstanceDelegate_1 DestroyInstance_1;
	public static VkResult EnumeratePhysicalDevices(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices) => EnumeratePhysicalDevices_0(instance, physicalDeviceCount, physicalDevices);
	public static bool EnumeratePhysicalDevices(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices, out VkResult result)
	{
		result = EnumeratePhysicalDevices_0(instance, physicalDeviceCount, physicalDevices);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumeratePhysicalDevicesDelegate_0(VkInstance instance, uint* physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices);
	private static EnumeratePhysicalDevicesDelegate_0 EnumeratePhysicalDevices_0;
	public static VkResult EnumeratePhysicalDevices(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices) => EnumeratePhysicalDevices_1(instance, ref physicalDeviceCount, physicalDevices);
	public static bool EnumeratePhysicalDevices(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices, out VkResult result)
	{
		result = EnumeratePhysicalDevices_1(instance, ref physicalDeviceCount, physicalDevices);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumeratePhysicalDevicesDelegate_1(VkInstance instance, ref uint physicalDeviceCount, [In, Out] VkPhysicalDevice[] physicalDevices);
	private static EnumeratePhysicalDevicesDelegate_1 EnumeratePhysicalDevices_1;
	public static void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures features) => GetPhysicalDeviceFeatures_0(physicalDevice, out features);
	private delegate void GetPhysicalDeviceFeaturesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures features);
	private static GetPhysicalDeviceFeaturesDelegate_0 GetPhysicalDeviceFeatures_0;
	public static void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties formatProperties) => GetPhysicalDeviceFormatProperties_0(physicalDevice, format, out formatProperties);
	private delegate void GetPhysicalDeviceFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties formatProperties);
	private static GetPhysicalDeviceFormatPropertiesDelegate_0 GetPhysicalDeviceFormatProperties_0;
	public static VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties) => GetPhysicalDeviceImageFormatProperties_0(physicalDevice, format, type, tiling, usage, flags, out imageFormatProperties);
	public static bool GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties, out VkResult result)
	{
		result = GetPhysicalDeviceImageFormatProperties_0(physicalDevice, format, type, tiling, usage, flags, out imageFormatProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, out VkImageFormatProperties imageFormatProperties);
	private static GetPhysicalDeviceImageFormatPropertiesDelegate_0 GetPhysicalDeviceImageFormatProperties_0;
	public static void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties properties) => GetPhysicalDeviceProperties_0(physicalDevice, out properties);
	private delegate void GetPhysicalDevicePropertiesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties properties);
	private static GetPhysicalDevicePropertiesDelegate_0 GetPhysicalDeviceProperties_0;
	public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_0 GetPhysicalDeviceQueueFamilyProperties_0;
	public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyPropertiesDelegate_1 GetPhysicalDeviceQueueFamilyProperties_1;
	public static void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties) => GetPhysicalDeviceMemoryProperties_0(physicalDevice, out memoryProperties);
	private delegate void GetPhysicalDeviceMemoryPropertiesDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties memoryProperties);
	private static GetPhysicalDeviceMemoryPropertiesDelegate_0 GetPhysicalDeviceMemoryProperties_0;
	public static delegate*<void> GetInstanceProcedureAddress(VkInstance instance, string name) => GetInstanceProcedureAddress_0(instance, name);
	private delegate delegate*<void> GetInstanceProcedureAddressDelegate_0(VkInstance instance, string name);
	private static GetInstanceProcedureAddressDelegate_0 GetInstanceProcedureAddress_0;
	public static delegate*<void> GetDeviceProcedureAddress(VkDevice device, string name) => GetDeviceProcedureAddress_0(device, name);
	private delegate delegate*<void> GetDeviceProcedureAddressDelegate_0(VkDevice device, string name);
	private static GetDeviceProcedureAddressDelegate_0 GetDeviceProcedureAddress_0;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device) => CreateDevice_0(physicalDevice, createInfo, allocator, out device);
	public static bool CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device, out VkResult result)
	{
		result = CreateDevice_0(physicalDevice, createInfo, allocator, out device);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDeviceDelegate_0(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDevice device);
	private static CreateDeviceDelegate_0 CreateDevice_0;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device) => CreateDevice_1(physicalDevice, createInfo, ref allocator, out device);
	public static bool CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device, out VkResult result)
	{
		result = CreateDevice_1(physicalDevice, createInfo, ref allocator, out device);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDeviceDelegate_1(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDevice device);
	private static CreateDeviceDelegate_1 CreateDevice_1;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device) => CreateDevice_2(physicalDevice, ref createInfo, allocator, out device);
	public static bool CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device, out VkResult result)
	{
		result = CreateDevice_2(physicalDevice, ref createInfo, allocator, out device);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDeviceDelegate_2(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDevice device);
	private static CreateDeviceDelegate_2 CreateDevice_2;
	public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device) => CreateDevice_3(physicalDevice, ref createInfo, ref allocator, out device);
	public static bool CreateDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device, out VkResult result)
	{
		result = CreateDevice_3(physicalDevice, ref createInfo, ref allocator, out device);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDeviceDelegate_3(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDevice device);
	private static CreateDeviceDelegate_3 CreateDevice_3;
	public static void DestroyDevice(VkDevice device, VkAllocationCallbacks* allocator) => DestroyDevice_0(device, allocator);
	private delegate void DestroyDeviceDelegate_0(VkDevice device, VkAllocationCallbacks* allocator);
	private static DestroyDeviceDelegate_0 DestroyDevice_0;
	public static void DestroyDevice(VkDevice device, ref VkAllocationCallbacks allocator) => DestroyDevice_1(device, ref allocator);
	private delegate void DestroyDeviceDelegate_1(VkDevice device, ref VkAllocationCallbacks allocator);
	private static DestroyDeviceDelegate_1 DestroyDevice_1;
	public static VkResult EnumerateInstanceExtensionProperties(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_0(layerName, propertyCount, properties);
	public static bool EnumerateInstanceExtensionProperties(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties, out VkResult result)
	{
		result = EnumerateInstanceExtensionProperties_0(layerName, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_0(string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateInstanceExtensionPropertiesDelegate_0 EnumerateInstanceExtensionProperties_0;
	public static VkResult EnumerateInstanceExtensionProperties(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateInstanceExtensionProperties_1(layerName, ref propertyCount, properties);
	public static bool EnumerateInstanceExtensionProperties(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties, out VkResult result)
	{
		result = EnumerateInstanceExtensionProperties_1(layerName, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateInstanceExtensionPropertiesDelegate_1(string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateInstanceExtensionPropertiesDelegate_1 EnumerateInstanceExtensionProperties_1;
	public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_0(physicalDevice, layerName, propertyCount, properties);
	public static bool EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties, out VkResult result)
	{
		result = EnumerateDeviceExtensionProperties_0(physicalDevice, layerName, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_0(VkPhysicalDevice physicalDevice, string layerName, uint* propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateDeviceExtensionPropertiesDelegate_0 EnumerateDeviceExtensionProperties_0;
	public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties) => EnumerateDeviceExtensionProperties_1(physicalDevice, layerName, ref propertyCount, properties);
	public static bool EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties, out VkResult result)
	{
		result = EnumerateDeviceExtensionProperties_1(physicalDevice, layerName, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateDeviceExtensionPropertiesDelegate_1(VkPhysicalDevice physicalDevice, string layerName, ref uint propertyCount, [In, Out] VkExtensionProperties[] properties);
	private static EnumerateDeviceExtensionPropertiesDelegate_1 EnumerateDeviceExtensionProperties_1;
	public static VkResult EnumerateInstanceLayerProperties(uint* propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateInstanceLayerProperties_0(propertyCount, properties);
	public static bool EnumerateInstanceLayerProperties(uint* propertyCount, [In, Out] VkLayerProperties[] properties, out VkResult result)
	{
		result = EnumerateInstanceLayerProperties_0(propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateInstanceLayerPropertiesDelegate_0(uint* propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateInstanceLayerPropertiesDelegate_0 EnumerateInstanceLayerProperties_0;
	public static VkResult EnumerateInstanceLayerProperties(ref uint propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateInstanceLayerProperties_1(ref propertyCount, properties);
	public static bool EnumerateInstanceLayerProperties(ref uint propertyCount, [In, Out] VkLayerProperties[] properties, out VkResult result)
	{
		result = EnumerateInstanceLayerProperties_1(ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateInstanceLayerPropertiesDelegate_1(ref uint propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateInstanceLayerPropertiesDelegate_1 EnumerateInstanceLayerProperties_1;
	public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateDeviceLayerProperties_0(physicalDevice, propertyCount, properties);
	public static bool EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties, out VkResult result)
	{
		result = EnumerateDeviceLayerProperties_0(physicalDevice, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateDeviceLayerPropertiesDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateDeviceLayerPropertiesDelegate_0 EnumerateDeviceLayerProperties_0;
	public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties) => EnumerateDeviceLayerProperties_1(physicalDevice, ref propertyCount, properties);
	public static bool EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties, out VkResult result)
	{
		result = EnumerateDeviceLayerProperties_1(physicalDevice, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateDeviceLayerPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkLayerProperties[] properties);
	private static EnumerateDeviceLayerPropertiesDelegate_1 EnumerateDeviceLayerProperties_1;
	public static void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue queue) => GetDeviceQueue_0(device, queueFamilyIndex, queueIndex, out queue);
	private delegate void GetDeviceQueueDelegate_0(VkDevice device, uint queueFamilyIndex, uint queueIndex, out VkQueue queue);
	private static GetDeviceQueueDelegate_0 GetDeviceQueue_0;
	public static VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence) => QueueSubmit_0(queue, submitCount, submits, fence);
	public static bool QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence, out VkResult result)
	{
		result = QueueSubmit_0(queue, submitCount, submits, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult QueueSubmitDelegate_0(VkQueue queue, uint submitCount, VkSubmitInfo[] submits, VkFence fence);
	private static QueueSubmitDelegate_0 QueueSubmit_0;
	public static VkResult QueueWaitIdle(VkQueue queue) => QueueWaitIdle_0(queue);
	public static bool QueueWaitIdle(VkQueue queue, out VkResult result)
	{
		result = QueueWaitIdle_0(queue);
		return result == VkResult.Success;
	}
	private delegate VkResult QueueWaitIdleDelegate_0(VkQueue queue);
	private static QueueWaitIdleDelegate_0 QueueWaitIdle_0;
	public static VkResult DeviceWaitIdle(VkDevice device) => DeviceWaitIdle_0(device);
	public static bool DeviceWaitIdle(VkDevice device, out VkResult result)
	{
		result = DeviceWaitIdle_0(device);
		return result == VkResult.Success;
	}
	private delegate VkResult DeviceWaitIdleDelegate_0(VkDevice device);
	private static DeviceWaitIdleDelegate_0 DeviceWaitIdle_0;
	public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory) => AllocateMemory_0(device, allocateInfo, allocator, out memory);
	public static bool AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory, out VkResult result)
	{
		result = AllocateMemory_0(device, allocateInfo, allocator, out memory);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateMemoryDelegate_0(VkDevice device, VkMemoryAllocateInfo* allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_0 AllocateMemory_0;
	public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory) => AllocateMemory_1(device, allocateInfo, ref allocator, out memory);
	public static bool AllocateMemory(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory, out VkResult result)
	{
		result = AllocateMemory_1(device, allocateInfo, ref allocator, out memory);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateMemoryDelegate_1(VkDevice device, VkMemoryAllocateInfo* allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_1 AllocateMemory_1;
	public static VkResult AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory) => AllocateMemory_2(device, ref allocateInfo, allocator, out memory);
	public static bool AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory, out VkResult result)
	{
		result = AllocateMemory_2(device, ref allocateInfo, allocator, out memory);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateMemoryDelegate_2(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, VkAllocationCallbacks* allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_2 AllocateMemory_2;
	public static VkResult AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory) => AllocateMemory_3(device, ref allocateInfo, ref allocator, out memory);
	public static bool AllocateMemory(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory, out VkResult result)
	{
		result = AllocateMemory_3(device, ref allocateInfo, ref allocator, out memory);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateMemoryDelegate_3(VkDevice device, ref VkMemoryAllocateInfo allocateInfo, ref VkAllocationCallbacks allocator, out VkDeviceMemory memory);
	private static AllocateMemoryDelegate_3 AllocateMemory_3;
	public static void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* allocator) => FreeMemory_0(device, memory, allocator);
	private delegate void FreeMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* allocator);
	private static FreeMemoryDelegate_0 FreeMemory_0;
	public static void FreeMemory(VkDevice device, VkDeviceMemory memory, ref VkAllocationCallbacks allocator) => FreeMemory_1(device, memory, ref allocator);
	private delegate void FreeMemoryDelegate_1(VkDevice device, VkDeviceMemory memory, ref VkAllocationCallbacks allocator);
	private static FreeMemoryDelegate_1 FreeMemory_1;
	public static VkResult MapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** data) => MapMemory_0(device, memory, offset, size, flags, data);
	public static bool MapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** data, out VkResult result)
	{
		result = MapMemory_0(device, memory, offset, size, flags, data);
		return result == VkResult.Success;
	}
	private delegate VkResult MapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** data);
	private static MapMemoryDelegate_0 MapMemory_0;
	public static void UnmapMemory(VkDevice device, VkDeviceMemory memory) => UnmapMemory_0(device, memory);
	private delegate void UnmapMemoryDelegate_0(VkDevice device, VkDeviceMemory memory);
	private static UnmapMemoryDelegate_0 UnmapMemory_0;
	public static VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges) => FlushMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
	public static bool FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges, out VkResult result)
	{
		result = FlushMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
		return result == VkResult.Success;
	}
	private delegate VkResult FlushMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges);
	private static FlushMappedMemoryRangesDelegate_0 FlushMappedMemoryRanges_0;
	public static VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges) => InvalidateMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
	public static bool InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges, out VkResult result)
	{
		result = InvalidateMappedMemoryRanges_0(device, memoryRangeCount, memoryRanges);
		return result == VkResult.Success;
	}
	private delegate VkResult InvalidateMappedMemoryRangesDelegate_0(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange[] memoryRanges);
	private static InvalidateMappedMemoryRangesDelegate_0 InvalidateMappedMemoryRanges_0;
	public static void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, out VkDeviceSize committedMemoryInBytes) => GetDeviceMemoryCommitment_0(device, memory, out committedMemoryInBytes);
	private delegate void GetDeviceMemoryCommitmentDelegate_0(VkDevice device, VkDeviceMemory memory, out VkDeviceSize committedMemoryInBytes);
	private static GetDeviceMemoryCommitmentDelegate_0 GetDeviceMemoryCommitment_0;
	public static VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindBufferMemory_0(device, buffer, memory, memoryOffset);
	public static bool BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset, out VkResult result)
	{
		result = BindBufferMemory_0(device, buffer, memory, memoryOffset);
		return result == VkResult.Success;
	}
	private delegate VkResult BindBufferMemoryDelegate_0(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static BindBufferMemoryDelegate_0 BindBufferMemory_0;
	public static VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset) => BindImageMemory_0(device, image, memory, memoryOffset);
	public static bool BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset, out VkResult result)
	{
		result = BindImageMemory_0(device, image, memory, memoryOffset);
		return result == VkResult.Success;
	}
	private delegate VkResult BindImageMemoryDelegate_0(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset);
	private static BindImageMemoryDelegate_0 BindImageMemory_0;
	public static void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, out VkMemoryRequirements memoryRequirements) => GetBufferMemoryRequirements_0(device, buffer, out memoryRequirements);
	private delegate void GetBufferMemoryRequirementsDelegate_0(VkDevice device, VkBuffer buffer, out VkMemoryRequirements memoryRequirements);
	private static GetBufferMemoryRequirementsDelegate_0 GetBufferMemoryRequirements_0;
	public static void GetImageMemoryRequirements(VkDevice device, VkImage image, out VkMemoryRequirements memoryRequirements) => GetImageMemoryRequirements_0(device, image, out memoryRequirements);
	private delegate void GetImageMemoryRequirementsDelegate_0(VkDevice device, VkImage image, out VkMemoryRequirements memoryRequirements);
	private static GetImageMemoryRequirementsDelegate_0 GetImageMemoryRequirements_0;
	public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements_0(device, image, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirementsDelegate_0(VkDevice device, VkImage image, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirementsDelegate_0 GetImageSparseMemoryRequirements_0;
	public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements_1(device, image, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirementsDelegate_1(VkDevice device, VkImage image, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirementsDelegate_1 GetImageSparseMemoryRequirements_1;
	public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* propertyCount, [In, Out] VkSparseImageFormatProperties[] properties) => GetPhysicalDeviceSparseImageFormatProperties_0(physicalDevice, format, type, samples, usage, tiling, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* propertyCount, [In, Out] VkSparseImageFormatProperties[] properties);
	private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0 GetPhysicalDeviceSparseImageFormatProperties_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties[] properties) => GetPhysicalDeviceSparseImageFormatProperties_1(physicalDevice, format, type, samples, usage, tiling, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties[] properties);
	private static GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1 GetPhysicalDeviceSparseImageFormatProperties_1;
	public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence) => QueueBindSparse_0(queue, bindInfoCount, bindInfo, fence);
	public static bool QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence, out VkResult result)
	{
		result = QueueBindSparse_0(queue, bindInfoCount, bindInfo, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult QueueBindSparseDelegate_0(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* bindInfo, VkFence fence);
	private static QueueBindSparseDelegate_0 QueueBindSparse_0;
	public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence) => QueueBindSparse_1(queue, bindInfoCount, ref bindInfo, fence);
	public static bool QueueBindSparse(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence, out VkResult result)
	{
		result = QueueBindSparse_1(queue, bindInfoCount, ref bindInfo, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult QueueBindSparseDelegate_1(VkQueue queue, uint bindInfoCount, ref VkBindSparseInfo bindInfo, VkFence fence);
	private static QueueBindSparseDelegate_1 QueueBindSparse_1;
	public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence) => CreateFence_0(device, createInfo, allocator, out fence);
	public static bool CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence, out VkResult result)
	{
		result = CreateFence_0(device, createInfo, allocator, out fence);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFenceDelegate_0(VkDevice device, VkFenceCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFence fence);
	private static CreateFenceDelegate_0 CreateFence_0;
	public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence) => CreateFence_1(device, createInfo, ref allocator, out fence);
	public static bool CreateFence(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence, out VkResult result)
	{
		result = CreateFence_1(device, createInfo, ref allocator, out fence);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFenceDelegate_1(VkDevice device, VkFenceCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFence fence);
	private static CreateFenceDelegate_1 CreateFence_1;
	public static VkResult CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence) => CreateFence_2(device, ref createInfo, allocator, out fence);
	public static bool CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence, out VkResult result)
	{
		result = CreateFence_2(device, ref createInfo, allocator, out fence);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFenceDelegate_2(VkDevice device, ref VkFenceCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFence fence);
	private static CreateFenceDelegate_2 CreateFence_2;
	public static VkResult CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence) => CreateFence_3(device, ref createInfo, ref allocator, out fence);
	public static bool CreateFence(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence, out VkResult result)
	{
		result = CreateFence_3(device, ref createInfo, ref allocator, out fence);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFenceDelegate_3(VkDevice device, ref VkFenceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFence fence);
	private static CreateFenceDelegate_3 CreateFence_3;
	public static void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* allocator) => DestroyFence_0(device, fence, allocator);
	private delegate void DestroyFenceDelegate_0(VkDevice device, VkFence fence, VkAllocationCallbacks* allocator);
	private static DestroyFenceDelegate_0 DestroyFence_0;
	public static void DestroyFence(VkDevice device, VkFence fence, ref VkAllocationCallbacks allocator) => DestroyFence_1(device, fence, ref allocator);
	private delegate void DestroyFenceDelegate_1(VkDevice device, VkFence fence, ref VkAllocationCallbacks allocator);
	private static DestroyFenceDelegate_1 DestroyFence_1;
	public static VkResult ResetFences(VkDevice device, uint fenceCount, VkFence[] fences) => ResetFences_0(device, fenceCount, fences);
	public static bool ResetFences(VkDevice device, uint fenceCount, VkFence[] fences, out VkResult result)
	{
		result = ResetFences_0(device, fenceCount, fences);
		return result == VkResult.Success;
	}
	private delegate VkResult ResetFencesDelegate_0(VkDevice device, uint fenceCount, VkFence[] fences);
	private static ResetFencesDelegate_0 ResetFences_0;
	public static VkResult GetFenceStatus(VkDevice device, VkFence fence) => GetFenceStatus_0(device, fence);
	public static bool GetFenceStatus(VkDevice device, VkFence fence, out VkResult result)
	{
		result = GetFenceStatus_0(device, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult GetFenceStatusDelegate_0(VkDevice device, VkFence fence);
	private static GetFenceStatusDelegate_0 GetFenceStatus_0;
	public static VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout) => WaitForFences_0(device, fenceCount, fences, waitAll, timeout);
	public static bool WaitForFences(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout, out VkResult result)
	{
		result = WaitForFences_0(device, fenceCount, fences, waitAll, timeout);
		return result == VkResult.Success;
	}
	private delegate VkResult WaitForFencesDelegate_0(VkDevice device, uint fenceCount, VkFence[] fences, VkBool32 waitAll, ulong timeout);
	private static WaitForFencesDelegate_0 WaitForFences_0;
	public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore) => CreateSemaphore_0(device, createInfo, allocator, out semaphore);
	public static bool CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore, out VkResult result)
	{
		result = CreateSemaphore_0(device, createInfo, allocator, out semaphore);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSemaphoreDelegate_0(VkDevice device, VkSemaphoreCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_0 CreateSemaphore_0;
	public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore) => CreateSemaphore_1(device, createInfo, ref allocator, out semaphore);
	public static bool CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore, out VkResult result)
	{
		result = CreateSemaphore_1(device, createInfo, ref allocator, out semaphore);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSemaphoreDelegate_1(VkDevice device, VkSemaphoreCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_1 CreateSemaphore_1;
	public static VkResult CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore) => CreateSemaphore_2(device, ref createInfo, allocator, out semaphore);
	public static bool CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore, out VkResult result)
	{
		result = CreateSemaphore_2(device, ref createInfo, allocator, out semaphore);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSemaphoreDelegate_2(VkDevice device, ref VkSemaphoreCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_2 CreateSemaphore_2;
	public static VkResult CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore) => CreateSemaphore_3(device, ref createInfo, ref allocator, out semaphore);
	public static bool CreateSemaphore(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore, out VkResult result)
	{
		result = CreateSemaphore_3(device, ref createInfo, ref allocator, out semaphore);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSemaphoreDelegate_3(VkDevice device, ref VkSemaphoreCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSemaphore semaphore);
	private static CreateSemaphoreDelegate_3 CreateSemaphore_3;
	public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* allocator) => DestroySemaphore_0(device, semaphore, allocator);
	private delegate void DestroySemaphoreDelegate_0(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* allocator);
	private static DestroySemaphoreDelegate_0 DestroySemaphore_0;
	public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, ref VkAllocationCallbacks allocator) => DestroySemaphore_1(device, semaphore, ref allocator);
	private delegate void DestroySemaphoreDelegate_1(VkDevice device, VkSemaphore semaphore, ref VkAllocationCallbacks allocator);
	private static DestroySemaphoreDelegate_1 DestroySemaphore_1;
	public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event) => CreateEvent_0(device, createInfo, allocator, out @event);
	public static bool CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event, out VkResult result)
	{
		result = CreateEvent_0(device, createInfo, allocator, out @event);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateEventDelegate_0(VkDevice device, VkEventCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkEvent @event);
	private static CreateEventDelegate_0 CreateEvent_0;
	public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event) => CreateEvent_1(device, createInfo, ref allocator, out @event);
	public static bool CreateEvent(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event, out VkResult result)
	{
		result = CreateEvent_1(device, createInfo, ref allocator, out @event);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateEventDelegate_1(VkDevice device, VkEventCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event);
	private static CreateEventDelegate_1 CreateEvent_1;
	public static VkResult CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event) => CreateEvent_2(device, ref createInfo, allocator, out @event);
	public static bool CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event, out VkResult result)
	{
		result = CreateEvent_2(device, ref createInfo, allocator, out @event);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateEventDelegate_2(VkDevice device, ref VkEventCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkEvent @event);
	private static CreateEventDelegate_2 CreateEvent_2;
	public static VkResult CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event) => CreateEvent_3(device, ref createInfo, ref allocator, out @event);
	public static bool CreateEvent(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event, out VkResult result)
	{
		result = CreateEvent_3(device, ref createInfo, ref allocator, out @event);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateEventDelegate_3(VkDevice device, ref VkEventCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkEvent @event);
	private static CreateEventDelegate_3 CreateEvent_3;
	public static void DestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* allocator) => DestroyEvent_0(device, @event, allocator);
	private delegate void DestroyEventDelegate_0(VkDevice device, VkEvent @event, VkAllocationCallbacks* allocator);
	private static DestroyEventDelegate_0 DestroyEvent_0;
	public static void DestroyEvent(VkDevice device, VkEvent @event, ref VkAllocationCallbacks allocator) => DestroyEvent_1(device, @event, ref allocator);
	private delegate void DestroyEventDelegate_1(VkDevice device, VkEvent @event, ref VkAllocationCallbacks allocator);
	private static DestroyEventDelegate_1 DestroyEvent_1;
	public static VkResult GetEventStatus(VkDevice device, VkEvent @event) => GetEventStatus_0(device, @event);
	public static bool GetEventStatus(VkDevice device, VkEvent @event, out VkResult result)
	{
		result = GetEventStatus_0(device, @event);
		return result == VkResult.Success;
	}
	private delegate VkResult GetEventStatusDelegate_0(VkDevice device, VkEvent @event);
	private static GetEventStatusDelegate_0 GetEventStatus_0;
	public static VkResult SetEvent(VkDevice device, VkEvent @event) => SetEvent_0(device, @event);
	public static bool SetEvent(VkDevice device, VkEvent @event, out VkResult result)
	{
		result = SetEvent_0(device, @event);
		return result == VkResult.Success;
	}
	private delegate VkResult SetEventDelegate_0(VkDevice device, VkEvent @event);
	private static SetEventDelegate_0 SetEvent_0;
	public static VkResult ResetEvent(VkDevice device, VkEvent @event) => ResetEvent_0(device, @event);
	public static bool ResetEvent(VkDevice device, VkEvent @event, out VkResult result)
	{
		result = ResetEvent_0(device, @event);
		return result == VkResult.Success;
	}
	private delegate VkResult ResetEventDelegate_0(VkDevice device, VkEvent @event);
	private static ResetEventDelegate_0 ResetEvent_0;
	public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool) => CreateQueryPool_0(device, createInfo, allocator, out queryPool);
	public static bool CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool, out VkResult result)
	{
		result = CreateQueryPool_0(device, createInfo, allocator, out queryPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateQueryPoolDelegate_0(VkDevice device, VkQueryPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_0 CreateQueryPool_0;
	public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool) => CreateQueryPool_1(device, createInfo, ref allocator, out queryPool);
	public static bool CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool, out VkResult result)
	{
		result = CreateQueryPool_1(device, createInfo, ref allocator, out queryPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateQueryPoolDelegate_1(VkDevice device, VkQueryPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_1 CreateQueryPool_1;
	public static VkResult CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool) => CreateQueryPool_2(device, ref createInfo, allocator, out queryPool);
	public static bool CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool, out VkResult result)
	{
		result = CreateQueryPool_2(device, ref createInfo, allocator, out queryPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateQueryPoolDelegate_2(VkDevice device, ref VkQueryPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_2 CreateQueryPool_2;
	public static VkResult CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool) => CreateQueryPool_3(device, ref createInfo, ref allocator, out queryPool);
	public static bool CreateQueryPool(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool, out VkResult result)
	{
		result = CreateQueryPool_3(device, ref createInfo, ref allocator, out queryPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateQueryPoolDelegate_3(VkDevice device, ref VkQueryPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkQueryPool queryPool);
	private static CreateQueryPoolDelegate_3 CreateQueryPool_3;
	public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* allocator) => DestroyQueryPool_0(device, queryPool, allocator);
	private delegate void DestroyQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* allocator);
	private static DestroyQueryPoolDelegate_0 DestroyQueryPool_0;
	public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, ref VkAllocationCallbacks allocator) => DestroyQueryPool_1(device, queryPool, ref allocator);
	private delegate void DestroyQueryPoolDelegate_1(VkDevice device, VkQueryPool queryPool, ref VkAllocationCallbacks allocator);
	private static DestroyQueryPoolDelegate_1 DestroyQueryPool_1;
	public static VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags) => GetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, data, stride, flags);
	public static bool GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags, out VkResult result)
	{
		result = GetQueryPoolResults_0(device, queryPool, firstQuery, queryCount, dataSize, data, stride, flags);
		return result == VkResult.Success;
	}
	private delegate VkResult GetQueryPoolResultsDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* data, VkDeviceSize stride, VkQueryResultFlags flags);
	private static GetQueryPoolResultsDelegate_0 GetQueryPoolResults_0;
	public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer) => CreateBuffer_0(device, createInfo, allocator, out buffer);
	public static bool CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer, out VkResult result)
	{
		result = CreateBuffer_0(device, createInfo, allocator, out buffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferDelegate_0(VkDevice device, VkBufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_0 CreateBuffer_0;
	public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer) => CreateBuffer_1(device, createInfo, ref allocator, out buffer);
	public static bool CreateBuffer(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer, out VkResult result)
	{
		result = CreateBuffer_1(device, createInfo, ref allocator, out buffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferDelegate_1(VkDevice device, VkBufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_1 CreateBuffer_1;
	public static VkResult CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer) => CreateBuffer_2(device, ref createInfo, allocator, out buffer);
	public static bool CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer, out VkResult result)
	{
		result = CreateBuffer_2(device, ref createInfo, allocator, out buffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferDelegate_2(VkDevice device, ref VkBufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_2 CreateBuffer_2;
	public static VkResult CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer) => CreateBuffer_3(device, ref createInfo, ref allocator, out buffer);
	public static bool CreateBuffer(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer, out VkResult result)
	{
		result = CreateBuffer_3(device, ref createInfo, ref allocator, out buffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferDelegate_3(VkDevice device, ref VkBufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBuffer buffer);
	private static CreateBufferDelegate_3 CreateBuffer_3;
	public static void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* allocator) => DestroyBuffer_0(device, buffer, allocator);
	private delegate void DestroyBufferDelegate_0(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* allocator);
	private static DestroyBufferDelegate_0 DestroyBuffer_0;
	public static void DestroyBuffer(VkDevice device, VkBuffer buffer, ref VkAllocationCallbacks allocator) => DestroyBuffer_1(device, buffer, ref allocator);
	private delegate void DestroyBufferDelegate_1(VkDevice device, VkBuffer buffer, ref VkAllocationCallbacks allocator);
	private static DestroyBufferDelegate_1 DestroyBuffer_1;
	public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view) => CreateBufferView_0(device, createInfo, allocator, out view);
	public static bool CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view, out VkResult result)
	{
		result = CreateBufferView_0(device, createInfo, allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferViewDelegate_0(VkDevice device, VkBufferViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_0 CreateBufferView_0;
	public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view) => CreateBufferView_1(device, createInfo, ref allocator, out view);
	public static bool CreateBufferView(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view, out VkResult result)
	{
		result = CreateBufferView_1(device, createInfo, ref allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferViewDelegate_1(VkDevice device, VkBufferViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_1 CreateBufferView_1;
	public static VkResult CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view) => CreateBufferView_2(device, ref createInfo, allocator, out view);
	public static bool CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view, out VkResult result)
	{
		result = CreateBufferView_2(device, ref createInfo, allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferViewDelegate_2(VkDevice device, ref VkBufferViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_2 CreateBufferView_2;
	public static VkResult CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view) => CreateBufferView_3(device, ref createInfo, ref allocator, out view);
	public static bool CreateBufferView(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view, out VkResult result)
	{
		result = CreateBufferView_3(device, ref createInfo, ref allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateBufferViewDelegate_3(VkDevice device, ref VkBufferViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkBufferView view);
	private static CreateBufferViewDelegate_3 CreateBufferView_3;
	public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* allocator) => DestroyBufferView_0(device, bufferView, allocator);
	private delegate void DestroyBufferViewDelegate_0(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* allocator);
	private static DestroyBufferViewDelegate_0 DestroyBufferView_0;
	public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, ref VkAllocationCallbacks allocator) => DestroyBufferView_1(device, bufferView, ref allocator);
	private delegate void DestroyBufferViewDelegate_1(VkDevice device, VkBufferView bufferView, ref VkAllocationCallbacks allocator);
	private static DestroyBufferViewDelegate_1 DestroyBufferView_1;
	public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image) => CreateImage_0(device, createInfo, allocator, out image);
	public static bool CreateImage(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image, out VkResult result)
	{
		result = CreateImage_0(device, createInfo, allocator, out image);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageDelegate_0(VkDevice device, VkImageCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImage image);
	private static CreateImageDelegate_0 CreateImage_0;
	public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image) => CreateImage_1(device, createInfo, ref allocator, out image);
	public static bool CreateImage(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image, out VkResult result)
	{
		result = CreateImage_1(device, createInfo, ref allocator, out image);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageDelegate_1(VkDevice device, VkImageCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImage image);
	private static CreateImageDelegate_1 CreateImage_1;
	public static VkResult CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image) => CreateImage_2(device, ref createInfo, allocator, out image);
	public static bool CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image, out VkResult result)
	{
		result = CreateImage_2(device, ref createInfo, allocator, out image);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageDelegate_2(VkDevice device, ref VkImageCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImage image);
	private static CreateImageDelegate_2 CreateImage_2;
	public static VkResult CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image) => CreateImage_3(device, ref createInfo, ref allocator, out image);
	public static bool CreateImage(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image, out VkResult result)
	{
		result = CreateImage_3(device, ref createInfo, ref allocator, out image);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageDelegate_3(VkDevice device, ref VkImageCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImage image);
	private static CreateImageDelegate_3 CreateImage_3;
	public static void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* allocator) => DestroyImage_0(device, image, allocator);
	private delegate void DestroyImageDelegate_0(VkDevice device, VkImage image, VkAllocationCallbacks* allocator);
	private static DestroyImageDelegate_0 DestroyImage_0;
	public static void DestroyImage(VkDevice device, VkImage image, ref VkAllocationCallbacks allocator) => DestroyImage_1(device, image, ref allocator);
	private delegate void DestroyImageDelegate_1(VkDevice device, VkImage image, ref VkAllocationCallbacks allocator);
	private static DestroyImageDelegate_1 DestroyImage_1;
	public static void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* subresource, out VkSubresourceLayout layout) => GetImageSubresourceLayout_0(device, image, subresource, out layout);
	private delegate void GetImageSubresourceLayoutDelegate_0(VkDevice device, VkImage image, VkImageSubresource* subresource, out VkSubresourceLayout layout);
	private static GetImageSubresourceLayoutDelegate_0 GetImageSubresourceLayout_0;
	public static void GetImageSubresourceLayout(VkDevice device, VkImage image, ref VkImageSubresource subresource, out VkSubresourceLayout layout) => GetImageSubresourceLayout_1(device, image, ref subresource, out layout);
	private delegate void GetImageSubresourceLayoutDelegate_1(VkDevice device, VkImage image, ref VkImageSubresource subresource, out VkSubresourceLayout layout);
	private static GetImageSubresourceLayoutDelegate_1 GetImageSubresourceLayout_1;
	public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view) => CreateImageView_0(device, createInfo, allocator, out view);
	public static bool CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view, out VkResult result)
	{
		result = CreateImageView_0(device, createInfo, allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageViewDelegate_0(VkDevice device, VkImageViewCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkImageView view);
	private static CreateImageViewDelegate_0 CreateImageView_0;
	public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view) => CreateImageView_1(device, createInfo, ref allocator, out view);
	public static bool CreateImageView(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view, out VkResult result)
	{
		result = CreateImageView_1(device, createInfo, ref allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageViewDelegate_1(VkDevice device, VkImageViewCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkImageView view);
	private static CreateImageViewDelegate_1 CreateImageView_1;
	public static VkResult CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view) => CreateImageView_2(device, ref createInfo, allocator, out view);
	public static bool CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view, out VkResult result)
	{
		result = CreateImageView_2(device, ref createInfo, allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageViewDelegate_2(VkDevice device, ref VkImageViewCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkImageView view);
	private static CreateImageViewDelegate_2 CreateImageView_2;
	public static VkResult CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view) => CreateImageView_3(device, ref createInfo, ref allocator, out view);
	public static bool CreateImageView(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view, out VkResult result)
	{
		result = CreateImageView_3(device, ref createInfo, ref allocator, out view);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateImageViewDelegate_3(VkDevice device, ref VkImageViewCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkImageView view);
	private static CreateImageViewDelegate_3 CreateImageView_3;
	public static void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* allocator) => DestroyImageView_0(device, imageView, allocator);
	private delegate void DestroyImageViewDelegate_0(VkDevice device, VkImageView imageView, VkAllocationCallbacks* allocator);
	private static DestroyImageViewDelegate_0 DestroyImageView_0;
	public static void DestroyImageView(VkDevice device, VkImageView imageView, ref VkAllocationCallbacks allocator) => DestroyImageView_1(device, imageView, ref allocator);
	private delegate void DestroyImageViewDelegate_1(VkDevice device, VkImageView imageView, ref VkAllocationCallbacks allocator);
	private static DestroyImageViewDelegate_1 DestroyImageView_1;
	public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule) => CreateShaderModule_0(device, createInfo, allocator, out shaderModule);
	public static bool CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule, out VkResult result)
	{
		result = CreateShaderModule_0(device, createInfo, allocator, out shaderModule);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateShaderModuleDelegate_0(VkDevice device, VkShaderModuleCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_0 CreateShaderModule_0;
	public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule) => CreateShaderModule_1(device, createInfo, ref allocator, out shaderModule);
	public static bool CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule, out VkResult result)
	{
		result = CreateShaderModule_1(device, createInfo, ref allocator, out shaderModule);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateShaderModuleDelegate_1(VkDevice device, VkShaderModuleCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_1 CreateShaderModule_1;
	public static VkResult CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule) => CreateShaderModule_2(device, ref createInfo, allocator, out shaderModule);
	public static bool CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule, out VkResult result)
	{
		result = CreateShaderModule_2(device, ref createInfo, allocator, out shaderModule);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateShaderModuleDelegate_2(VkDevice device, ref VkShaderModuleCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_2 CreateShaderModule_2;
	public static VkResult CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule) => CreateShaderModule_3(device, ref createInfo, ref allocator, out shaderModule);
	public static bool CreateShaderModule(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule, out VkResult result)
	{
		result = CreateShaderModule_3(device, ref createInfo, ref allocator, out shaderModule);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateShaderModuleDelegate_3(VkDevice device, ref VkShaderModuleCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkShaderModule shaderModule);
	private static CreateShaderModuleDelegate_3 CreateShaderModule_3;
	public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* allocator) => DestroyShaderModule_0(device, shaderModule, allocator);
	private delegate void DestroyShaderModuleDelegate_0(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* allocator);
	private static DestroyShaderModuleDelegate_0 DestroyShaderModule_0;
	public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, ref VkAllocationCallbacks allocator) => DestroyShaderModule_1(device, shaderModule, ref allocator);
	private delegate void DestroyShaderModuleDelegate_1(VkDevice device, VkShaderModule shaderModule, ref VkAllocationCallbacks allocator);
	private static DestroyShaderModuleDelegate_1 DestroyShaderModule_1;
	public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_0(device, createInfo, allocator, out pipelineCache);
	public static bool CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache, out VkResult result)
	{
		result = CreatePipelineCache_0(device, createInfo, allocator, out pipelineCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineCacheDelegate_0(VkDevice device, VkPipelineCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_0 CreatePipelineCache_0;
	public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_1(device, createInfo, ref allocator, out pipelineCache);
	public static bool CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache, out VkResult result)
	{
		result = CreatePipelineCache_1(device, createInfo, ref allocator, out pipelineCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineCacheDelegate_1(VkDevice device, VkPipelineCacheCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_1 CreatePipelineCache_1;
	public static VkResult CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_2(device, ref createInfo, allocator, out pipelineCache);
	public static bool CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache, out VkResult result)
	{
		result = CreatePipelineCache_2(device, ref createInfo, allocator, out pipelineCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineCacheDelegate_2(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_2 CreatePipelineCache_2;
	public static VkResult CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache) => CreatePipelineCache_3(device, ref createInfo, ref allocator, out pipelineCache);
	public static bool CreatePipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache, out VkResult result)
	{
		result = CreatePipelineCache_3(device, ref createInfo, ref allocator, out pipelineCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineCacheDelegate_3(VkDevice device, ref VkPipelineCacheCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineCache pipelineCache);
	private static CreatePipelineCacheDelegate_3 CreatePipelineCache_3;
	public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* allocator) => DestroyPipelineCache_0(device, pipelineCache, allocator);
	private delegate void DestroyPipelineCacheDelegate_0(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* allocator);
	private static DestroyPipelineCacheDelegate_0 DestroyPipelineCache_0;
	public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, ref VkAllocationCallbacks allocator) => DestroyPipelineCache_1(device, pipelineCache, ref allocator);
	private delegate void DestroyPipelineCacheDelegate_1(VkDevice device, VkPipelineCache pipelineCache, ref VkAllocationCallbacks allocator);
	private static DestroyPipelineCacheDelegate_1 DestroyPipelineCache_1;
	public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data) => GetPipelineCacheData_0(device, pipelineCache, dataSize, data);
	public static bool GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data, out VkResult result)
	{
		result = GetPipelineCacheData_0(device, pipelineCache, dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineCacheDataDelegate_0(VkDevice device, VkPipelineCache pipelineCache, nuint* dataSize, void* data);
	private static GetPipelineCacheDataDelegate_0 GetPipelineCacheData_0;
	public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data) => GetPipelineCacheData_1(device, pipelineCache, ref dataSize, data);
	public static bool GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data, out VkResult result)
	{
		result = GetPipelineCacheData_1(device, pipelineCache, ref dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineCacheDataDelegate_1(VkDevice device, VkPipelineCache pipelineCache, ref nuint dataSize, void* data);
	private static GetPipelineCacheDataDelegate_1 GetPipelineCacheData_1;
	public static VkResult MergePipelineCaches(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches) => MergePipelineCaches_0(device, destinationCache, sourceCacheCount, sourceCaches);
	public static bool MergePipelineCaches(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches, out VkResult result)
	{
		result = MergePipelineCaches_0(device, destinationCache, sourceCacheCount, sourceCaches);
		return result == VkResult.Success;
	}
	private delegate VkResult MergePipelineCachesDelegate_0(VkDevice device, VkPipelineCache destinationCache, uint sourceCacheCount, VkPipelineCache[] sourceCaches);
	private static MergePipelineCachesDelegate_0 MergePipelineCaches_0;
	public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
	public static bool CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateGraphicsPipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateGraphicsPipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
	private static CreateGraphicsPipelinesDelegate_0 CreateGraphicsPipelines_0;
	public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateGraphicsPipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
	public static bool CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateGraphicsPipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateGraphicsPipelinesDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
	private static CreateGraphicsPipelinesDelegate_1 CreateGraphicsPipelines_1;
	public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateComputePipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
	public static bool CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateComputePipelines_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateComputePipelinesDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
	private static CreateComputePipelinesDelegate_0 CreateComputePipelines_0;
	public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateComputePipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
	public static bool CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateComputePipelines_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateComputePipelinesDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
	private static CreateComputePipelinesDelegate_1 CreateComputePipelines_1;
	public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* allocator) => DestroyPipeline_0(device, pipeline, allocator);
	private delegate void DestroyPipelineDelegate_0(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* allocator);
	private static DestroyPipelineDelegate_0 DestroyPipeline_0;
	public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, ref VkAllocationCallbacks allocator) => DestroyPipeline_1(device, pipeline, ref allocator);
	private delegate void DestroyPipelineDelegate_1(VkDevice device, VkPipeline pipeline, ref VkAllocationCallbacks allocator);
	private static DestroyPipelineDelegate_1 DestroyPipeline_1;
	public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_0(device, createInfo, allocator, out pipelineLayout);
	public static bool CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout, out VkResult result)
	{
		result = CreatePipelineLayout_0(device, createInfo, allocator, out pipelineLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineLayoutDelegate_0(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_0 CreatePipelineLayout_0;
	public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_1(device, createInfo, ref allocator, out pipelineLayout);
	public static bool CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout, out VkResult result)
	{
		result = CreatePipelineLayout_1(device, createInfo, ref allocator, out pipelineLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineLayoutDelegate_1(VkDevice device, VkPipelineLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_1 CreatePipelineLayout_1;
	public static VkResult CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_2(device, ref createInfo, allocator, out pipelineLayout);
	public static bool CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout, out VkResult result)
	{
		result = CreatePipelineLayout_2(device, ref createInfo, allocator, out pipelineLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineLayoutDelegate_2(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_2 CreatePipelineLayout_2;
	public static VkResult CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout) => CreatePipelineLayout_3(device, ref createInfo, ref allocator, out pipelineLayout);
	public static bool CreatePipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout, out VkResult result)
	{
		result = CreatePipelineLayout_3(device, ref createInfo, ref allocator, out pipelineLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePipelineLayoutDelegate_3(VkDevice device, ref VkPipelineLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkPipelineLayout pipelineLayout);
	private static CreatePipelineLayoutDelegate_3 CreatePipelineLayout_3;
	public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* allocator) => DestroyPipelineLayout_0(device, pipelineLayout, allocator);
	private delegate void DestroyPipelineLayoutDelegate_0(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* allocator);
	private static DestroyPipelineLayoutDelegate_0 DestroyPipelineLayout_0;
	public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, ref VkAllocationCallbacks allocator) => DestroyPipelineLayout_1(device, pipelineLayout, ref allocator);
	private delegate void DestroyPipelineLayoutDelegate_1(VkDevice device, VkPipelineLayout pipelineLayout, ref VkAllocationCallbacks allocator);
	private static DestroyPipelineLayoutDelegate_1 DestroyPipelineLayout_1;
	public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler) => CreateSampler_0(device, createInfo, allocator, out sampler);
	public static bool CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler, out VkResult result)
	{
		result = CreateSampler_0(device, createInfo, allocator, out sampler);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerDelegate_0(VkDevice device, VkSamplerCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_0 CreateSampler_0;
	public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler) => CreateSampler_1(device, createInfo, ref allocator, out sampler);
	public static bool CreateSampler(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler, out VkResult result)
	{
		result = CreateSampler_1(device, createInfo, ref allocator, out sampler);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerDelegate_1(VkDevice device, VkSamplerCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_1 CreateSampler_1;
	public static VkResult CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler) => CreateSampler_2(device, ref createInfo, allocator, out sampler);
	public static bool CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler, out VkResult result)
	{
		result = CreateSampler_2(device, ref createInfo, allocator, out sampler);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerDelegate_2(VkDevice device, ref VkSamplerCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_2 CreateSampler_2;
	public static VkResult CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler) => CreateSampler_3(device, ref createInfo, ref allocator, out sampler);
	public static bool CreateSampler(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler, out VkResult result)
	{
		result = CreateSampler_3(device, ref createInfo, ref allocator, out sampler);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerDelegate_3(VkDevice device, ref VkSamplerCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSampler sampler);
	private static CreateSamplerDelegate_3 CreateSampler_3;
	public static void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* allocator) => DestroySampler_0(device, sampler, allocator);
	private delegate void DestroySamplerDelegate_0(VkDevice device, VkSampler sampler, VkAllocationCallbacks* allocator);
	private static DestroySamplerDelegate_0 DestroySampler_0;
	public static void DestroySampler(VkDevice device, VkSampler sampler, ref VkAllocationCallbacks allocator) => DestroySampler_1(device, sampler, ref allocator);
	private delegate void DestroySamplerDelegate_1(VkDevice device, VkSampler sampler, ref VkAllocationCallbacks allocator);
	private static DestroySamplerDelegate_1 DestroySampler_1;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_0(device, createInfo, allocator, out setLayout);
	public static bool CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout, out VkResult result)
	{
		result = CreateDescriptorSetLayout_0(device, createInfo, allocator, out setLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_0 CreateDescriptorSetLayout_0;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_1(device, createInfo, ref allocator, out setLayout);
	public static bool CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout, out VkResult result)
	{
		result = CreateDescriptorSetLayout_1(device, createInfo, ref allocator, out setLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorSetLayoutDelegate_1(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_1 CreateDescriptorSetLayout_1;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_2(device, ref createInfo, allocator, out setLayout);
	public static bool CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout, out VkResult result)
	{
		result = CreateDescriptorSetLayout_2(device, ref createInfo, allocator, out setLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorSetLayoutDelegate_2(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_2 CreateDescriptorSetLayout_2;
	public static VkResult CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout) => CreateDescriptorSetLayout_3(device, ref createInfo, ref allocator, out setLayout);
	public static bool CreateDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout, out VkResult result)
	{
		result = CreateDescriptorSetLayout_3(device, ref createInfo, ref allocator, out setLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorSetLayoutDelegate_3(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorSetLayout setLayout);
	private static CreateDescriptorSetLayoutDelegate_3 CreateDescriptorSetLayout_3;
	public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* allocator) => DestroyDescriptorSetLayout_0(device, descriptorSetLayout, allocator);
	private delegate void DestroyDescriptorSetLayoutDelegate_0(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorSetLayoutDelegate_0 DestroyDescriptorSetLayout_0;
	public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, ref VkAllocationCallbacks allocator) => DestroyDescriptorSetLayout_1(device, descriptorSetLayout, ref allocator);
	private delegate void DestroyDescriptorSetLayoutDelegate_1(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorSetLayoutDelegate_1 DestroyDescriptorSetLayout_1;
	public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_0(device, createInfo, allocator, out descriptorPool);
	public static bool CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool, out VkResult result)
	{
		result = CreateDescriptorPool_0(device, createInfo, allocator, out descriptorPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_0 CreateDescriptorPool_0;
	public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_1(device, createInfo, ref allocator, out descriptorPool);
	public static bool CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool, out VkResult result)
	{
		result = CreateDescriptorPool_1(device, createInfo, ref allocator, out descriptorPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorPoolDelegate_1(VkDevice device, VkDescriptorPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_1 CreateDescriptorPool_1;
	public static VkResult CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_2(device, ref createInfo, allocator, out descriptorPool);
	public static bool CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool, out VkResult result)
	{
		result = CreateDescriptorPool_2(device, ref createInfo, allocator, out descriptorPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorPoolDelegate_2(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_2 CreateDescriptorPool_2;
	public static VkResult CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool) => CreateDescriptorPool_3(device, ref createInfo, ref allocator, out descriptorPool);
	public static bool CreateDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool, out VkResult result)
	{
		result = CreateDescriptorPool_3(device, ref createInfo, ref allocator, out descriptorPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorPoolDelegate_3(VkDevice device, ref VkDescriptorPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorPool descriptorPool);
	private static CreateDescriptorPoolDelegate_3 CreateDescriptorPool_3;
	public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* allocator) => DestroyDescriptorPool_0(device, descriptorPool, allocator);
	private delegate void DestroyDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorPoolDelegate_0 DestroyDescriptorPool_0;
	public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, ref VkAllocationCallbacks allocator) => DestroyDescriptorPool_1(device, descriptorPool, ref allocator);
	private delegate void DestroyDescriptorPoolDelegate_1(VkDevice device, VkDescriptorPool descriptorPool, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorPoolDelegate_1 DestroyDescriptorPool_1;
	public static VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags) => ResetDescriptorPool_0(device, descriptorPool, flags);
	public static bool ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags, out VkResult result)
	{
		result = ResetDescriptorPool_0(device, descriptorPool, flags);
		return result == VkResult.Success;
	}
	private delegate VkResult ResetDescriptorPoolDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);
	private static ResetDescriptorPoolDelegate_0 ResetDescriptorPool_0;
	public static VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets) => AllocateDescriptorSets_0(device, allocateInfo, descriptorSets);
	public static bool AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets, out VkResult result)
	{
		result = AllocateDescriptorSets_0(device, allocateInfo, descriptorSets);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateDescriptorSetsDelegate_0(VkDevice device, VkDescriptorSetAllocateInfo* allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets);
	private static AllocateDescriptorSetsDelegate_0 AllocateDescriptorSets_0;
	public static VkResult AllocateDescriptorSets(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets) => AllocateDescriptorSets_1(device, ref allocateInfo, descriptorSets);
	public static bool AllocateDescriptorSets(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets, out VkResult result)
	{
		result = AllocateDescriptorSets_1(device, ref allocateInfo, descriptorSets);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateDescriptorSetsDelegate_1(VkDevice device, ref VkDescriptorSetAllocateInfo allocateInfo, [In, Out] VkDescriptorSet[] descriptorSets);
	private static AllocateDescriptorSetsDelegate_1 AllocateDescriptorSets_1;
	public static VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets) => FreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, descriptorSets);
	public static bool FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, out VkResult result)
	{
		result = FreeDescriptorSets_0(device, descriptorPool, descriptorSetCount, descriptorSets);
		return result == VkResult.Success;
	}
	private delegate VkResult FreeDescriptorSetsDelegate_0(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet[] descriptorSets);
	private static FreeDescriptorSetsDelegate_0 FreeDescriptorSets_0;
	public static void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet[] descriptorCopies) => UpdateDescriptorSets_0(device, descriptorWriteCount, descriptorWrites, descriptorCopyCount, descriptorCopies);
	private delegate void UpdateDescriptorSetsDelegate_0(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet[] descriptorCopies);
	private static UpdateDescriptorSetsDelegate_0 UpdateDescriptorSets_0;
	public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_0(device, createInfo, allocator, out framebuffer);
	public static bool CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer, out VkResult result)
	{
		result = CreateFramebuffer_0(device, createInfo, allocator, out framebuffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFramebufferDelegate_0(VkDevice device, VkFramebufferCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_0 CreateFramebuffer_0;
	public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_1(device, createInfo, ref allocator, out framebuffer);
	public static bool CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer, out VkResult result)
	{
		result = CreateFramebuffer_1(device, createInfo, ref allocator, out framebuffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFramebufferDelegate_1(VkDevice device, VkFramebufferCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_1 CreateFramebuffer_1;
	public static VkResult CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_2(device, ref createInfo, allocator, out framebuffer);
	public static bool CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer, out VkResult result)
	{
		result = CreateFramebuffer_2(device, ref createInfo, allocator, out framebuffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFramebufferDelegate_2(VkDevice device, ref VkFramebufferCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_2 CreateFramebuffer_2;
	public static VkResult CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer) => CreateFramebuffer_3(device, ref createInfo, ref allocator, out framebuffer);
	public static bool CreateFramebuffer(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer, out VkResult result)
	{
		result = CreateFramebuffer_3(device, ref createInfo, ref allocator, out framebuffer);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateFramebufferDelegate_3(VkDevice device, ref VkFramebufferCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkFramebuffer framebuffer);
	private static CreateFramebufferDelegate_3 CreateFramebuffer_3;
	public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* allocator) => DestroyFramebuffer_0(device, framebuffer, allocator);
	private delegate void DestroyFramebufferDelegate_0(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* allocator);
	private static DestroyFramebufferDelegate_0 DestroyFramebuffer_0;
	public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, ref VkAllocationCallbacks allocator) => DestroyFramebuffer_1(device, framebuffer, ref allocator);
	private delegate void DestroyFramebufferDelegate_1(VkDevice device, VkFramebuffer framebuffer, ref VkAllocationCallbacks allocator);
	private static DestroyFramebufferDelegate_1 DestroyFramebuffer_1;
	public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass_0(device, createInfo, allocator, out renderPass);
	public static bool CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass_0(device, createInfo, allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPassDelegate_0(VkDevice device, VkRenderPassCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_0 CreateRenderPass_0;
	public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass_1(device, createInfo, ref allocator, out renderPass);
	public static bool CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass_1(device, createInfo, ref allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPassDelegate_1(VkDevice device, VkRenderPassCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_1 CreateRenderPass_1;
	public static VkResult CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass_2(device, ref createInfo, allocator, out renderPass);
	public static bool CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass_2(device, ref createInfo, allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPassDelegate_2(VkDevice device, ref VkRenderPassCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_2 CreateRenderPass_2;
	public static VkResult CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass_3(device, ref createInfo, ref allocator, out renderPass);
	public static bool CreateRenderPass(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass_3(device, ref createInfo, ref allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPassDelegate_3(VkDevice device, ref VkRenderPassCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPassDelegate_3 CreateRenderPass_3;
	public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* allocator) => DestroyRenderPass_0(device, renderPass, allocator);
	private delegate void DestroyRenderPassDelegate_0(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* allocator);
	private static DestroyRenderPassDelegate_0 DestroyRenderPass_0;
	public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, ref VkAllocationCallbacks allocator) => DestroyRenderPass_1(device, renderPass, ref allocator);
	private delegate void DestroyRenderPassDelegate_1(VkDevice device, VkRenderPass renderPass, ref VkAllocationCallbacks allocator);
	private static DestroyRenderPassDelegate_1 DestroyRenderPass_1;
	public static void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, out VkExtent2D granularity) => GetRenderAreaGranularity_0(device, renderPass, out granularity);
	private delegate void GetRenderAreaGranularityDelegate_0(VkDevice device, VkRenderPass renderPass, out VkExtent2D granularity);
	private static GetRenderAreaGranularityDelegate_0 GetRenderAreaGranularity_0;
	public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool) => CreateCommandPool_0(device, createInfo, allocator, out commandPool);
	public static bool CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool, out VkResult result)
	{
		result = CreateCommandPool_0(device, createInfo, allocator, out commandPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCommandPoolDelegate_0(VkDevice device, VkCommandPoolCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_0 CreateCommandPool_0;
	public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool) => CreateCommandPool_1(device, createInfo, ref allocator, out commandPool);
	public static bool CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool, out VkResult result)
	{
		result = CreateCommandPool_1(device, createInfo, ref allocator, out commandPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCommandPoolDelegate_1(VkDevice device, VkCommandPoolCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_1 CreateCommandPool_1;
	public static VkResult CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool) => CreateCommandPool_2(device, ref createInfo, allocator, out commandPool);
	public static bool CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool, out VkResult result)
	{
		result = CreateCommandPool_2(device, ref createInfo, allocator, out commandPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCommandPoolDelegate_2(VkDevice device, ref VkCommandPoolCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_2 CreateCommandPool_2;
	public static VkResult CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool) => CreateCommandPool_3(device, ref createInfo, ref allocator, out commandPool);
	public static bool CreateCommandPool(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool, out VkResult result)
	{
		result = CreateCommandPool_3(device, ref createInfo, ref allocator, out commandPool);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCommandPoolDelegate_3(VkDevice device, ref VkCommandPoolCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkCommandPool commandPool);
	private static CreateCommandPoolDelegate_3 CreateCommandPool_3;
	public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* allocator) => DestroyCommandPool_0(device, commandPool, allocator);
	private delegate void DestroyCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* allocator);
	private static DestroyCommandPoolDelegate_0 DestroyCommandPool_0;
	public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, ref VkAllocationCallbacks allocator) => DestroyCommandPool_1(device, commandPool, ref allocator);
	private delegate void DestroyCommandPoolDelegate_1(VkDevice device, VkCommandPool commandPool, ref VkAllocationCallbacks allocator);
	private static DestroyCommandPoolDelegate_1 DestroyCommandPool_1;
	public static VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags) => ResetCommandPool_0(device, commandPool, flags);
	public static bool ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags, out VkResult result)
	{
		result = ResetCommandPool_0(device, commandPool, flags);
		return result == VkResult.Success;
	}
	private delegate VkResult ResetCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
	private static ResetCommandPoolDelegate_0 ResetCommandPool_0;
	public static VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers) => AllocateCommandBuffers_0(device, allocateInfo, commandBuffers);
	public static bool AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers, out VkResult result)
	{
		result = AllocateCommandBuffers_0(device, allocateInfo, commandBuffers);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateCommandBuffersDelegate_0(VkDevice device, VkCommandBufferAllocateInfo* allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers);
	private static AllocateCommandBuffersDelegate_0 AllocateCommandBuffers_0;
	public static VkResult AllocateCommandBuffers(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers) => AllocateCommandBuffers_1(device, ref allocateInfo, commandBuffers);
	public static bool AllocateCommandBuffers(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers, out VkResult result)
	{
		result = AllocateCommandBuffers_1(device, ref allocateInfo, commandBuffers);
		return result == VkResult.Success;
	}
	private delegate VkResult AllocateCommandBuffersDelegate_1(VkDevice device, ref VkCommandBufferAllocateInfo allocateInfo, [In, Out] VkCommandBuffer[] commandBuffers);
	private static AllocateCommandBuffersDelegate_1 AllocateCommandBuffers_1;
	public static void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer[] commandBuffers) => FreeCommandBuffers_0(device, commandPool, commandBufferCount, commandBuffers);
	private delegate void FreeCommandBuffersDelegate_0(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer[] commandBuffers);
	private static FreeCommandBuffersDelegate_0 FreeCommandBuffers_0;
	public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo) => BeginCommandBuffer_0(commandBuffer, beginInfo);
	public static bool BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo, out VkResult result)
	{
		result = BeginCommandBuffer_0(commandBuffer, beginInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult BeginCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* beginInfo);
	private static BeginCommandBufferDelegate_0 BeginCommandBuffer_0;
	public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo) => BeginCommandBuffer_1(commandBuffer, ref beginInfo);
	public static bool BeginCommandBuffer(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo, out VkResult result)
	{
		result = BeginCommandBuffer_1(commandBuffer, ref beginInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult BeginCommandBufferDelegate_1(VkCommandBuffer commandBuffer, ref VkCommandBufferBeginInfo beginInfo);
	private static BeginCommandBufferDelegate_1 BeginCommandBuffer_1;
	public static VkResult EndCommandBuffer(VkCommandBuffer commandBuffer) => EndCommandBuffer_0(commandBuffer);
	public static bool EndCommandBuffer(VkCommandBuffer commandBuffer, out VkResult result)
	{
		result = EndCommandBuffer_0(commandBuffer);
		return result == VkResult.Success;
	}
	private delegate VkResult EndCommandBufferDelegate_0(VkCommandBuffer commandBuffer);
	private static EndCommandBufferDelegate_0 EndCommandBuffer_0;
	public static VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags) => ResetCommandBuffer_0(commandBuffer, flags);
	public static bool ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags, out VkResult result)
	{
		result = ResetCommandBuffer_0(commandBuffer, flags);
		return result == VkResult.Success;
	}
	private delegate VkResult ResetCommandBufferDelegate_0(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
	private static ResetCommandBufferDelegate_0 ResetCommandBuffer_0;
	public static void CommandBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline) => CommandBindPipeline_0(commandBuffer, pipelineBindPoint, pipeline);
	private delegate void CommandBindPipelineDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
	private static CommandBindPipelineDelegate_0 CommandBindPipeline_0;
	public static void CommandSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport[] viewports) => CommandSetViewport_0(commandBuffer, firstViewport, viewportCount, viewports);
	private delegate void CommandSetViewportDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport[] viewports);
	private static CommandSetViewportDelegate_0 CommandSetViewport_0;
	public static void CommandSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D[] scissors) => CommandSetScissor_0(commandBuffer, firstScissor, scissorCount, scissors);
	private delegate void CommandSetScissorDelegate_0(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D[] scissors);
	private static CommandSetScissorDelegate_0 CommandSetScissor_0;
	public static void CommandSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth) => CommandSetLineWidth_0(commandBuffer, lineWidth);
	private delegate void CommandSetLineWidthDelegate_0(VkCommandBuffer commandBuffer, float lineWidth);
	private static CommandSetLineWidthDelegate_0 CommandSetLineWidth_0;
	public static void CommandSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor) => CommandSetDepthBias_0(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
	private delegate void CommandSetDepthBiasDelegate_0(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
	private static CommandSetDepthBiasDelegate_0 CommandSetDepthBias_0;
	public static void CommandSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants) => CommandSetBlendConstants_0(commandBuffer, blendConstants);
	private delegate void CommandSetBlendConstantsDelegate_0(VkCommandBuffer commandBuffer, float blendConstants);
	private static CommandSetBlendConstantsDelegate_0 CommandSetBlendConstants_0;
	public static void CommandSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds) => CommandSetDepthBounds_0(commandBuffer, minDepthBounds, maxDepthBounds);
	private delegate void CommandSetDepthBoundsDelegate_0(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
	private static CommandSetDepthBoundsDelegate_0 CommandSetDepthBounds_0;
	public static void CommandSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask) => CommandSetStencilCompareMask_0(commandBuffer, faceMask, compareMask);
	private delegate void CommandSetStencilCompareMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
	private static CommandSetStencilCompareMaskDelegate_0 CommandSetStencilCompareMask_0;
	public static void CommandSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask) => CommandSetStencilWriteMask_0(commandBuffer, faceMask, writeMask);
	private delegate void CommandSetStencilWriteMaskDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
	private static CommandSetStencilWriteMaskDelegate_0 CommandSetStencilWriteMask_0;
	public static void CommandSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference) => CommandSetStencilReference_0(commandBuffer, faceMask, reference);
	private delegate void CommandSetStencilReferenceDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
	private static CommandSetStencilReferenceDelegate_0 CommandSetStencilReference_0;
	public static void CommandBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets) => CommandBindDescriptorSets_0(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, descriptorSets, dynamicOffsetCount, dynamicOffsets);
	private delegate void CommandBindDescriptorSetsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets);
	private static CommandBindDescriptorSetsDelegate_0 CommandBindDescriptorSets_0;
	public static void CommandBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType) => CommandBindIndexBuffer_0(commandBuffer, buffer, offset, indexType);
	private delegate void CommandBindIndexBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
	private static CommandBindIndexBufferDelegate_0 CommandBindIndexBuffer_0;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets) => CommandBindVertexBuffers_0(commandBuffer, firstBinding, bindingCount, buffers, offsets);
	private delegate void CommandBindVertexBuffersDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets);
	private static CommandBindVertexBuffersDelegate_0 CommandBindVertexBuffers_0;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets) => CommandBindVertexBuffers_1(commandBuffer, firstBinding, bindingCount, buffers, ref offsets);
	private delegate void CommandBindVertexBuffersDelegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets);
	private static CommandBindVertexBuffersDelegate_1 CommandBindVertexBuffers_1;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets) => CommandBindVertexBuffers_2(commandBuffer, firstBinding, bindingCount, ref buffers, offsets);
	private delegate void CommandBindVertexBuffersDelegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets);
	private static CommandBindVertexBuffersDelegate_2 CommandBindVertexBuffers_2;
	public static void CommandBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets) => CommandBindVertexBuffers_3(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets);
	private delegate void CommandBindVertexBuffersDelegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets);
	private static CommandBindVertexBuffersDelegate_3 CommandBindVertexBuffers_3;
	public static void CommandDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance) => CommandDraw_0(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
	private delegate void CommandDrawDelegate_0(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
	private static CommandDrawDelegate_0 CommandDraw_0;
	public static void CommandDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance) => CommandDrawIndexed_0(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
	private delegate void CommandDrawIndexedDelegate_0(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
	private static CommandDrawIndexedDelegate_0 CommandDrawIndexed_0;
	public static void CommandDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static CommandDrawIndirectDelegate_0 CommandDrawIndirect_0;
	public static void CommandDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawIndexedIndirect_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawIndexedIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static CommandDrawIndexedIndirectDelegate_0 CommandDrawIndexedIndirect_0;
	public static void CommandDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatch_0(commandBuffer, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchDelegate_0(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static CommandDispatchDelegate_0 CommandDispatch_0;
	public static void CommandDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset) => CommandDispatchIndirect_0(commandBuffer, buffer, offset);
	private delegate void CommandDispatchIndirectDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
	private static CommandDispatchIndirectDelegate_0 CommandDispatchIndirect_0;
	public static void CommandCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkBuffer destinationBuffer, uint regionCount, VkBufferCopy[] regions) => CommandCopyBuffer_0(commandBuffer, sourceBuffer, destinationBuffer, regionCount, regions);
	private delegate void CommandCopyBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkBuffer destinationBuffer, uint regionCount, VkBufferCopy[] regions);
	private static CommandCopyBufferDelegate_0 CommandCopyBuffer_0;
	public static void CommandCopyImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageCopy[] regions) => CommandCopyImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
	private delegate void CommandCopyImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageCopy[] regions);
	private static CommandCopyImageDelegate_0 CommandCopyImage_0;
	public static void CommandBlitImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageBlit[] regions, VkFilter filter) => CommandBlitImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions, filter);
	private delegate void CommandBlitImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageBlit[] regions, VkFilter filter);
	private static CommandBlitImageDelegate_0 CommandBlitImage_0;
	public static void CommandCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkBufferImageCopy[] regions) => CommandCopyBufferToImage_0(commandBuffer, sourceBuffer, destinationImage, destinationImageLayout, regionCount, regions);
	private delegate void CommandCopyBufferToImageDelegate_0(VkCommandBuffer commandBuffer, VkBuffer sourceBuffer, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkBufferImageCopy[] regions);
	private static CommandCopyBufferToImageDelegate_0 CommandCopyBufferToImage_0;
	public static void CommandCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkBuffer destinationBuffer, uint regionCount, VkBufferImageCopy[] regions) => CommandCopyImageToBuffer_0(commandBuffer, sourceImage, sourceImageLayout, destinationBuffer, regionCount, regions);
	private delegate void CommandCopyImageToBufferDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkBuffer destinationBuffer, uint regionCount, VkBufferImageCopy[] regions);
	private static CommandCopyImageToBufferDelegate_0 CommandCopyImageToBuffer_0;
	public static void CommandUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize dataSize, void* data) => CommandUpdateBuffer_0(commandBuffer, destinationBuffer, destinationOffset, dataSize, data);
	private delegate void CommandUpdateBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize dataSize, void* data);
	private static CommandUpdateBufferDelegate_0 CommandUpdateBuffer_0;
	public static void CommandFillBuffer(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize size, uint data) => CommandFillBuffer_0(commandBuffer, destinationBuffer, destinationOffset, size, data);
	private delegate void CommandFillBufferDelegate_0(VkCommandBuffer commandBuffer, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize size, uint data);
	private static CommandFillBufferDelegate_0 CommandFillBuffer_0;
	public static void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* color, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearColorImage_0(commandBuffer, image, imageLayout, color, rangeCount, ranges);
	private delegate void CommandClearColorImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* color, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearColorImageDelegate_0 CommandClearColorImage_0;
	public static void CommandClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearColorValue color, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearColorImage_1(commandBuffer, image, imageLayout, ref color, rangeCount, ranges);
	private delegate void CommandClearColorImageDelegate_1(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearColorValue color, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearColorImageDelegate_1 CommandClearColorImage_1;
	public static void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearDepthStencilImage_0(commandBuffer, image, imageLayout, depthStencil, rangeCount, ranges);
	private delegate void CommandClearDepthStencilImageDelegate_0(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearDepthStencilImageDelegate_0 CommandClearDepthStencilImage_0;
	public static void CommandClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearDepthStencilValue depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges) => CommandClearDepthStencilImage_1(commandBuffer, image, imageLayout, ref depthStencil, rangeCount, ranges);
	private delegate void CommandClearDepthStencilImageDelegate_1(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, ref VkClearDepthStencilValue depthStencil, uint rangeCount, VkImageSubresourceRange[] ranges);
	private static CommandClearDepthStencilImageDelegate_1 CommandClearDepthStencilImage_1;
	public static void CommandClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment[] attachments, uint rectCount, VkClearRect[] rects) => CommandClearAttachments_0(commandBuffer, attachmentCount, attachments, rectCount, rects);
	private delegate void CommandClearAttachmentsDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment[] attachments, uint rectCount, VkClearRect[] rects);
	private static CommandClearAttachmentsDelegate_0 CommandClearAttachments_0;
	public static void CommandResolveImage(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageResolve[] regions) => CommandResolveImage_0(commandBuffer, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
	private delegate void CommandResolveImageDelegate_0(VkCommandBuffer commandBuffer, VkImage sourceImage, VkImageLayout sourceImageLayout, VkImage destinationImage, VkImageLayout destinationImageLayout, uint regionCount, VkImageResolve[] regions);
	private static CommandResolveImageDelegate_0 CommandResolveImage_0;
	public static void CommandSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask) => CommandSetEvent_0(commandBuffer, @event, stageMask);
	private delegate void CommandSetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);
	private static CommandSetEventDelegate_0 CommandSetEvent_0;
	public static void CommandResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask) => CommandResetEvent_0(commandBuffer, @event, stageMask);
	private delegate void CommandResetEventDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);
	private static CommandResetEventDelegate_0 CommandResetEvent_0;
	public static void CommandWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers) => CommandWaitEvents_0(commandBuffer, eventCount, events, sourceStageMask, destinationStageMask, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
	private delegate void CommandWaitEventsDelegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers);
	private static CommandWaitEventsDelegate_0 CommandWaitEvents_0;
	public static void CommandPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers) => CommandPipelineBarrier_0(commandBuffer, sourceStageMask, destinationStageMask, dependencyFlags, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
	private delegate void CommandPipelineBarrierDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags sourceStageMask, VkPipelineStageFlags destinationStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier[] imageMemoryBarriers);
	private static CommandPipelineBarrierDelegate_0 CommandPipelineBarrier_0;
	public static void CommandBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags) => CommandBeginQuery_0(commandBuffer, queryPool, query, flags);
	private delegate void CommandBeginQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
	private static CommandBeginQueryDelegate_0 CommandBeginQuery_0;
	public static void CommandEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query) => CommandEndQuery_0(commandBuffer, queryPool, query);
	private delegate void CommandEndQueryDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
	private static CommandEndQueryDelegate_0 CommandEndQuery_0;
	public static void CommandResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount) => CommandResetQueryPool_0(commandBuffer, queryPool, firstQuery, queryCount);
	private delegate void CommandResetQueryPoolDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static CommandResetQueryPoolDelegate_0 CommandResetQueryPool_0;
	public static void CommandWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp_0(commandBuffer, pipelineStage, queryPool, query);
	private delegate void CommandWriteTimestampDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query);
	private static CommandWriteTimestampDelegate_0 CommandWriteTimestamp_0;
	public static void CommandCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize stride, VkQueryResultFlags flags) => CommandCopyQueryPoolResults_0(commandBuffer, queryPool, firstQuery, queryCount, destinationBuffer, destinationOffset, stride, flags);
	private delegate void CommandCopyQueryPoolResultsDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, VkDeviceSize stride, VkQueryResultFlags flags);
	private static CommandCopyQueryPoolResultsDelegate_0 CommandCopyQueryPoolResults_0;
	public static void CommandPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* values) => CommandPushConstants_0(commandBuffer, layout, stageFlags, offset, size, values);
	private delegate void CommandPushConstantsDelegate_0(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* values);
	private static CommandPushConstantsDelegate_0 CommandPushConstants_0;
	public static void CommandBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_0(commandBuffer, renderPassBegin, contents);
	private delegate void CommandBeginRenderPassDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassContents contents);
	private static CommandBeginRenderPassDelegate_0 CommandBeginRenderPass_0;
	public static void CommandBeginRenderPass(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassContents contents) => CommandBeginRenderPass_1(commandBuffer, ref renderPassBegin, contents);
	private delegate void CommandBeginRenderPassDelegate_1(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassContents contents);
	private static CommandBeginRenderPassDelegate_1 CommandBeginRenderPass_1;
	public static void CommandNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents) => CommandNextSubpass_0(commandBuffer, contents);
	private delegate void CommandNextSubpassDelegate_0(VkCommandBuffer commandBuffer, VkSubpassContents contents);
	private static CommandNextSubpassDelegate_0 CommandNextSubpass_0;
	public static void CommandEndRenderPass(VkCommandBuffer commandBuffer) => CommandEndRenderPass_0(commandBuffer);
	private delegate void CommandEndRenderPassDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandEndRenderPassDelegate_0 CommandEndRenderPass_0;
	public static void CommandExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer[] commandBuffers) => CommandExecuteCommands_0(commandBuffer, commandBufferCount, commandBuffers);
	private delegate void CommandExecuteCommandsDelegate_0(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer[] commandBuffers);
	private static CommandExecuteCommandsDelegate_0 CommandExecuteCommands_0;
	public static VkResult EnumerateInstanceVersion([In, Out] uint[] apiVersion) => EnumerateInstanceVersion_0(apiVersion);
	public static bool EnumerateInstanceVersion([In, Out] uint[] apiVersion, out VkResult result)
	{
		result = EnumerateInstanceVersion_0(apiVersion);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumerateInstanceVersionDelegate_0([In, Out] uint[] apiVersion);
	private static EnumerateInstanceVersionDelegate_0 EnumerateInstanceVersion_0;
	public static VkResult BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo[] bindInfos) => BindBufferMemory2_0(device, bindInfoCount, bindInfos);
	public static bool BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo[] bindInfos, out VkResult result)
	{
		result = BindBufferMemory2_0(device, bindInfoCount, bindInfos);
		return result == VkResult.Success;
	}
	private delegate VkResult BindBufferMemory2Delegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo[] bindInfos);
	private static BindBufferMemory2Delegate_0 BindBufferMemory2_0;
	public static VkResult BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo[] bindInfos) => BindImageMemory2_0(device, bindInfoCount, bindInfos);
	public static bool BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo[] bindInfos, out VkResult result)
	{
		result = BindImageMemory2_0(device, bindInfoCount, bindInfos);
		return result == VkResult.Success;
	}
	private delegate VkResult BindImageMemory2Delegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo[] bindInfos);
	private static BindImageMemory2Delegate_0 BindImageMemory2_0;
	public static void GetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlags peerMemoryFeatures) => GetDeviceGroupPeerMemoryFeatures_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out peerMemoryFeatures);
	private delegate void GetDeviceGroupPeerMemoryFeaturesDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlags peerMemoryFeatures);
	private static GetDeviceGroupPeerMemoryFeaturesDelegate_0 GetDeviceGroupPeerMemoryFeatures_0;
	public static void CommandSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMask_0(commandBuffer, deviceMask);
	private delegate void CommandSetDeviceMaskDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
	private static CommandSetDeviceMaskDelegate_0 CommandSetDeviceMask_0;
	public static void CommandDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBase_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchBaseDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static CommandDispatchBaseDelegate_0 CommandDispatchBase_0;
	public static VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups_0(instance, physicalDeviceGroupCount, physicalDeviceGroupProperties);
	public static bool EnumeratePhysicalDeviceGroups(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties, out VkResult result)
	{
		result = EnumeratePhysicalDeviceGroups_0(instance, physicalDeviceGroupCount, physicalDeviceGroupProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumeratePhysicalDeviceGroupsDelegate_0(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties);
	private static EnumeratePhysicalDeviceGroupsDelegate_0 EnumeratePhysicalDeviceGroups_0;
	public static VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroups_1(instance, ref physicalDeviceGroupCount, physicalDeviceGroupProperties);
	public static bool EnumeratePhysicalDeviceGroups(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties, out VkResult result)
	{
		result = EnumeratePhysicalDeviceGroups_1(instance, ref physicalDeviceGroupCount, physicalDeviceGroupProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumeratePhysicalDeviceGroupsDelegate_1(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupProperties[] physicalDeviceGroupProperties);
	private static EnumeratePhysicalDeviceGroupsDelegate_1 EnumeratePhysicalDeviceGroups_1;
	public static void GetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements) => GetImageMemoryRequirements2_0(device, info, out memoryRequirements);
	private delegate void GetImageMemoryRequirements2Delegate_0(VkDevice device, VkImageMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements);
	private static GetImageMemoryRequirements2Delegate_0 GetImageMemoryRequirements2_0;
	public static void GetImageMemoryRequirements2(VkDevice device, ref VkImageMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements) => GetImageMemoryRequirements2_1(device, ref info, out memoryRequirements);
	private delegate void GetImageMemoryRequirements2Delegate_1(VkDevice device, ref VkImageMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements);
	private static GetImageMemoryRequirements2Delegate_1 GetImageMemoryRequirements2_1;
	public static void GetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements) => GetBufferMemoryRequirements2_0(device, info, out memoryRequirements);
	private delegate void GetBufferMemoryRequirements2Delegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2* info, out VkMemoryRequirements2 memoryRequirements);
	private static GetBufferMemoryRequirements2Delegate_0 GetBufferMemoryRequirements2_0;
	public static void GetBufferMemoryRequirements2(VkDevice device, ref VkBufferMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements) => GetBufferMemoryRequirements2_1(device, ref info, out memoryRequirements);
	private delegate void GetBufferMemoryRequirements2Delegate_1(VkDevice device, ref VkBufferMemoryRequirementsInfo2 info, out VkMemoryRequirements2 memoryRequirements);
	private static GetBufferMemoryRequirements2Delegate_1 GetBufferMemoryRequirements2_1;
	public static void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_0(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2Delegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2Delegate_0 GetImageSparseMemoryRequirements2_0;
	public static void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_1(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2Delegate_1(VkDevice device, VkImageSparseMemoryRequirementsInfo2* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2Delegate_1 GetImageSparseMemoryRequirements2_1;
	public static void GetImageSparseMemoryRequirements2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2Delegate_2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2Delegate_2 GetImageSparseMemoryRequirements2_2;
	public static void GetImageSparseMemoryRequirements2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2_3(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2Delegate_3(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2 info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2Delegate_3 GetImageSparseMemoryRequirements2_3;
	public static void GetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2 features) => GetPhysicalDeviceFeatures2_0(physicalDevice, out features);
	private delegate void GetPhysicalDeviceFeatures2Delegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2 features);
	private static GetPhysicalDeviceFeatures2Delegate_0 GetPhysicalDeviceFeatures2_0;
	public static void GetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2 properties) => GetPhysicalDeviceProperties2_0(physicalDevice, out properties);
	private delegate void GetPhysicalDeviceProperties2Delegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2 properties);
	private static GetPhysicalDeviceProperties2Delegate_0 GetPhysicalDeviceProperties2_0;
	public static void GetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2 formatProperties) => GetPhysicalDeviceFormatProperties2_0(physicalDevice, format, out formatProperties);
	private delegate void GetPhysicalDeviceFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2 formatProperties);
	private static GetPhysicalDeviceFormatProperties2Delegate_0 GetPhysicalDeviceFormatProperties2_0;
	public static VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2_0(physicalDevice, imageFormatInfo, out imageFormatProperties);
	public static bool GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties, out VkResult result)
	{
		result = GetPhysicalDeviceImageFormatProperties2_0(physicalDevice, imageFormatInfo, out imageFormatProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties);
	private static GetPhysicalDeviceImageFormatProperties2Delegate_0 GetPhysicalDeviceImageFormatProperties2_0;
	public static VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2 imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2_1(physicalDevice, ref imageFormatInfo, out imageFormatProperties);
	public static bool GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2 imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties, out VkResult result)
	{
		result = GetPhysicalDeviceImageFormatProperties2_1(physicalDevice, ref imageFormatInfo, out imageFormatProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceImageFormatProperties2Delegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2 imageFormatInfo, out VkImageFormatProperties2 imageFormatProperties);
	private static GetPhysicalDeviceImageFormatProperties2Delegate_1 GetPhysicalDeviceImageFormatProperties2_1;
	public static void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2Delegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyProperties2Delegate_0 GetPhysicalDeviceQueueFamilyProperties2_0;
	public static void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2Delegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyProperties2Delegate_1 GetPhysicalDeviceQueueFamilyProperties2_1;
	public static void GetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2 memoryProperties) => GetPhysicalDeviceMemoryProperties2_0(physicalDevice, out memoryProperties);
	private delegate void GetPhysicalDeviceMemoryProperties2Delegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2 memoryProperties);
	private static GetPhysicalDeviceMemoryProperties2Delegate_0 GetPhysicalDeviceMemoryProperties2_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_0(physicalDevice, formatInfo, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_0 GetPhysicalDeviceSparseImageFormatProperties2_0;
	public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_1(physicalDevice, formatInfo, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_1 GetPhysicalDeviceSparseImageFormatProperties2_1;
	public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_2(physicalDevice, ref formatInfo, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_2 GetPhysicalDeviceSparseImageFormatProperties2_2;
	public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties) => GetPhysicalDeviceSparseImageFormatProperties2_3(physicalDevice, ref formatInfo, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2Delegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2 formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2Delegate_3 GetPhysicalDeviceSparseImageFormatProperties2_3;
	public static void TrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags) => TrimCommandPool_0(device, commandPool, flags);
	private delegate void TrimCommandPoolDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
	private static TrimCommandPoolDelegate_0 TrimCommandPool_0;
	public static void GetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* queueInfo, out VkQueue queue) => GetDeviceQueue2_0(device, queueInfo, out queue);
	private delegate void GetDeviceQueue2Delegate_0(VkDevice device, VkDeviceQueueInfo2* queueInfo, out VkQueue queue);
	private static GetDeviceQueue2Delegate_0 GetDeviceQueue2_0;
	public static void GetDeviceQueue2(VkDevice device, ref VkDeviceQueueInfo2 queueInfo, out VkQueue queue) => GetDeviceQueue2_1(device, ref queueInfo, out queue);
	private delegate void GetDeviceQueue2Delegate_1(VkDevice device, ref VkDeviceQueueInfo2 queueInfo, out VkQueue queue);
	private static GetDeviceQueue2Delegate_1 GetDeviceQueue2_1;
	public static VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_0(device, createInfo, allocator, out ycbcrConversion);
	public static bool CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion, out VkResult result)
	{
		result = CreateSamplerYcbcrConversion_0(device, createInfo, allocator, out ycbcrConversion);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion);
	private static CreateSamplerYcbcrConversionDelegate_0 CreateSamplerYcbcrConversion_0;
	public static VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_1(device, createInfo, ref allocator, out ycbcrConversion);
	public static bool CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion, out VkResult result)
	{
		result = CreateSamplerYcbcrConversion_1(device, createInfo, ref allocator, out ycbcrConversion);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerYcbcrConversionDelegate_1(VkDevice device, VkSamplerYcbcrConversionCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion);
	private static CreateSamplerYcbcrConversionDelegate_1 CreateSamplerYcbcrConversion_1;
	public static VkResult CreateSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_2(device, ref createInfo, allocator, out ycbcrConversion);
	public static bool CreateSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion, out VkResult result)
	{
		result = CreateSamplerYcbcrConversion_2(device, ref createInfo, allocator, out ycbcrConversion);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerYcbcrConversionDelegate_2(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversion ycbcrConversion);
	private static CreateSamplerYcbcrConversionDelegate_2 CreateSamplerYcbcrConversion_2;
	public static VkResult CreateSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion) => CreateSamplerYcbcrConversion_3(device, ref createInfo, ref allocator, out ycbcrConversion);
	public static bool CreateSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion, out VkResult result)
	{
		result = CreateSamplerYcbcrConversion_3(device, ref createInfo, ref allocator, out ycbcrConversion);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSamplerYcbcrConversionDelegate_3(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversion ycbcrConversion);
	private static CreateSamplerYcbcrConversionDelegate_3 CreateSamplerYcbcrConversion_3;
	public static void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* allocator) => DestroySamplerYcbcrConversion_0(device, ycbcrConversion, allocator);
	private delegate void DestroySamplerYcbcrConversionDelegate_0(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* allocator);
	private static DestroySamplerYcbcrConversionDelegate_0 DestroySamplerYcbcrConversion_0;
	public static void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, ref VkAllocationCallbacks allocator) => DestroySamplerYcbcrConversion_1(device, ycbcrConversion, ref allocator);
	private delegate void DestroySamplerYcbcrConversionDelegate_1(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, ref VkAllocationCallbacks allocator);
	private static DestroySamplerYcbcrConversionDelegate_1 DestroySamplerYcbcrConversion_1;
	public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_0(device, createInfo, allocator, out descriptorUpdateTemplate);
	public static bool CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate, out VkResult result)
	{
		result = CreateDescriptorUpdateTemplate_0(device, createInfo, allocator, out descriptorUpdateTemplate);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateDelegate_0 CreateDescriptorUpdateTemplate_0;
	public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_1(device, createInfo, ref allocator, out descriptorUpdateTemplate);
	public static bool CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate, out VkResult result)
	{
		result = CreateDescriptorUpdateTemplate_1(device, createInfo, ref allocator, out descriptorUpdateTemplate);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorUpdateTemplateDelegate_1(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateDelegate_1 CreateDescriptorUpdateTemplate_1;
	public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_2(device, ref createInfo, allocator, out descriptorUpdateTemplate);
	public static bool CreateDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate, out VkResult result)
	{
		result = CreateDescriptorUpdateTemplate_2(device, ref createInfo, allocator, out descriptorUpdateTemplate);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorUpdateTemplateDelegate_2(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateDelegate_2 CreateDescriptorUpdateTemplate_2;
	public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate) => CreateDescriptorUpdateTemplate_3(device, ref createInfo, ref allocator, out descriptorUpdateTemplate);
	public static bool CreateDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate, out VkResult result)
	{
		result = CreateDescriptorUpdateTemplate_3(device, ref createInfo, ref allocator, out descriptorUpdateTemplate);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDescriptorUpdateTemplateDelegate_3(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplate descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateDelegate_3 CreateDescriptorUpdateTemplate_3;
	public static void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* allocator) => DestroyDescriptorUpdateTemplate_0(device, descriptorUpdateTemplate, allocator);
	private delegate void DestroyDescriptorUpdateTemplateDelegate_0(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorUpdateTemplateDelegate_0 DestroyDescriptorUpdateTemplate_0;
	public static void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, ref VkAllocationCallbacks allocator) => DestroyDescriptorUpdateTemplate_1(device, descriptorUpdateTemplate, ref allocator);
	private delegate void DestroyDescriptorUpdateTemplateDelegate_1(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorUpdateTemplateDelegate_1 DestroyDescriptorUpdateTemplate_1;
	public static void UpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* data) => UpdateDescriptorSetWithTemplate_0(device, descriptorSet, descriptorUpdateTemplate, data);
	private delegate void UpdateDescriptorSetWithTemplateDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* data);
	private static UpdateDescriptorSetWithTemplateDelegate_0 UpdateDescriptorSetWithTemplate_0;
	public static void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* externalBufferInfo, out VkExternalBufferProperties externalBufferProperties) => GetPhysicalDeviceExternalBufferProperties_0(physicalDevice, externalBufferInfo, out externalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* externalBufferInfo, out VkExternalBufferProperties externalBufferProperties);
	private static GetPhysicalDeviceExternalBufferPropertiesDelegate_0 GetPhysicalDeviceExternalBufferProperties_0;
	public static void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfo externalBufferInfo, out VkExternalBufferProperties externalBufferProperties) => GetPhysicalDeviceExternalBufferProperties_1(physicalDevice, ref externalBufferInfo, out externalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfo externalBufferInfo, out VkExternalBufferProperties externalBufferProperties);
	private static GetPhysicalDeviceExternalBufferPropertiesDelegate_1 GetPhysicalDeviceExternalBufferProperties_1;
	public static void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* externalFenceInfo, out VkExternalFenceProperties externalFenceProperties) => GetPhysicalDeviceExternalFenceProperties_0(physicalDevice, externalFenceInfo, out externalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* externalFenceInfo, out VkExternalFenceProperties externalFenceProperties);
	private static GetPhysicalDeviceExternalFencePropertiesDelegate_0 GetPhysicalDeviceExternalFenceProperties_0;
	public static void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfo externalFenceInfo, out VkExternalFenceProperties externalFenceProperties) => GetPhysicalDeviceExternalFenceProperties_1(physicalDevice, ref externalFenceInfo, out externalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfo externalFenceInfo, out VkExternalFenceProperties externalFenceProperties);
	private static GetPhysicalDeviceExternalFencePropertiesDelegate_1 GetPhysicalDeviceExternalFenceProperties_1;
	public static void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties_0(physicalDevice, externalSemaphoreInfo, out externalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties);
	private static GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0 GetPhysicalDeviceExternalSemaphoreProperties_0;
	public static void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphoreProperties_1(physicalDevice, ref externalSemaphoreInfo, out externalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo, out VkExternalSemaphoreProperties externalSemaphoreProperties);
	private static GetPhysicalDeviceExternalSemaphorePropertiesDelegate_1 GetPhysicalDeviceExternalSemaphoreProperties_1;
	public static void GetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupport support) => GetDescriptorSetLayoutSupport_0(device, createInfo, out support);
	private delegate void GetDescriptorSetLayoutSupportDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupport support);
	private static GetDescriptorSetLayoutSupportDelegate_0 GetDescriptorSetLayoutSupport_0;
	public static void GetDescriptorSetLayoutSupport(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupport support) => GetDescriptorSetLayoutSupport_1(device, ref createInfo, out support);
	private delegate void GetDescriptorSetLayoutSupportDelegate_1(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupport support);
	private static GetDescriptorSetLayoutSupportDelegate_1 GetDescriptorSetLayoutSupport_1;
	public static void CommandDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCount_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndirectCountDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndirectCountDelegate_0 CommandDrawIndirectCount_0;
	public static void CommandDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCount_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndexedIndirectCountDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndexedIndirectCountDelegate_0 CommandDrawIndexedIndirectCount_0;
	public static VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2_0(device, createInfo, allocator, out renderPass);
	public static bool CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass2_0(device, createInfo, allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPass2Delegate_0(VkDevice device, VkRenderPassCreateInfo2* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2Delegate_0 CreateRenderPass2_0;
	public static VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2_1(device, createInfo, ref allocator, out renderPass);
	public static bool CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass2_1(device, createInfo, ref allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPass2Delegate_1(VkDevice device, VkRenderPassCreateInfo2* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2Delegate_1 CreateRenderPass2_1;
	public static VkResult CreateRenderPass2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2_2(device, ref createInfo, allocator, out renderPass);
	public static bool CreateRenderPass2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass2_2(device, ref createInfo, allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPass2Delegate_2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2Delegate_2 CreateRenderPass2_2;
	public static VkResult CreateRenderPass2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2_3(device, ref createInfo, ref allocator, out renderPass);
	public static bool CreateRenderPass2(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass, out VkResult result)
	{
		result = CreateRenderPass2_3(device, ref createInfo, ref allocator, out renderPass);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRenderPass2Delegate_3(VkDevice device, ref VkRenderPassCreateInfo2 createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2Delegate_3 CreateRenderPass2_3;
	public static void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo) => CommandBeginRenderPass2_0(commandBuffer, renderPassBegin, subpassBeginInfo);
	private delegate void CommandBeginRenderPass2Delegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo);
	private static CommandBeginRenderPass2Delegate_0 CommandBeginRenderPass2_0;
	public static void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo) => CommandBeginRenderPass2_1(commandBuffer, renderPassBegin, ref subpassBeginInfo);
	private delegate void CommandBeginRenderPass2Delegate_1(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo);
	private static CommandBeginRenderPass2Delegate_1 CommandBeginRenderPass2_1;
	public static void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo) => CommandBeginRenderPass2_2(commandBuffer, ref renderPassBegin, subpassBeginInfo);
	private delegate void CommandBeginRenderPass2Delegate_2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfo* subpassBeginInfo);
	private static CommandBeginRenderPass2Delegate_2 CommandBeginRenderPass2_2;
	public static void CommandBeginRenderPass2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo) => CommandBeginRenderPass2_3(commandBuffer, ref renderPassBegin, ref subpassBeginInfo);
	private delegate void CommandBeginRenderPass2Delegate_3(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfo subpassBeginInfo);
	private static CommandBeginRenderPass2Delegate_3 CommandBeginRenderPass2_3;
	public static void CommandNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo) => CommandNextSubpass2_0(commandBuffer, subpassBeginInfo, subpassEndInfo);
	private delegate void CommandNextSubpass2Delegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo);
	private static CommandNextSubpass2Delegate_0 CommandNextSubpass2_0;
	public static void CommandNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo) => CommandNextSubpass2_1(commandBuffer, subpassBeginInfo, ref subpassEndInfo);
	private delegate void CommandNextSubpass2Delegate_1(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo);
	private static CommandNextSubpass2Delegate_1 CommandNextSubpass2_1;
	public static void CommandNextSubpass2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo) => CommandNextSubpass2_2(commandBuffer, ref subpassBeginInfo, subpassEndInfo);
	private delegate void CommandNextSubpass2Delegate_2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, VkSubpassEndInfo* subpassEndInfo);
	private static CommandNextSubpass2Delegate_2 CommandNextSubpass2_2;
	public static void CommandNextSubpass2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo) => CommandNextSubpass2_3(commandBuffer, ref subpassBeginInfo, ref subpassEndInfo);
	private delegate void CommandNextSubpass2Delegate_3(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfo subpassBeginInfo, ref VkSubpassEndInfo subpassEndInfo);
	private static CommandNextSubpass2Delegate_3 CommandNextSubpass2_3;
	public static void CommandEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* subpassEndInfo) => CommandEndRenderPass2_0(commandBuffer, subpassEndInfo);
	private delegate void CommandEndRenderPass2Delegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfo* subpassEndInfo);
	private static CommandEndRenderPass2Delegate_0 CommandEndRenderPass2_0;
	public static void CommandEndRenderPass2(VkCommandBuffer commandBuffer, ref VkSubpassEndInfo subpassEndInfo) => CommandEndRenderPass2_1(commandBuffer, ref subpassEndInfo);
	private delegate void CommandEndRenderPass2Delegate_1(VkCommandBuffer commandBuffer, ref VkSubpassEndInfo subpassEndInfo);
	private static CommandEndRenderPass2Delegate_1 CommandEndRenderPass2_1;
	public static void ResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount) => ResetQueryPool_0(device, queryPool, firstQuery, queryCount);
	private delegate void ResetQueryPoolDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static ResetQueryPoolDelegate_0 ResetQueryPool_0;
	public static VkResult GetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, out ulong value) => GetSemaphoreCounterValue_0(device, semaphore, out value);
	public static bool GetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, out ulong value, out VkResult result)
	{
		result = GetSemaphoreCounterValue_0(device, semaphore, out value);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSemaphoreCounterValueDelegate_0(VkDevice device, VkSemaphore semaphore, out ulong value);
	private static GetSemaphoreCounterValueDelegate_0 GetSemaphoreCounterValue_0;
	public static VkResult WaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* waitInfo, ulong timeout) => WaitSemaphores_0(device, waitInfo, timeout);
	public static bool WaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* waitInfo, ulong timeout, out VkResult result)
	{
		result = WaitSemaphores_0(device, waitInfo, timeout);
		return result == VkResult.Success;
	}
	private delegate VkResult WaitSemaphoresDelegate_0(VkDevice device, VkSemaphoreWaitInfo* waitInfo, ulong timeout);
	private static WaitSemaphoresDelegate_0 WaitSemaphores_0;
	public static VkResult WaitSemaphores(VkDevice device, ref VkSemaphoreWaitInfo waitInfo, ulong timeout) => WaitSemaphores_1(device, ref waitInfo, timeout);
	public static bool WaitSemaphores(VkDevice device, ref VkSemaphoreWaitInfo waitInfo, ulong timeout, out VkResult result)
	{
		result = WaitSemaphores_1(device, ref waitInfo, timeout);
		return result == VkResult.Success;
	}
	private delegate VkResult WaitSemaphoresDelegate_1(VkDevice device, ref VkSemaphoreWaitInfo waitInfo, ulong timeout);
	private static WaitSemaphoresDelegate_1 WaitSemaphores_1;
	public static VkResult SignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* signalInfo) => SignalSemaphore_0(device, signalInfo);
	public static bool SignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* signalInfo, out VkResult result)
	{
		result = SignalSemaphore_0(device, signalInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult SignalSemaphoreDelegate_0(VkDevice device, VkSemaphoreSignalInfo* signalInfo);
	private static SignalSemaphoreDelegate_0 SignalSemaphore_0;
	public static VkResult SignalSemaphore(VkDevice device, ref VkSemaphoreSignalInfo signalInfo) => SignalSemaphore_1(device, ref signalInfo);
	public static bool SignalSemaphore(VkDevice device, ref VkSemaphoreSignalInfo signalInfo, out VkResult result)
	{
		result = SignalSemaphore_1(device, ref signalInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult SignalSemaphoreDelegate_1(VkDevice device, ref VkSemaphoreSignalInfo signalInfo);
	private static SignalSemaphoreDelegate_1 SignalSemaphore_1;
	public static VkDeviceAddress GetBufferDeviceAddress(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferDeviceAddress_0(device, out info);
	private delegate VkDeviceAddress GetBufferDeviceAddressDelegate_0(VkDevice device, out VkBufferDeviceAddressInfo info);
	private static GetBufferDeviceAddressDelegate_0 GetBufferDeviceAddress_0;
	public static ulong GetBufferOpaqueCaptureAddress(VkDevice device, out VkBufferDeviceAddressInfo info) => GetBufferOpaqueCaptureAddress_0(device, out info);
	private delegate ulong GetBufferOpaqueCaptureAddressDelegate_0(VkDevice device, out VkBufferDeviceAddressInfo info);
	private static GetBufferOpaqueCaptureAddressDelegate_0 GetBufferOpaqueCaptureAddress_0;
	public static ulong GetDeviceMemoryOpaqueCaptureAddress(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfo info) => GetDeviceMemoryOpaqueCaptureAddress_0(device, out info);
	private delegate ulong GetDeviceMemoryOpaqueCaptureAddressDelegate_0(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfo info);
	private static GetDeviceMemoryOpaqueCaptureAddressDelegate_0 GetDeviceMemoryOpaqueCaptureAddress_0;
	public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* allocator) => DestroySurfaceKHR_0(instance, surface, allocator);
	private delegate void DestroySurfaceKHRDelegate_0(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* allocator);
	private static DestroySurfaceKHRDelegate_0 DestroySurfaceKHR_0;
	public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks allocator) => DestroySurfaceKHR_1(instance, surface, ref allocator);
	private delegate void DestroySurfaceKHRDelegate_1(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks allocator);
	private static DestroySurfaceKHRDelegate_1 DestroySurfaceKHR_1;
	public static VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported) => GetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, out supported);
	public static bool GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceSupportKHR_0(physicalDevice, queueFamilyIndex, surface, out supported);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 supported);
	private static GetPhysicalDeviceSurfaceSupportKHRDelegate_0 GetPhysicalDeviceSurfaceSupportKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, out surfaceCapabilities);
	public static bool GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceCapabilitiesKHR_0(physicalDevice, surface, out surfaceCapabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0 GetPhysicalDeviceSurfaceCapabilitiesKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, surfaceFormatCount, surfaceFormats);
	public static bool GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceFormatsKHR_0(physicalDevice, surface, surfaceFormatCount, surfaceFormats);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_0 GetPhysicalDeviceSurfaceFormatsKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormatsKHR_1(physicalDevice, surface, ref surfaceFormatCount, surfaceFormats);
	public static bool GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceFormatsKHR_1(physicalDevice, surface, ref surfaceFormatCount, surfaceFormats);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceFormatsKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormatKHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormatsKHRDelegate_1 GetPhysicalDeviceSurfaceFormatsKHR_1;
	public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, presentModeCount, presentModes);
	public static bool GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes, out VkResult result)
	{
		result = GetPhysicalDeviceSurfacePresentModesKHR_0(physicalDevice, surface, presentModeCount, presentModes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_0 GetPhysicalDeviceSurfacePresentModesKHR_0;
	public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModesKHR_1(physicalDevice, surface, ref presentModeCount, presentModes);
	public static bool GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes, out VkResult result)
	{
		result = GetPhysicalDeviceSurfacePresentModesKHR_1(physicalDevice, surface, ref presentModeCount, presentModes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfacePresentModesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModesKHRDelegate_1 GetPhysicalDeviceSurfacePresentModesKHR_1;
	public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_0(device, createInfo, allocator, out swapchain);
	public static bool CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain, out VkResult result)
	{
		result = CreateSwapchainKHR_0(device, createInfo, allocator, out swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSwapchainKHRDelegate_0(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_0 CreateSwapchainKHR_0;
	public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_1(device, createInfo, ref allocator, out swapchain);
	public static bool CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain, out VkResult result)
	{
		result = CreateSwapchainKHR_1(device, createInfo, ref allocator, out swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSwapchainKHRDelegate_1(VkDevice device, VkSwapchainCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_1 CreateSwapchainKHR_1;
	public static VkResult CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_2(device, ref createInfo, allocator, out swapchain);
	public static bool CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain, out VkResult result)
	{
		result = CreateSwapchainKHR_2(device, ref createInfo, allocator, out swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSwapchainKHRDelegate_2(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_2 CreateSwapchainKHR_2;
	public static VkResult CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain) => CreateSwapchainKHR_3(device, ref createInfo, ref allocator, out swapchain);
	public static bool CreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain, out VkResult result)
	{
		result = CreateSwapchainKHR_3(device, ref createInfo, ref allocator, out swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSwapchainKHRDelegate_3(VkDevice device, ref VkSwapchainCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchain);
	private static CreateSwapchainKHRDelegate_3 CreateSwapchainKHR_3;
	public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* allocator) => DestroySwapchainKHR_0(device, swapchain, allocator);
	private delegate void DestroySwapchainKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* allocator);
	private static DestroySwapchainKHRDelegate_0 DestroySwapchainKHR_0;
	public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks allocator) => DestroySwapchainKHR_1(device, swapchain, ref allocator);
	private delegate void DestroySwapchainKHRDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks allocator);
	private static DestroySwapchainKHRDelegate_1 DestroySwapchainKHR_1;
	public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages) => GetSwapchainImagesKHR_0(device, swapchain, swapchainImageCount, swapchainImages);
	public static bool GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages, out VkResult result)
	{
		result = GetSwapchainImagesKHR_0(device, swapchain, swapchainImageCount, swapchainImages);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSwapchainImagesKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* swapchainImageCount, [In, Out] VkImage[] swapchainImages);
	private static GetSwapchainImagesKHRDelegate_0 GetSwapchainImagesKHR_0;
	public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages) => GetSwapchainImagesKHR_1(device, swapchain, ref swapchainImageCount, swapchainImages);
	public static bool GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages, out VkResult result)
	{
		result = GetSwapchainImagesKHR_1(device, swapchain, ref swapchainImageCount, swapchainImages);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSwapchainImagesKHRDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref uint swapchainImageCount, [In, Out] VkImage[] swapchainImages);
	private static GetSwapchainImagesKHRDelegate_1 GetSwapchainImagesKHR_1;
	public static VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex) => AcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, out imageIndex);
	public static bool AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex, out VkResult result)
	{
		result = AcquireNextImageKHR_0(device, swapchain, timeout, semaphore, fence, out imageIndex);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireNextImageKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, out uint imageIndex);
	private static AcquireNextImageKHRDelegate_0 AcquireNextImageKHR_0;
	public static VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* presentInfo) => QueuePresentKHR_0(queue, presentInfo);
	public static bool QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* presentInfo, out VkResult result)
	{
		result = QueuePresentKHR_0(queue, presentInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult QueuePresentKHRDelegate_0(VkQueue queue, VkPresentInfoKHR* presentInfo);
	private static QueuePresentKHRDelegate_0 QueuePresentKHR_0;
	public static VkResult QueuePresentKHR(VkQueue queue, ref VkPresentInfoKHR presentInfo) => QueuePresentKHR_1(queue, ref presentInfo);
	public static bool QueuePresentKHR(VkQueue queue, ref VkPresentInfoKHR presentInfo, out VkResult result)
	{
		result = QueuePresentKHR_1(queue, ref presentInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult QueuePresentKHRDelegate_1(VkQueue queue, ref VkPresentInfoKHR presentInfo);
	private static QueuePresentKHRDelegate_1 QueuePresentKHR_1;
	public static VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR deviceGroupPresentCapabilities) => GetDeviceGroupPresentCapabilitiesKHR_0(device, out deviceGroupPresentCapabilities);
	public static bool GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR deviceGroupPresentCapabilities, out VkResult result)
	{
		result = GetDeviceGroupPresentCapabilitiesKHR_0(device, out deviceGroupPresentCapabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDeviceGroupPresentCapabilitiesKHRDelegate_0(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR deviceGroupPresentCapabilities);
	private static GetDeviceGroupPresentCapabilitiesKHRDelegate_0 GetDeviceGroupPresentCapabilitiesKHR_0;
	public static VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR modes) => GetDeviceGroupSurfacePresentModesKHR_0(device, surface, out modes);
	public static bool GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR modes, out VkResult result)
	{
		result = GetDeviceGroupSurfacePresentModesKHR_0(device, surface, out modes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDeviceGroupSurfacePresentModesKHRDelegate_0(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR modes);
	private static GetDeviceGroupSurfacePresentModesKHRDelegate_0 GetDeviceGroupSurfacePresentModesKHR_0;
	public static VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects) => GetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, rectCount, rects);
	public static bool GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects, out VkResult result)
	{
		result = GetPhysicalDevicePresentRectanglesKHR_0(physicalDevice, surface, rectCount, rects);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDevicePresentRectanglesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* rectCount, [In, Out] VkRect2D[] rects);
	private static GetPhysicalDevicePresentRectanglesKHRDelegate_0 GetPhysicalDevicePresentRectanglesKHR_0;
	public static VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects) => GetPhysicalDevicePresentRectanglesKHR_1(physicalDevice, surface, ref rectCount, rects);
	public static bool GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects, out VkResult result)
	{
		result = GetPhysicalDevicePresentRectanglesKHR_1(physicalDevice, surface, ref rectCount, rects);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDevicePresentRectanglesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint rectCount, [In, Out] VkRect2D[] rects);
	private static GetPhysicalDevicePresentRectanglesKHRDelegate_1 GetPhysicalDevicePresentRectanglesKHR_1;
	public static VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* acquireInfo, out uint imageIndex) => AcquireNextImage2KHR_0(device, acquireInfo, out imageIndex);
	public static bool AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* acquireInfo, out uint imageIndex, out VkResult result)
	{
		result = AcquireNextImage2KHR_0(device, acquireInfo, out imageIndex);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireNextImage2KHRDelegate_0(VkDevice device, VkAcquireNextImageInfoKHR* acquireInfo, out uint imageIndex);
	private static AcquireNextImage2KHRDelegate_0 AcquireNextImage2KHR_0;
	public static VkResult AcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR acquireInfo, out uint imageIndex) => AcquireNextImage2KHR_1(device, ref acquireInfo, out imageIndex);
	public static bool AcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR acquireInfo, out uint imageIndex, out VkResult result)
	{
		result = AcquireNextImage2KHR_1(device, ref acquireInfo, out imageIndex);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireNextImage2KHRDelegate_1(VkDevice device, ref VkAcquireNextImageInfoKHR acquireInfo, out uint imageIndex);
	private static AcquireNextImage2KHRDelegate_1 AcquireNextImage2KHR_1;
	public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties) => GetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayPropertiesKHR_0(physicalDevice, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPropertiesKHR_0;
	public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties) => GetPhysicalDeviceDisplayPropertiesKHR_1(physicalDevice, ref propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayPropertiesKHR_1(physicalDevice, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayPropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPropertiesKHRDelegate_1 GetPhysicalDeviceDisplayPropertiesKHR_1;
	public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayPlanePropertiesKHR_0(physicalDevice, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0 GetPhysicalDeviceDisplayPlanePropertiesKHR_0;
	public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties) => GetPhysicalDeviceDisplayPlanePropertiesKHR_1(physicalDevice, ref propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayPlanePropertiesKHR_1(physicalDevice, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlanePropertiesKHR[] properties);
	private static GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1 GetPhysicalDeviceDisplayPlanePropertiesKHR_1;
	public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays) => GetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, displayCount, displays);
	public static bool GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays, out VkResult result)
	{
		result = GetDisplayPlaneSupportedDisplaysKHR_0(physicalDevice, planeIndex, displayCount, displays);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_0(VkPhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, [In, Out] VkDisplayKHR[] displays);
	private static GetDisplayPlaneSupportedDisplaysKHRDelegate_0 GetDisplayPlaneSupportedDisplaysKHR_0;
	public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays) => GetDisplayPlaneSupportedDisplaysKHR_1(physicalDevice, planeIndex, ref displayCount, displays);
	public static bool GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays, out VkResult result)
	{
		result = GetDisplayPlaneSupportedDisplaysKHR_1(physicalDevice, planeIndex, ref displayCount, displays);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayPlaneSupportedDisplaysKHRDelegate_1(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint displayCount, [In, Out] VkDisplayKHR[] displays);
	private static GetDisplayPlaneSupportedDisplaysKHRDelegate_1 GetDisplayPlaneSupportedDisplaysKHR_1;
	public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties) => GetDisplayModePropertiesKHR_0(physicalDevice, display, propertyCount, properties);
	public static bool GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties, out VkResult result)
	{
		result = GetDisplayModePropertiesKHR_0(physicalDevice, display, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayModePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties);
	private static GetDisplayModePropertiesKHRDelegate_0 GetDisplayModePropertiesKHR_0;
	public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties) => GetDisplayModePropertiesKHR_1(physicalDevice, display, ref propertyCount, properties);
	public static bool GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties, out VkResult result)
	{
		result = GetDisplayModePropertiesKHR_1(physicalDevice, display, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayModePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModePropertiesKHR[] properties);
	private static GetDisplayModePropertiesKHRDelegate_1 GetDisplayModePropertiesKHR_1;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_0(physicalDevice, display, createInfo, allocator, out mode);
	public static bool CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode, out VkResult result)
	{
		result = CreateDisplayModeKHR_0(physicalDevice, display, createInfo, allocator, out mode);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayModeKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_0 CreateDisplayModeKHR_0;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_1(physicalDevice, display, createInfo, ref allocator, out mode);
	public static bool CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode, out VkResult result)
	{
		result = CreateDisplayModeKHR_1(physicalDevice, display, createInfo, ref allocator, out mode);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayModeKHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_1 CreateDisplayModeKHR_1;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_2(physicalDevice, display, ref createInfo, allocator, out mode);
	public static bool CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode, out VkResult result)
	{
		result = CreateDisplayModeKHR_2(physicalDevice, display, ref createInfo, allocator, out mode);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayModeKHRDelegate_2(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_2 CreateDisplayModeKHR_2;
	public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode) => CreateDisplayModeKHR_3(physicalDevice, display, ref createInfo, ref allocator, out mode);
	public static bool CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode, out VkResult result)
	{
		result = CreateDisplayModeKHR_3(physicalDevice, display, ref createInfo, ref allocator, out mode);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayModeKHRDelegate_3(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDisplayModeKHR mode);
	private static CreateDisplayModeKHRDelegate_3 CreateDisplayModeKHR_3;
	public static VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities) => GetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, out capabilities);
	public static bool GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities, out VkResult result)
	{
		result = GetDisplayPlaneCapabilitiesKHR_0(physicalDevice, mode, planeIndex, out capabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayPlaneCapabilitiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR capabilities);
	private static GetDisplayPlaneCapabilitiesKHRDelegate_0 GetDisplayPlaneCapabilitiesKHR_0;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_0(instance, createInfo, allocator, out surface);
	public static bool CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateDisplayPlaneSurfaceKHR_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_0(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_0 CreateDisplayPlaneSurfaceKHR_0;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateDisplayPlaneSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_1(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_1 CreateDisplayPlaneSurfaceKHR_1;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateDisplayPlaneSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_2(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_2 CreateDisplayPlaneSurfaceKHR_2;
	public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateDisplayPlaneSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateDisplayPlaneSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDisplayPlaneSurfaceKHRDelegate_3(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateDisplayPlaneSurfaceKHRDelegate_3 CreateDisplayPlaneSurfaceKHR_3;
	public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains) => CreateSharedSwapchainsKHR_0(device, swapchainCount, createInfos, allocator, out swapchains);
	public static bool CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains, out VkResult result)
	{
		result = CreateSharedSwapchainsKHR_0(device, swapchainCount, createInfos, allocator, out swapchains);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSharedSwapchainsKHRDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkSwapchainKHR swapchains);
	private static CreateSharedSwapchainsKHRDelegate_0 CreateSharedSwapchainsKHR_0;
	public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains) => CreateSharedSwapchainsKHR_1(device, swapchainCount, createInfos, ref allocator, out swapchains);
	public static bool CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains, out VkResult result)
	{
		result = CreateSharedSwapchainsKHR_1(device, swapchainCount, createInfos, ref allocator, out swapchains);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateSharedSwapchainsKHRDelegate_1(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkSwapchainKHR swapchains);
	private static CreateSharedSwapchainsKHRDelegate_1 CreateSharedSwapchainsKHR_1;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_0(instance, createInfo, allocator, out surface);
	public static bool CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXlibSurfaceKHR_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXlibSurfaceKHRDelegate_0(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_0 CreateXlibSurfaceKHR_0;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXlibSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXlibSurfaceKHRDelegate_1(VkInstance instance, VkXlibSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_1 CreateXlibSurfaceKHR_1;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXlibSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXlibSurfaceKHRDelegate_2(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_2 CreateXlibSurfaceKHR_2;
	public static VkResult CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXlibSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXlibSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXlibSurfaceKHRDelegate_3(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXlibSurfaceKHRDelegate_3 CreateXlibSurfaceKHR_3;
	public static VkBool32 GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID) => GetPhysicalDeviceXlibPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, dpy, visualID);
	private delegate VkBool32 GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* dpy, IntPtr visualID);
	private static GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0 GetPhysicalDeviceXlibPresentationSupportKHR_0;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_0(instance, createInfo, allocator, out surface);
	public static bool CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXcbSurfaceKHR_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXcbSurfaceKHRDelegate_0(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_0 CreateXcbSurfaceKHR_0;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXcbSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXcbSurfaceKHRDelegate_1(VkInstance instance, VkXcbSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_1 CreateXcbSurfaceKHR_1;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXcbSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXcbSurfaceKHRDelegate_2(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_2 CreateXcbSurfaceKHR_2;
	public static VkResult CreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateXcbSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateXcbSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateXcbSurfaceKHRDelegate_3(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateXcbSurfaceKHRDelegate_3 CreateXcbSurfaceKHR_3;
	public static VkBool32 GetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id) => GetPhysicalDeviceXcbPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, connection, visual_id);
	private delegate VkBool32 GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* connection, IntPtr visual_id);
	private static GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0 GetPhysicalDeviceXcbPresentationSupportKHR_0;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_0(instance, createInfo, allocator, out surface);
	public static bool CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWaylandSurfaceKHR_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_0(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_0 CreateWaylandSurfaceKHR_0;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWaylandSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_1(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_1 CreateWaylandSurfaceKHR_1;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWaylandSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_2(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_2 CreateWaylandSurfaceKHR_2;
	public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWaylandSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWaylandSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWaylandSurfaceKHRDelegate_3(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWaylandSurfaceKHRDelegate_3 CreateWaylandSurfaceKHR_3;
	public static VkBool32 GetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display) => GetPhysicalDeviceWaylandPresentationSupportKHR_0(physicalDevice, queueFamilyIndex, display);
	private delegate VkBool32 GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, void* display);
	private static GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0 GetPhysicalDeviceWaylandPresentationSupportKHR_0;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_0(instance, createInfo, allocator, out surface);
	public static bool CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateAndroidSurfaceKHR_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_0(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_0 CreateAndroidSurfaceKHR_0;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateAndroidSurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_1(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_1 CreateAndroidSurfaceKHR_1;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateAndroidSurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_2(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_2 CreateAndroidSurfaceKHR_2;
	public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateAndroidSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateAndroidSurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAndroidSurfaceKHRDelegate_3(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateAndroidSurfaceKHRDelegate_3 CreateAndroidSurfaceKHR_3;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_0(instance, createInfo, allocator, out surface);
	public static bool CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWin32SurfaceKHR_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWin32SurfaceKHRDelegate_0(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_0 CreateWin32SurfaceKHR_0;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWin32SurfaceKHR_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWin32SurfaceKHRDelegate_1(VkInstance instance, VkWin32SurfaceCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_1 CreateWin32SurfaceKHR_1;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWin32SurfaceKHR_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWin32SurfaceKHRDelegate_2(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_2 CreateWin32SurfaceKHR_2;
	public static VkResult CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateWin32SurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateWin32SurfaceKHR_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateWin32SurfaceKHRDelegate_3(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateWin32SurfaceKHRDelegate_3 CreateWin32SurfaceKHR_3;
	public static VkBool32 GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex) => GetPhysicalDeviceWin32PresentationSupportKHR_0(physicalDevice, queueFamilyIndex);
	private delegate VkBool32 GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
	private static GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0 GetPhysicalDeviceWin32PresentationSupportKHR_0;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_0(instance, createInfo, allocator, out callback);
	public static bool CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback, out VkResult result)
	{
		result = CreateDebugReportCallbackEXT_0(instance, createInfo, allocator, out callback);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_0 CreateDebugReportCallbackEXT_0;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_1(instance, createInfo, ref allocator, out callback);
	public static bool CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback, out VkResult result)
	{
		result = CreateDebugReportCallbackEXT_1(instance, createInfo, ref allocator, out callback);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_1(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_1 CreateDebugReportCallbackEXT_1;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_2(instance, ref createInfo, allocator, out callback);
	public static bool CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback, out VkResult result)
	{
		result = CreateDebugReportCallbackEXT_2(instance, ref createInfo, allocator, out callback);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_2(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_2 CreateDebugReportCallbackEXT_2;
	public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback) => CreateDebugReportCallbackEXT_3(instance, ref createInfo, ref allocator, out callback);
	public static bool CreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback, out VkResult result)
	{
		result = CreateDebugReportCallbackEXT_3(instance, ref createInfo, ref allocator, out callback);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugReportCallbackEXTDelegate_3(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugReportCallbackEXT callback);
	private static CreateDebugReportCallbackEXTDelegate_3 CreateDebugReportCallbackEXT_3;
	public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* allocator) => DestroyDebugReportCallbackEXT_0(instance, callback, allocator);
	private delegate void DestroyDebugReportCallbackEXTDelegate_0(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* allocator);
	private static DestroyDebugReportCallbackEXTDelegate_0 DestroyDebugReportCallbackEXT_0;
	public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks allocator) => DestroyDebugReportCallbackEXT_1(instance, callback, ref allocator);
	private delegate void DestroyDebugReportCallbackEXTDelegate_1(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks allocator);
	private static DestroyDebugReportCallbackEXTDelegate_1 DestroyDebugReportCallbackEXT_1;
	public static void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message) => DebugReportMessageEXT_0(instance, flags, objectType, @object, location, messageCode, layerPrefix, message);
	private delegate void DebugReportMessageEXTDelegate_0(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message);
	private static DebugReportMessageEXTDelegate_0 DebugReportMessageEXT_0;
	public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo) => DebugMarkerSetObjectTagEXT_0(device, tagInfo);
	public static bool DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo, out VkResult result)
	{
		result = DebugMarkerSetObjectTagEXT_0(device, tagInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult DebugMarkerSetObjectTagEXTDelegate_0(VkDevice device, VkDebugMarkerObjectTagInfoEXT* tagInfo);
	private static DebugMarkerSetObjectTagEXTDelegate_0 DebugMarkerSetObjectTagEXT_0;
	public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo) => DebugMarkerSetObjectTagEXT_1(device, ref tagInfo);
	public static bool DebugMarkerSetObjectTagEXT(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo, out VkResult result)
	{
		result = DebugMarkerSetObjectTagEXT_1(device, ref tagInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult DebugMarkerSetObjectTagEXTDelegate_1(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT tagInfo);
	private static DebugMarkerSetObjectTagEXTDelegate_1 DebugMarkerSetObjectTagEXT_1;
	public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo) => DebugMarkerSetObjectNameEXT_0(device, nameInfo);
	public static bool DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo, out VkResult result)
	{
		result = DebugMarkerSetObjectNameEXT_0(device, nameInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult DebugMarkerSetObjectNameEXTDelegate_0(VkDevice device, VkDebugMarkerObjectNameInfoEXT* nameInfo);
	private static DebugMarkerSetObjectNameEXTDelegate_0 DebugMarkerSetObjectNameEXT_0;
	public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo) => DebugMarkerSetObjectNameEXT_1(device, ref nameInfo);
	public static bool DebugMarkerSetObjectNameEXT(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo, out VkResult result)
	{
		result = DebugMarkerSetObjectNameEXT_1(device, ref nameInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult DebugMarkerSetObjectNameEXTDelegate_1(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT nameInfo);
	private static DebugMarkerSetObjectNameEXTDelegate_1 DebugMarkerSetObjectNameEXT_1;
	public static void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo) => CommandDebugMarkerBeginEXT_0(commandBuffer, markerInfo);
	private delegate void CommandDebugMarkerBeginEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo);
	private static CommandDebugMarkerBeginEXTDelegate_0 CommandDebugMarkerBeginEXT_0;
	public static void CommandDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo) => CommandDebugMarkerBeginEXT_1(commandBuffer, ref markerInfo);
	private delegate void CommandDebugMarkerBeginEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo);
	private static CommandDebugMarkerBeginEXTDelegate_1 CommandDebugMarkerBeginEXT_1;
	public static void CommandDebugMarkerEndEXT(VkCommandBuffer commandBuffer) => CommandDebugMarkerEndEXT_0(commandBuffer);
	private delegate void CommandDebugMarkerEndEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandDebugMarkerEndEXTDelegate_0 CommandDebugMarkerEndEXT_0;
	public static void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo) => CommandDebugMarkerInsertEXT_0(commandBuffer, markerInfo);
	private delegate void CommandDebugMarkerInsertEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* markerInfo);
	private static CommandDebugMarkerInsertEXTDelegate_0 CommandDebugMarkerInsertEXT_0;
	public static void CommandDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo) => CommandDebugMarkerInsertEXT_1(commandBuffer, ref markerInfo);
	private delegate void CommandDebugMarkerInsertEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT markerInfo);
	private static CommandDebugMarkerInsertEXTDelegate_1 CommandDebugMarkerInsertEXT_1;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_0(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_0 CommandBindTransformFeedbackBuffersEXT_0;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_1(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_1 CommandBindTransformFeedbackBuffersEXT_1;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_2(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_2 CommandBindTransformFeedbackBuffersEXT_2;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_3(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_3 CommandBindTransformFeedbackBuffersEXT_3;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_4(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_4(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_4 CommandBindTransformFeedbackBuffersEXT_4;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_5(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_5(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_5 CommandBindTransformFeedbackBuffersEXT_5;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes) => CommandBindTransformFeedbackBuffersEXT_6(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_6(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_6 CommandBindTransformFeedbackBuffersEXT_6;
	public static void CommandBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes) => CommandBindTransformFeedbackBuffersEXT_7(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes);
	private delegate void CommandBindTransformFeedbackBuffersEXTDelegate_7(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes);
	private static CommandBindTransformFeedbackBuffersEXTDelegate_7 CommandBindTransformFeedbackBuffersEXT_7;
	public static void CommandBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets) => CommandBeginTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, counterBufferOffsets);
	private delegate void CommandBeginTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets);
	private static CommandBeginTransformFeedbackEXTDelegate_0 CommandBeginTransformFeedbackEXT_0;
	public static void CommandBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets) => CommandBeginTransformFeedbackEXT_1(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, ref counterBufferOffsets);
	private delegate void CommandBeginTransformFeedbackEXTDelegate_1(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets);
	private static CommandBeginTransformFeedbackEXTDelegate_1 CommandBeginTransformFeedbackEXT_1;
	public static void CommandEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets) => CommandEndTransformFeedbackEXT_0(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, counterBufferOffsets);
	private delegate void CommandEndTransformFeedbackEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, VkDeviceSize* counterBufferOffsets);
	private static CommandEndTransformFeedbackEXTDelegate_0 CommandEndTransformFeedbackEXT_0;
	public static void CommandEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets) => CommandEndTransformFeedbackEXT_1(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, ref counterBufferOffsets);
	private delegate void CommandEndTransformFeedbackEXTDelegate_1(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer[] counterBuffers, ref VkDeviceSize counterBufferOffsets);
	private static CommandEndTransformFeedbackEXTDelegate_1 CommandEndTransformFeedbackEXT_1;
	public static void CommandBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index) => CommandBeginQueryIndexedEXT_0(commandBuffer, queryPool, query, flags, index);
	private delegate void CommandBeginQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
	private static CommandBeginQueryIndexedEXTDelegate_0 CommandBeginQueryIndexedEXT_0;
	public static void CommandEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index) => CommandEndQueryIndexedEXT_0(commandBuffer, queryPool, query, index);
	private delegate void CommandEndQueryIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
	private static CommandEndQueryIndexedEXTDelegate_0 CommandEndQueryIndexedEXT_0;
	public static void CommandDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride) => CommandDrawIndirectByteCountEXT_0(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
	private delegate void CommandDrawIndirectByteCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride);
	private static CommandDrawIndirectByteCountEXTDelegate_0 CommandDrawIndirectByteCountEXT_0;
	public static VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_0(device, createInfo, allocator, out module);
	public static bool CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module, out VkResult result)
	{
		result = CreateCuModuleNVX_0(device, createInfo, allocator, out module);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuModuleNVXDelegate_0(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module);
	private static CreateCuModuleNVXDelegate_0 CreateCuModuleNVX_0;
	public static VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_1(device, createInfo, ref allocator, out module);
	public static bool CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module, out VkResult result)
	{
		result = CreateCuModuleNVX_1(device, createInfo, ref allocator, out module);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuModuleNVXDelegate_1(VkDevice device, VkCuModuleCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module);
	private static CreateCuModuleNVXDelegate_1 CreateCuModuleNVX_1;
	public static VkResult CreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_2(device, ref createInfo, allocator, out module);
	public static bool CreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module, out VkResult result)
	{
		result = CreateCuModuleNVX_2(device, ref createInfo, allocator, out module);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuModuleNVXDelegate_2(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuModuleNVX module);
	private static CreateCuModuleNVXDelegate_2 CreateCuModuleNVX_2;
	public static VkResult CreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module) => CreateCuModuleNVX_3(device, ref createInfo, ref allocator, out module);
	public static bool CreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module, out VkResult result)
	{
		result = CreateCuModuleNVX_3(device, ref createInfo, ref allocator, out module);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuModuleNVXDelegate_3(VkDevice device, ref VkCuModuleCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuModuleNVX module);
	private static CreateCuModuleNVXDelegate_3 CreateCuModuleNVX_3;
	public static VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_0(device, createInfo, allocator, out function);
	public static bool CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function, out VkResult result)
	{
		result = CreateCuFunctionNVX_0(device, createInfo, allocator, out function);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuFunctionNVXDelegate_0(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function);
	private static CreateCuFunctionNVXDelegate_0 CreateCuFunctionNVX_0;
	public static VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_1(device, createInfo, ref allocator, out function);
	public static bool CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function, out VkResult result)
	{
		result = CreateCuFunctionNVX_1(device, createInfo, ref allocator, out function);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuFunctionNVXDelegate_1(VkDevice device, VkCuFunctionCreateInfoNVX* createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function);
	private static CreateCuFunctionNVXDelegate_1 CreateCuFunctionNVX_1;
	public static VkResult CreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_2(device, ref createInfo, allocator, out function);
	public static bool CreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function, out VkResult result)
	{
		result = CreateCuFunctionNVX_2(device, ref createInfo, allocator, out function);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuFunctionNVXDelegate_2(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, VkAllocationCallbacks* allocator, out VkCuFunctionNVX function);
	private static CreateCuFunctionNVXDelegate_2 CreateCuFunctionNVX_2;
	public static VkResult CreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function) => CreateCuFunctionNVX_3(device, ref createInfo, ref allocator, out function);
	public static bool CreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function, out VkResult result)
	{
		result = CreateCuFunctionNVX_3(device, ref createInfo, ref allocator, out function);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateCuFunctionNVXDelegate_3(VkDevice device, ref VkCuFunctionCreateInfoNVX createInfo, ref VkAllocationCallbacks allocator, out VkCuFunctionNVX function);
	private static CreateCuFunctionNVXDelegate_3 CreateCuFunctionNVX_3;
	public static void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* allocator) => DestroyCuModuleNVX_0(device, module, allocator);
	private delegate void DestroyCuModuleNVXDelegate_0(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* allocator);
	private static DestroyCuModuleNVXDelegate_0 DestroyCuModuleNVX_0;
	public static void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, ref VkAllocationCallbacks allocator) => DestroyCuModuleNVX_1(device, module, ref allocator);
	private delegate void DestroyCuModuleNVXDelegate_1(VkDevice device, VkCuModuleNVX module, ref VkAllocationCallbacks allocator);
	private static DestroyCuModuleNVXDelegate_1 DestroyCuModuleNVX_1;
	public static void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* allocator) => DestroyCuFunctionNVX_0(device, function, allocator);
	private delegate void DestroyCuFunctionNVXDelegate_0(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* allocator);
	private static DestroyCuFunctionNVXDelegate_0 DestroyCuFunctionNVX_0;
	public static void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, ref VkAllocationCallbacks allocator) => DestroyCuFunctionNVX_1(device, function, ref allocator);
	private delegate void DestroyCuFunctionNVXDelegate_1(VkDevice device, VkCuFunctionNVX function, ref VkAllocationCallbacks allocator);
	private static DestroyCuFunctionNVXDelegate_1 DestroyCuFunctionNVX_1;
	public static void CommandCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* launchInfo) => CommandCuLaunchKernelNVX_0(commandBuffer, launchInfo);
	private delegate void CommandCuLaunchKernelNVXDelegate_0(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* launchInfo);
	private static CommandCuLaunchKernelNVXDelegate_0 CommandCuLaunchKernelNVX_0;
	public static void CommandCuLaunchKernelNVX(VkCommandBuffer commandBuffer, ref VkCuLaunchInfoNVX launchInfo) => CommandCuLaunchKernelNVX_1(commandBuffer, ref launchInfo);
	private delegate void CommandCuLaunchKernelNVXDelegate_1(VkCommandBuffer commandBuffer, ref VkCuLaunchInfoNVX launchInfo);
	private static CommandCuLaunchKernelNVXDelegate_1 CommandCuLaunchKernelNVX_1;
	public static uint GetImageViewHandleNVX(VkDevice device, out VkImageViewHandleInfoNVX info) => GetImageViewHandleNVX_0(device, out info);
	private delegate uint GetImageViewHandleNVXDelegate_0(VkDevice device, out VkImageViewHandleInfoNVX info);
	private static GetImageViewHandleNVXDelegate_0 GetImageViewHandleNVX_0;
	public static VkResult GetImageViewAddressNVX(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX properties) => GetImageViewAddressNVX_0(device, imageView, out properties);
	public static bool GetImageViewAddressNVX(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX properties, out VkResult result)
	{
		result = GetImageViewAddressNVX_0(device, imageView, out properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetImageViewAddressNVXDelegate_0(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX properties);
	private static GetImageViewAddressNVXDelegate_0 GetImageViewAddressNVX_0;
	[Obsolete("Use CommandDrawIndirectCount")]
	public static void CommandDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndirectCountAMDDelegate_0 CommandDrawIndirectCountAMD_0;
	[Obsolete("Use CommandDrawIndexedIndirectCount")]
	public static void CommandDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCountAMD_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndexedIndirectCountAMDDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndexedIndirectCountAMDDelegate_0 CommandDrawIndexedIndirectCountAMD_0;
	public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info) => GetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, infoSize, info);
	public static bool GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info, out VkResult result)
	{
		result = GetShaderInfoAMD_0(device, pipeline, shaderStage, infoType, infoSize, info);
		return result == VkResult.Success;
	}
	private delegate VkResult GetShaderInfoAMDDelegate_0(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nuint* infoSize, void* info);
	private static GetShaderInfoAMDDelegate_0 GetShaderInfoAMD_0;
	public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info) => GetShaderInfoAMD_1(device, pipeline, shaderStage, infoType, ref infoSize, info);
	public static bool GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info, out VkResult result)
	{
		result = GetShaderInfoAMD_1(device, pipeline, shaderStage, infoType, ref infoSize, info);
		return result == VkResult.Success;
	}
	private delegate VkResult GetShaderInfoAMDDelegate_1(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref nuint infoSize, void* info);
	private static GetShaderInfoAMDDelegate_1 GetShaderInfoAMD_1;
	public static void CommandBeginRenderingKHR(VkCommandBuffer commandBuffer, VkRenderingInfoKHR* renderingInfo) => CommandBeginRenderingKHR_0(commandBuffer, renderingInfo);
	private delegate void CommandBeginRenderingKHRDelegate_0(VkCommandBuffer commandBuffer, VkRenderingInfoKHR* renderingInfo);
	private static CommandBeginRenderingKHRDelegate_0 CommandBeginRenderingKHR_0;
	public static void CommandBeginRenderingKHR(VkCommandBuffer commandBuffer, ref VkRenderingInfoKHR renderingInfo) => CommandBeginRenderingKHR_1(commandBuffer, ref renderingInfo);
	private delegate void CommandBeginRenderingKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkRenderingInfoKHR renderingInfo);
	private static CommandBeginRenderingKHRDelegate_1 CommandBeginRenderingKHR_1;
	public static void CommandEndRenderingKHR(VkCommandBuffer commandBuffer) => CommandEndRenderingKHR_0(commandBuffer);
	private delegate void CommandEndRenderingKHRDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandEndRenderingKHRDelegate_0 CommandEndRenderingKHR_0;
	public static VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties) => GetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, out externalImageFormatProperties);
	public static bool GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties, out VkResult result)
	{
		result = GetPhysicalDeviceExternalImageFormatPropertiesNV_0(physicalDevice, format, type, tiling, usage, flags, externalHandleType, out externalImageFormatProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV externalImageFormatProperties);
	private static GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0 GetPhysicalDeviceExternalImageFormatPropertiesNV_0;
	public static VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle) => GetMemoryWin32HandleNV_0(device, memory, handleType, out handle);
	public static bool GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle, out VkResult result)
	{
		result = GetMemoryWin32HandleNV_0(device, memory, handleType, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryWin32HandleNVDelegate_0(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out IntPtr handle);
	private static GetMemoryWin32HandleNVDelegate_0 GetMemoryWin32HandleNV_0;
	[Obsolete("Use GetPhysicalDeviceFeatures2")]
	public static void GetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2KHR features) => GetPhysicalDeviceFeatures2KHR_0(physicalDevice, out features);
	private delegate void GetPhysicalDeviceFeatures2KHRDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceFeatures2KHR features);
	private static GetPhysicalDeviceFeatures2KHRDelegate_0 GetPhysicalDeviceFeatures2KHR_0;
	[Obsolete("Use GetPhysicalDeviceProperties2")]
	public static void GetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2KHR properties) => GetPhysicalDeviceProperties2KHR_0(physicalDevice, out properties);
	private delegate void GetPhysicalDeviceProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceProperties2KHR properties);
	private static GetPhysicalDeviceProperties2KHRDelegate_0 GetPhysicalDeviceProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceFormatProperties2")]
	public static void GetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2KHR formatProperties) => GetPhysicalDeviceFormatProperties2KHR_0(physicalDevice, format, out formatProperties);
	private delegate void GetPhysicalDeviceFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkFormat format, out VkFormatProperties2KHR formatProperties);
	private static GetPhysicalDeviceFormatProperties2KHRDelegate_0 GetPhysicalDeviceFormatProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceImageFormatProperties2")]
	public static void GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2KHR* imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2KHR_0(physicalDevice, imageFormatInfo, out imageFormatProperties);
	private delegate void GetPhysicalDeviceImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2KHR* imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties);
	private static GetPhysicalDeviceImageFormatProperties2KHRDelegate_0 GetPhysicalDeviceImageFormatProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceImageFormatProperties2")]
	public static void GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2KHR imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties) => GetPhysicalDeviceImageFormatProperties2KHR_1(physicalDevice, ref imageFormatInfo, out imageFormatProperties);
	private delegate void GetPhysicalDeviceImageFormatProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceImageFormatInfo2KHR imageFormatInfo, out VkImageFormatProperties2KHR imageFormatProperties);
	private static GetPhysicalDeviceImageFormatProperties2KHRDelegate_1 GetPhysicalDeviceImageFormatProperties2KHR_1;
	[Obsolete("Use GetPhysicalDeviceQueueFamilyProperties2")]
	public static void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2KHR_0(physicalDevice, queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0 GetPhysicalDeviceQueueFamilyProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceQueueFamilyProperties2")]
	public static void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties) => GetPhysicalDeviceQueueFamilyProperties2KHR_1(physicalDevice, ref queueFamilyPropertyCount, queueFamilyProperties);
	private delegate void GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint queueFamilyPropertyCount, [In, Out] VkQueueFamilyProperties2KHR[] queueFamilyProperties);
	private static GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_1 GetPhysicalDeviceQueueFamilyProperties2KHR_1;
	[Obsolete("Use GetPhysicalDeviceMemoryProperties2")]
	public static void GetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2KHR memoryProperties) => GetPhysicalDeviceMemoryProperties2KHR_0(physicalDevice, out memoryProperties);
	private delegate void GetPhysicalDeviceMemoryProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, out VkPhysicalDeviceMemoryProperties2KHR memoryProperties);
	private static GetPhysicalDeviceMemoryProperties2KHRDelegate_0 GetPhysicalDeviceMemoryProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceSparseImageFormatProperties2")]
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_0(physicalDevice, formatInfo, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0 GetPhysicalDeviceSparseImageFormatProperties2KHR_0;
	[Obsolete("Use GetPhysicalDeviceSparseImageFormatProperties2")]
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_1(physicalDevice, formatInfo, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2KHR* formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_1 GetPhysicalDeviceSparseImageFormatProperties2KHR_1;
	[Obsolete("Use GetPhysicalDeviceSparseImageFormatProperties2")]
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_2(physicalDevice, ref formatInfo, propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, uint* propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_2 GetPhysicalDeviceSparseImageFormatProperties2KHR_2;
	[Obsolete("Use GetPhysicalDeviceSparseImageFormatProperties2")]
	public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties) => GetPhysicalDeviceSparseImageFormatProperties2KHR_3(physicalDevice, ref formatInfo, ref propertyCount, properties);
	private delegate void GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2KHR formatInfo, ref uint propertyCount, [In, Out] VkSparseImageFormatProperties2KHR[] properties);
	private static GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_3 GetPhysicalDeviceSparseImageFormatProperties2KHR_3;
	[Obsolete("Use GetDeviceGroupPeerMemoryFeatures")]
	public static void GetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlagsKHR peerMemoryFeatures) => GetDeviceGroupPeerMemoryFeaturesKHR_0(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out peerMemoryFeatures);
	private delegate void GetDeviceGroupPeerMemoryFeaturesKHRDelegate_0(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, out VkPeerMemoryFeatureFlagsKHR peerMemoryFeatures);
	private static GetDeviceGroupPeerMemoryFeaturesKHRDelegate_0 GetDeviceGroupPeerMemoryFeaturesKHR_0;
	[Obsolete("Use CommandSetDeviceMask")]
	public static void CommandSetDeviceMaskKHR(VkCommandBuffer commandBuffer, uint deviceMask) => CommandSetDeviceMaskKHR_0(commandBuffer, deviceMask);
	private delegate void CommandSetDeviceMaskKHRDelegate_0(VkCommandBuffer commandBuffer, uint deviceMask);
	private static CommandSetDeviceMaskKHRDelegate_0 CommandSetDeviceMaskKHR_0;
	[Obsolete("Use CommandDispatchBase")]
	public static void CommandDispatchBaseKHR(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) => CommandDispatchBaseKHR_0(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
	private delegate void CommandDispatchBaseKHRDelegate_0(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
	private static CommandDispatchBaseKHRDelegate_0 CommandDispatchBaseKHR_0;
	[Obsolete("Use TrimCommandPool")]
	public static void TrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlagsKHR flags) => TrimCommandPoolKHR_0(device, commandPool, flags);
	private delegate void TrimCommandPoolKHRDelegate_0(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlagsKHR flags);
	private static TrimCommandPoolKHRDelegate_0 TrimCommandPoolKHR_0;
	[Obsolete("Use EnumeratePhysicalDeviceGroups")]
	public static void EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHR[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroupsKHR_0(instance, physicalDeviceGroupCount, physicalDeviceGroupProperties);
	private delegate void EnumeratePhysicalDeviceGroupsKHRDelegate_0(VkInstance instance, uint* physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHR[] physicalDeviceGroupProperties);
	private static EnumeratePhysicalDeviceGroupsKHRDelegate_0 EnumeratePhysicalDeviceGroupsKHR_0;
	[Obsolete("Use EnumeratePhysicalDeviceGroups")]
	public static void EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHR[] physicalDeviceGroupProperties) => EnumeratePhysicalDeviceGroupsKHR_1(instance, ref physicalDeviceGroupCount, physicalDeviceGroupProperties);
	private delegate void EnumeratePhysicalDeviceGroupsKHRDelegate_1(VkInstance instance, ref uint physicalDeviceGroupCount, [In, Out] VkPhysicalDeviceGroupPropertiesKHR[] physicalDeviceGroupProperties);
	private static EnumeratePhysicalDeviceGroupsKHRDelegate_1 EnumeratePhysicalDeviceGroupsKHR_1;
	[Obsolete("Use GetPhysicalDeviceExternalBufferProperties")]
	public static void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfoKHR* externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties) => GetPhysicalDeviceExternalBufferPropertiesKHR_0(physicalDevice, externalBufferInfo, out externalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfoKHR* externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties);
	private static GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0 GetPhysicalDeviceExternalBufferPropertiesKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalBufferProperties")]
	public static void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfoKHR externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties) => GetPhysicalDeviceExternalBufferPropertiesKHR_1(physicalDevice, ref externalBufferInfo, out externalBufferProperties);
	private delegate void GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalBufferInfoKHR externalBufferInfo, out VkExternalBufferPropertiesKHR externalBufferProperties);
	private static GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_1 GetPhysicalDeviceExternalBufferPropertiesKHR_1;
	public static VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetMemoryWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
	public static bool GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle, out VkResult result)
	{
		result = GetMemoryWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryWin32HandleKHRDelegate_0(VkDevice device, VkMemoryGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
	private static GetMemoryWin32HandleKHRDelegate_0 GetMemoryWin32HandleKHR_0;
	public static VkResult GetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetMemoryWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
	public static bool GetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle, out VkResult result)
	{
		result = GetMemoryWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryWin32HandleKHRDelegate_1(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
	private static GetMemoryWin32HandleKHRDelegate_1 GetMemoryWin32HandleKHR_1;
	public static VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties) => GetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, out memoryWin32HandleProperties);
	public static bool GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties, out VkResult result)
	{
		result = GetMemoryWin32HandlePropertiesKHR_0(device, handleType, handle, out memoryWin32HandleProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryWin32HandlePropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, out VkMemoryWin32HandlePropertiesKHR memoryWin32HandleProperties);
	private static GetMemoryWin32HandlePropertiesKHRDelegate_0 GetMemoryWin32HandlePropertiesKHR_0;
	public static VkResult GetMemoryFileDescriptorKHR(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetMemoryFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
	public static bool GetMemoryFileDescriptorKHR(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor, out VkResult result)
	{
		result = GetMemoryFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryFileDescriptorKHRDelegate_0(VkDevice device, VkMemoryGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
	private static GetMemoryFileDescriptorKHRDelegate_0 GetMemoryFileDescriptorKHR_0;
	public static VkResult GetMemoryFileDescriptorKHR(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetMemoryFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
	public static bool GetMemoryFileDescriptorKHR(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor, out VkResult result)
	{
		result = GetMemoryFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryFileDescriptorKHRDelegate_1(VkDevice device, ref VkMemoryGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
	private static GetMemoryFileDescriptorKHRDelegate_1 GetMemoryFileDescriptorKHR_1;
	public static VkResult GetMemoryFileDescriptorPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties) => GetMemoryFileDescriptorPropertiesKHR_0(device, handleType, fileDescriptor, out memoryFileDescriptorProperties);
	public static bool GetMemoryFileDescriptorPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties, out VkResult result)
	{
		result = GetMemoryFileDescriptorPropertiesKHR_0(device, handleType, fileDescriptor, out memoryFileDescriptorProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryFileDescriptorPropertiesKHRDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fileDescriptor, out VkMemoryFdPropertiesKHR memoryFileDescriptorProperties);
	private static GetMemoryFileDescriptorPropertiesKHRDelegate_0 GetMemoryFileDescriptorPropertiesKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalSemaphoreProperties")]
	public static void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfoKHR* externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphorePropertiesKHR_0(physicalDevice, externalSemaphoreInfo, out externalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfoKHR* externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties);
	private static GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0 GetPhysicalDeviceExternalSemaphorePropertiesKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalSemaphoreProperties")]
	public static void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfoKHR externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties) => GetPhysicalDeviceExternalSemaphorePropertiesKHR_1(physicalDevice, ref externalSemaphoreInfo, out externalSemaphoreProperties);
	private delegate void GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfoKHR externalSemaphoreInfo, out VkExternalSemaphorePropertiesKHR externalSemaphoreProperties);
	private static GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_1 GetPhysicalDeviceExternalSemaphorePropertiesKHR_1;
	public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_0(device, importSemaphoreWin32HandleInfo);
	public static bool ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo, out VkResult result)
	{
		result = ImportSemaphoreWin32HandleKHR_0(device, importSemaphoreWin32HandleInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* importSemaphoreWin32HandleInfo);
	private static ImportSemaphoreWin32HandleKHRDelegate_0 ImportSemaphoreWin32HandleKHR_0;
	public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo) => ImportSemaphoreWin32HandleKHR_1(device, ref importSemaphoreWin32HandleInfo);
	public static bool ImportSemaphoreWin32HandleKHR(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo, out VkResult result)
	{
		result = ImportSemaphoreWin32HandleKHR_1(device, ref importSemaphoreWin32HandleInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportSemaphoreWin32HandleKHRDelegate_1(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR importSemaphoreWin32HandleInfo);
	private static ImportSemaphoreWin32HandleKHRDelegate_1 ImportSemaphoreWin32HandleKHR_1;
	public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetSemaphoreWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
	public static bool GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle, out VkResult result)
	{
		result = GetSemaphoreWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSemaphoreWin32HandleKHRDelegate_0(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
	private static GetSemaphoreWin32HandleKHRDelegate_0 GetSemaphoreWin32HandleKHR_0;
	public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetSemaphoreWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
	public static bool GetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle, out VkResult result)
	{
		result = GetSemaphoreWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSemaphoreWin32HandleKHRDelegate_1(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
	private static GetSemaphoreWin32HandleKHRDelegate_1 GetSemaphoreWin32HandleKHR_1;
	public static VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo) => ImportSemaphoreFileDescriptorKHR_0(device, importSemaphoreFileDescriptorInfo);
	public static bool ImportSemaphoreFileDescriptorKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo, out VkResult result)
	{
		result = ImportSemaphoreFileDescriptorKHR_0(device, importSemaphoreFileDescriptorInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkImportSemaphoreFdInfoKHR* importSemaphoreFileDescriptorInfo);
	private static ImportSemaphoreFileDescriptorKHRDelegate_0 ImportSemaphoreFileDescriptorKHR_0;
	public static VkResult ImportSemaphoreFileDescriptorKHR(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo) => ImportSemaphoreFileDescriptorKHR_1(device, ref importSemaphoreFileDescriptorInfo);
	public static bool ImportSemaphoreFileDescriptorKHR(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo, out VkResult result)
	{
		result = ImportSemaphoreFileDescriptorKHR_1(device, ref importSemaphoreFileDescriptorInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportSemaphoreFileDescriptorKHRDelegate_1(VkDevice device, ref VkImportSemaphoreFdInfoKHR importSemaphoreFileDescriptorInfo);
	private static ImportSemaphoreFileDescriptorKHRDelegate_1 ImportSemaphoreFileDescriptorKHR_1;
	public static VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetSemaphoreFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
	public static bool GetSemaphoreFileDescriptorKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor, out VkResult result)
	{
		result = GetSemaphoreFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_0(VkDevice device, VkSemaphoreGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
	private static GetSemaphoreFileDescriptorKHRDelegate_0 GetSemaphoreFileDescriptorKHR_0;
	public static VkResult GetSemaphoreFileDescriptorKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetSemaphoreFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
	public static bool GetSemaphoreFileDescriptorKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor, out VkResult result)
	{
		result = GetSemaphoreFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSemaphoreFileDescriptorKHRDelegate_1(VkDevice device, ref VkSemaphoreGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
	private static GetSemaphoreFileDescriptorKHRDelegate_1 GetSemaphoreFileDescriptorKHR_1;
	public static void CommandPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites) => CommandPushDescriptorSetKHR_0(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, descriptorWrites);
	private delegate void CommandPushDescriptorSetKHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet[] descriptorWrites);
	private static CommandPushDescriptorSetKHRDelegate_0 CommandPushDescriptorSetKHR_0;
	public static void CommandPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* data) => CommandPushDescriptorSetWithTemplateKHR_0(commandBuffer, descriptorUpdateTemplate, layout, set, data);
	private delegate void CommandPushDescriptorSetWithTemplateKHRDelegate_0(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* data);
	private static CommandPushDescriptorSetWithTemplateKHRDelegate_0 CommandPushDescriptorSetWithTemplateKHR_0;
	public static void CommandBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* conditionalRenderingBegin) => CommandBeginConditionalRenderingEXT_0(commandBuffer, conditionalRenderingBegin);
	private delegate void CommandBeginConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* conditionalRenderingBegin);
	private static CommandBeginConditionalRenderingEXTDelegate_0 CommandBeginConditionalRenderingEXT_0;
	public static void CommandBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, ref VkConditionalRenderingBeginInfoEXT conditionalRenderingBegin) => CommandBeginConditionalRenderingEXT_1(commandBuffer, ref conditionalRenderingBegin);
	private delegate void CommandBeginConditionalRenderingEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkConditionalRenderingBeginInfoEXT conditionalRenderingBegin);
	private static CommandBeginConditionalRenderingEXTDelegate_1 CommandBeginConditionalRenderingEXT_1;
	public static void CommandEndConditionalRenderingEXT(VkCommandBuffer commandBuffer) => CommandEndConditionalRenderingEXT_0(commandBuffer);
	private delegate void CommandEndConditionalRenderingEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandEndConditionalRenderingEXTDelegate_0 CommandEndConditionalRenderingEXT_0;
	[Obsolete("Use CreateDescriptorUpdateTemplate")]
	public static void CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_0(device, createInfo, allocator, out descriptorUpdateTemplate);
	private delegate void CreateDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_0 CreateDescriptorUpdateTemplateKHR_0;
	[Obsolete("Use CreateDescriptorUpdateTemplate")]
	public static void CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_1(device, createInfo, ref allocator, out descriptorUpdateTemplate);
	private delegate void CreateDescriptorUpdateTemplateKHRDelegate_1(VkDevice device, VkDescriptorUpdateTemplateCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_1 CreateDescriptorUpdateTemplateKHR_1;
	[Obsolete("Use CreateDescriptorUpdateTemplate")]
	public static void CreateDescriptorUpdateTemplateKHR(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_2(device, ref createInfo, allocator, out descriptorUpdateTemplate);
	private delegate void CreateDescriptorUpdateTemplateKHRDelegate_2(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_2 CreateDescriptorUpdateTemplateKHR_2;
	[Obsolete("Use CreateDescriptorUpdateTemplate")]
	public static void CreateDescriptorUpdateTemplateKHR(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate) => CreateDescriptorUpdateTemplateKHR_3(device, ref createInfo, ref allocator, out descriptorUpdateTemplate);
	private delegate void CreateDescriptorUpdateTemplateKHRDelegate_3(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate);
	private static CreateDescriptorUpdateTemplateKHRDelegate_3 CreateDescriptorUpdateTemplateKHR_3;
	[Obsolete("Use DestroyDescriptorUpdateTemplate")]
	public static void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkAllocationCallbacks* allocator) => DestroyDescriptorUpdateTemplateKHR_0(device, descriptorUpdateTemplate, allocator);
	private delegate void DestroyDescriptorUpdateTemplateKHRDelegate_0(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, VkAllocationCallbacks* allocator);
	private static DestroyDescriptorUpdateTemplateKHRDelegate_0 DestroyDescriptorUpdateTemplateKHR_0;
	[Obsolete("Use DestroyDescriptorUpdateTemplate")]
	public static void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, ref VkAllocationCallbacks allocator) => DestroyDescriptorUpdateTemplateKHR_1(device, descriptorUpdateTemplate, ref allocator);
	private delegate void DestroyDescriptorUpdateTemplateKHRDelegate_1(VkDevice device, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, ref VkAllocationCallbacks allocator);
	private static DestroyDescriptorUpdateTemplateKHRDelegate_1 DestroyDescriptorUpdateTemplateKHR_1;
	[Obsolete("Use UpdateDescriptorSetWithTemplate")]
	public static void UpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, void* data) => UpdateDescriptorSetWithTemplateKHR_0(device, descriptorSet, descriptorUpdateTemplate, data);
	private delegate void UpdateDescriptorSetWithTemplateKHRDelegate_0(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplateKHR descriptorUpdateTemplate, void* data);
	private static UpdateDescriptorSetWithTemplateKHRDelegate_0 UpdateDescriptorSetWithTemplateKHR_0;
	public static void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* viewportWScalings) => CommandSetViewportWScalingNV_0(commandBuffer, firstViewport, viewportCount, viewportWScalings);
	private delegate void CommandSetViewportWScalingNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* viewportWScalings);
	private static CommandSetViewportWScalingNVDelegate_0 CommandSetViewportWScalingNV_0;
	public static void CommandSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV viewportWScalings) => CommandSetViewportWScalingNV_1(commandBuffer, firstViewport, viewportCount, ref viewportWScalings);
	private delegate void CommandSetViewportWScalingNVDelegate_1(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV viewportWScalings);
	private static CommandSetViewportWScalingNVDelegate_1 CommandSetViewportWScalingNV_1;
	public static VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => ReleaseDisplayEXT_0(physicalDevice, display);
	public static bool ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display, out VkResult result)
	{
		result = ReleaseDisplayEXT_0(physicalDevice, display);
		return result == VkResult.Success;
	}
	private delegate VkResult ReleaseDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static ReleaseDisplayEXTDelegate_0 ReleaseDisplayEXT_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2EXT_0(physicalDevice, surface, out surfaceCapabilities);
	public static bool GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceCapabilities2EXT_0(physicalDevice, surface, out surfaceCapabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0 GetPhysicalDeviceSurfaceCapabilities2EXT_0;
	public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo) => DisplayPowerControlEXT_0(device, display, displayPowerInfo);
	public static bool DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo, out VkResult result)
	{
		result = DisplayPowerControlEXT_0(device, display, displayPowerInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult DisplayPowerControlEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* displayPowerInfo);
	private static DisplayPowerControlEXTDelegate_0 DisplayPowerControlEXT_0;
	public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo) => DisplayPowerControlEXT_1(device, display, ref displayPowerInfo);
	public static bool DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo, out VkResult result)
	{
		result = DisplayPowerControlEXT_1(device, display, ref displayPowerInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult DisplayPowerControlEXTDelegate_1(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT displayPowerInfo);
	private static DisplayPowerControlEXTDelegate_1 DisplayPowerControlEXT_1;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDeviceEventEXT_0(device, deviceEventInfo, allocator, fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_0(device, deviceEventInfo, allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_0(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_0 RegisterDeviceEventEXT_0;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDeviceEventEXT_1(device, deviceEventInfo, allocator, ref fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_1(device, deviceEventInfo, allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_1(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_1 RegisterDeviceEventEXT_1;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDeviceEventEXT_2(device, deviceEventInfo, ref allocator, fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_2(device, deviceEventInfo, ref allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_2(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_2 RegisterDeviceEventEXT_2;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDeviceEventEXT_3(device, deviceEventInfo, ref allocator, ref fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_3(device, deviceEventInfo, ref allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_3(VkDevice device, VkDeviceEventInfoEXT* deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_3 RegisterDeviceEventEXT_3;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDeviceEventEXT_4(device, ref deviceEventInfo, allocator, fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_4(device, ref deviceEventInfo, allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_4(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_4 RegisterDeviceEventEXT_4;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDeviceEventEXT_5(device, ref deviceEventInfo, allocator, ref fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_5(device, ref deviceEventInfo, allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_5(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_5 RegisterDeviceEventEXT_5;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDeviceEventEXT_6(device, ref deviceEventInfo, ref allocator, fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_6(device, ref deviceEventInfo, ref allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_6(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDeviceEventEXTDelegate_6 RegisterDeviceEventEXT_6;
	public static VkResult RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDeviceEventEXT_7(device, ref deviceEventInfo, ref allocator, ref fence);
	public static bool RegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDeviceEventEXT_7(device, ref deviceEventInfo, ref allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDeviceEventEXTDelegate_7(VkDevice device, ref VkDeviceEventInfoEXT deviceEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDeviceEventEXTDelegate_7 RegisterDeviceEventEXT_7;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDisplayEventEXT_0(device, display, displayEventInfo, allocator, fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_0(device, display, displayEventInfo, allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_0(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_0 RegisterDisplayEventEXT_0;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDisplayEventEXT_1(device, display, displayEventInfo, allocator, ref fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_1(device, display, displayEventInfo, allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_1(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_1 RegisterDisplayEventEXT_1;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDisplayEventEXT_2(device, display, displayEventInfo, ref allocator, fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_2(device, display, displayEventInfo, ref allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_2(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_2 RegisterDisplayEventEXT_2;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDisplayEventEXT_3(device, display, displayEventInfo, ref allocator, ref fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_3(device, display, displayEventInfo, ref allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_3(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_3 RegisterDisplayEventEXT_3;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => RegisterDisplayEventEXT_4(device, display, ref displayEventInfo, allocator, fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_4(device, display, ref displayEventInfo, allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_4(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_4 RegisterDisplayEventEXT_4;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence) => RegisterDisplayEventEXT_5(device, display, ref displayEventInfo, allocator, ref fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_5(device, display, ref displayEventInfo, allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_5(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, VkAllocationCallbacks* allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_5 RegisterDisplayEventEXT_5;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence) => RegisterDisplayEventEXT_6(device, display, ref displayEventInfo, ref allocator, fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_6(device, display, ref displayEventInfo, ref allocator, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_6(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, VkFence* fence);
	private static RegisterDisplayEventEXTDelegate_6 RegisterDisplayEventEXT_6;
	public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence) => RegisterDisplayEventEXT_7(device, display, ref displayEventInfo, ref allocator, ref fence);
	public static bool RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence, out VkResult result)
	{
		result = RegisterDisplayEventEXT_7(device, display, ref displayEventInfo, ref allocator, ref fence);
		return result == VkResult.Success;
	}
	private delegate VkResult RegisterDisplayEventEXTDelegate_7(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT displayEventInfo, ref VkAllocationCallbacks allocator, ref VkFence fence);
	private static RegisterDisplayEventEXTDelegate_7 RegisterDisplayEventEXT_7;
	public static VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue) => GetSwapchainCounterEXT_0(device, swapchain, counter, out counterValue);
	public static bool GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue, out VkResult result)
	{
		result = GetSwapchainCounterEXT_0(device, swapchain, counter, out counterValue);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSwapchainCounterEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong counterValue);
	private static GetSwapchainCounterEXTDelegate_0 GetSwapchainCounterEXT_0;
	public static VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties) => GetRefreshCycleDurationGOOGLE_0(device, swapchain, out displayTimingProperties);
	public static bool GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties, out VkResult result)
	{
		result = GetRefreshCycleDurationGOOGLE_0(device, swapchain, out displayTimingProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetRefreshCycleDurationGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE displayTimingProperties);
	private static GetRefreshCycleDurationGOOGLEDelegate_0 GetRefreshCycleDurationGOOGLE_0;
	public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings) => GetPastPresentationTimingGOOGLE_0(device, swapchain, presentationTimingCount, presentationTimings);
	public static bool GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings, out VkResult result)
	{
		result = GetPastPresentationTimingGOOGLE_0(device, swapchain, presentationTimingCount, presentationTimings);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPastPresentationTimingGOOGLEDelegate_0(VkDevice device, VkSwapchainKHR swapchain, uint* presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings);
	private static GetPastPresentationTimingGOOGLEDelegate_0 GetPastPresentationTimingGOOGLE_0;
	public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings) => GetPastPresentationTimingGOOGLE_1(device, swapchain, ref presentationTimingCount, presentationTimings);
	public static bool GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings, out VkResult result)
	{
		result = GetPastPresentationTimingGOOGLE_1(device, swapchain, ref presentationTimingCount, presentationTimings);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPastPresentationTimingGOOGLEDelegate_1(VkDevice device, VkSwapchainKHR swapchain, ref uint presentationTimingCount, [In, Out] VkPastPresentationTimingGOOGLE[] presentationTimings);
	private static GetPastPresentationTimingGOOGLEDelegate_1 GetPastPresentationTimingGOOGLE_1;
	public static void CommandSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D[] discardRectangles) => CommandSetDiscardRectangleEXT_0(commandBuffer, firstDiscardRectangle, discardRectangleCount, discardRectangles);
	private delegate void CommandSetDiscardRectangleEXTDelegate_0(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D[] discardRectangles);
	private static CommandSetDiscardRectangleEXTDelegate_0 CommandSetDiscardRectangleEXT_0;
	public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, VkHdrMetadataEXT* metadata) => SetHdrMetadataEXT_0(device, swapchainCount, swapchains, metadata);
	private delegate void SetHdrMetadataEXTDelegate_0(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, VkHdrMetadataEXT* metadata);
	private static SetHdrMetadataEXTDelegate_0 SetHdrMetadataEXT_0;
	public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, ref VkHdrMetadataEXT metadata) => SetHdrMetadataEXT_1(device, swapchainCount, swapchains, ref metadata);
	private delegate void SetHdrMetadataEXTDelegate_1(VkDevice device, uint swapchainCount, VkSwapchainKHR[] swapchains, ref VkHdrMetadataEXT metadata);
	private static SetHdrMetadataEXTDelegate_1 SetHdrMetadataEXT_1;
	[Obsolete("Use CreateRenderPass2")]
	public static void CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2KHR* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2KHR_0(device, createInfo, allocator, out renderPass);
	private delegate void CreateRenderPass2KHRDelegate_0(VkDevice device, VkRenderPassCreateInfo2KHR* createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2KHRDelegate_0 CreateRenderPass2KHR_0;
	[Obsolete("Use CreateRenderPass2")]
	public static void CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2KHR* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2KHR_1(device, createInfo, ref allocator, out renderPass);
	private delegate void CreateRenderPass2KHRDelegate_1(VkDevice device, VkRenderPassCreateInfo2KHR* createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2KHRDelegate_1 CreateRenderPass2KHR_1;
	[Obsolete("Use CreateRenderPass2")]
	public static void CreateRenderPass2KHR(VkDevice device, ref VkRenderPassCreateInfo2KHR createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass) => CreateRenderPass2KHR_2(device, ref createInfo, allocator, out renderPass);
	private delegate void CreateRenderPass2KHRDelegate_2(VkDevice device, ref VkRenderPassCreateInfo2KHR createInfo, VkAllocationCallbacks* allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2KHRDelegate_2 CreateRenderPass2KHR_2;
	[Obsolete("Use CreateRenderPass2")]
	public static void CreateRenderPass2KHR(VkDevice device, ref VkRenderPassCreateInfo2KHR createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass) => CreateRenderPass2KHR_3(device, ref createInfo, ref allocator, out renderPass);
	private delegate void CreateRenderPass2KHRDelegate_3(VkDevice device, ref VkRenderPassCreateInfo2KHR createInfo, ref VkAllocationCallbacks allocator, out VkRenderPass renderPass);
	private static CreateRenderPass2KHRDelegate_3 CreateRenderPass2KHR_3;
	[Obsolete("Use CommandBeginRenderPass2")]
	public static void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfoKHR* subpassBeginInfo) => CommandBeginRenderPass2KHR_0(commandBuffer, renderPassBegin, subpassBeginInfo);
	private delegate void CommandBeginRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, VkSubpassBeginInfoKHR* subpassBeginInfo);
	private static CommandBeginRenderPass2KHRDelegate_0 CommandBeginRenderPass2KHR_0;
	[Obsolete("Use CommandBeginRenderPass2")]
	public static void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfoKHR subpassBeginInfo) => CommandBeginRenderPass2KHR_1(commandBuffer, renderPassBegin, ref subpassBeginInfo);
	private delegate void CommandBeginRenderPass2KHRDelegate_1(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* renderPassBegin, ref VkSubpassBeginInfoKHR subpassBeginInfo);
	private static CommandBeginRenderPass2KHRDelegate_1 CommandBeginRenderPass2KHR_1;
	[Obsolete("Use CommandBeginRenderPass2")]
	public static void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfoKHR* subpassBeginInfo) => CommandBeginRenderPass2KHR_2(commandBuffer, ref renderPassBegin, subpassBeginInfo);
	private delegate void CommandBeginRenderPass2KHRDelegate_2(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, VkSubpassBeginInfoKHR* subpassBeginInfo);
	private static CommandBeginRenderPass2KHRDelegate_2 CommandBeginRenderPass2KHR_2;
	[Obsolete("Use CommandBeginRenderPass2")]
	public static void CommandBeginRenderPass2KHR(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfoKHR subpassBeginInfo) => CommandBeginRenderPass2KHR_3(commandBuffer, ref renderPassBegin, ref subpassBeginInfo);
	private delegate void CommandBeginRenderPass2KHRDelegate_3(VkCommandBuffer commandBuffer, ref VkRenderPassBeginInfo renderPassBegin, ref VkSubpassBeginInfoKHR subpassBeginInfo);
	private static CommandBeginRenderPass2KHRDelegate_3 CommandBeginRenderPass2KHR_3;
	[Obsolete("Use CommandNextSubpass2")]
	public static void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* subpassBeginInfo, VkSubpassEndInfoKHR* subpassEndInfo) => CommandNextSubpass2KHR_0(commandBuffer, subpassBeginInfo, subpassEndInfo);
	private delegate void CommandNextSubpass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* subpassBeginInfo, VkSubpassEndInfoKHR* subpassEndInfo);
	private static CommandNextSubpass2KHRDelegate_0 CommandNextSubpass2KHR_0;
	[Obsolete("Use CommandNextSubpass2")]
	public static void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* subpassBeginInfo, ref VkSubpassEndInfoKHR subpassEndInfo) => CommandNextSubpass2KHR_1(commandBuffer, subpassBeginInfo, ref subpassEndInfo);
	private delegate void CommandNextSubpass2KHRDelegate_1(VkCommandBuffer commandBuffer, VkSubpassBeginInfoKHR* subpassBeginInfo, ref VkSubpassEndInfoKHR subpassEndInfo);
	private static CommandNextSubpass2KHRDelegate_1 CommandNextSubpass2KHR_1;
	[Obsolete("Use CommandNextSubpass2")]
	public static void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfoKHR subpassBeginInfo, VkSubpassEndInfoKHR* subpassEndInfo) => CommandNextSubpass2KHR_2(commandBuffer, ref subpassBeginInfo, subpassEndInfo);
	private delegate void CommandNextSubpass2KHRDelegate_2(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfoKHR subpassBeginInfo, VkSubpassEndInfoKHR* subpassEndInfo);
	private static CommandNextSubpass2KHRDelegate_2 CommandNextSubpass2KHR_2;
	[Obsolete("Use CommandNextSubpass2")]
	public static void CommandNextSubpass2KHR(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfoKHR subpassBeginInfo, ref VkSubpassEndInfoKHR subpassEndInfo) => CommandNextSubpass2KHR_3(commandBuffer, ref subpassBeginInfo, ref subpassEndInfo);
	private delegate void CommandNextSubpass2KHRDelegate_3(VkCommandBuffer commandBuffer, ref VkSubpassBeginInfoKHR subpassBeginInfo, ref VkSubpassEndInfoKHR subpassEndInfo);
	private static CommandNextSubpass2KHRDelegate_3 CommandNextSubpass2KHR_3;
	[Obsolete("Use CommandEndRenderPass2")]
	public static void CommandEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfoKHR* subpassEndInfo) => CommandEndRenderPass2KHR_0(commandBuffer, subpassEndInfo);
	private delegate void CommandEndRenderPass2KHRDelegate_0(VkCommandBuffer commandBuffer, VkSubpassEndInfoKHR* subpassEndInfo);
	private static CommandEndRenderPass2KHRDelegate_0 CommandEndRenderPass2KHR_0;
	[Obsolete("Use CommandEndRenderPass2")]
	public static void CommandEndRenderPass2KHR(VkCommandBuffer commandBuffer, ref VkSubpassEndInfoKHR subpassEndInfo) => CommandEndRenderPass2KHR_1(commandBuffer, ref subpassEndInfo);
	private delegate void CommandEndRenderPass2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkSubpassEndInfoKHR subpassEndInfo);
	private static CommandEndRenderPass2KHRDelegate_1 CommandEndRenderPass2KHR_1;
	public static VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain) => GetSwapchainStatusKHR_0(device, swapchain);
	public static bool GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain, out VkResult result)
	{
		result = GetSwapchainStatusKHR_0(device, swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult GetSwapchainStatusKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static GetSwapchainStatusKHRDelegate_0 GetSwapchainStatusKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalFenceProperties")]
	public static void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfoKHR* externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties) => GetPhysicalDeviceExternalFencePropertiesKHR_0(physicalDevice, externalFenceInfo, out externalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfoKHR* externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties);
	private static GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0 GetPhysicalDeviceExternalFencePropertiesKHR_0;
	[Obsolete("Use GetPhysicalDeviceExternalFenceProperties")]
	public static void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfoKHR externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties) => GetPhysicalDeviceExternalFencePropertiesKHR_1(physicalDevice, ref externalFenceInfo, out externalFenceProperties);
	private delegate void GetPhysicalDeviceExternalFencePropertiesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceExternalFenceInfoKHR externalFenceInfo, out VkExternalFencePropertiesKHR externalFenceProperties);
	private static GetPhysicalDeviceExternalFencePropertiesKHRDelegate_1 GetPhysicalDeviceExternalFencePropertiesKHR_1;
	public static VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_0(device, importFenceWin32HandleInfo);
	public static bool ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo, out VkResult result)
	{
		result = ImportFenceWin32HandleKHR_0(device, importFenceWin32HandleInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportFenceWin32HandleKHRDelegate_0(VkDevice device, VkImportFenceWin32HandleInfoKHR* importFenceWin32HandleInfo);
	private static ImportFenceWin32HandleKHRDelegate_0 ImportFenceWin32HandleKHR_0;
	public static VkResult ImportFenceWin32HandleKHR(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo) => ImportFenceWin32HandleKHR_1(device, ref importFenceWin32HandleInfo);
	public static bool ImportFenceWin32HandleKHR(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo, out VkResult result)
	{
		result = ImportFenceWin32HandleKHR_1(device, ref importFenceWin32HandleInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportFenceWin32HandleKHRDelegate_1(VkDevice device, ref VkImportFenceWin32HandleInfoKHR importFenceWin32HandleInfo);
	private static ImportFenceWin32HandleKHRDelegate_1 ImportFenceWin32HandleKHR_1;
	public static VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle) => GetFenceWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
	public static bool GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle, out VkResult result)
	{
		result = GetFenceWin32HandleKHR_0(device, getWin32HandleInfo, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetFenceWin32HandleKHRDelegate_0(VkDevice device, VkFenceGetWin32HandleInfoKHR* getWin32HandleInfo, out IntPtr handle);
	private static GetFenceWin32HandleKHRDelegate_0 GetFenceWin32HandleKHR_0;
	public static VkResult GetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle) => GetFenceWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
	public static bool GetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle, out VkResult result)
	{
		result = GetFenceWin32HandleKHR_1(device, ref getWin32HandleInfo, out handle);
		return result == VkResult.Success;
	}
	private delegate VkResult GetFenceWin32HandleKHRDelegate_1(VkDevice device, ref VkFenceGetWin32HandleInfoKHR getWin32HandleInfo, out IntPtr handle);
	private static GetFenceWin32HandleKHRDelegate_1 GetFenceWin32HandleKHR_1;
	public static VkResult ImportFenceFileDescriptorKHR(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo) => ImportFenceFileDescriptorKHR_0(device, importFenceFileDescriptorInfo);
	public static bool ImportFenceFileDescriptorKHR(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo, out VkResult result)
	{
		result = ImportFenceFileDescriptorKHR_0(device, importFenceFileDescriptorInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportFenceFileDescriptorKHRDelegate_0(VkDevice device, VkImportFenceFdInfoKHR* importFenceFileDescriptorInfo);
	private static ImportFenceFileDescriptorKHRDelegate_0 ImportFenceFileDescriptorKHR_0;
	public static VkResult ImportFenceFileDescriptorKHR(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo) => ImportFenceFileDescriptorKHR_1(device, ref importFenceFileDescriptorInfo);
	public static bool ImportFenceFileDescriptorKHR(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo, out VkResult result)
	{
		result = ImportFenceFileDescriptorKHR_1(device, ref importFenceFileDescriptorInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult ImportFenceFileDescriptorKHRDelegate_1(VkDevice device, ref VkImportFenceFdInfoKHR importFenceFileDescriptorInfo);
	private static ImportFenceFileDescriptorKHRDelegate_1 ImportFenceFileDescriptorKHR_1;
	public static VkResult GetFenceFileDescriptorKHR(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor) => GetFenceFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
	public static bool GetFenceFileDescriptorKHR(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor, out VkResult result)
	{
		result = GetFenceFileDescriptorKHR_0(device, getFileDescriptorInfo, out fileDescriptor);
		return result == VkResult.Success;
	}
	private delegate VkResult GetFenceFileDescriptorKHRDelegate_0(VkDevice device, VkFenceGetFdInfoKHR* getFileDescriptorInfo, out int fileDescriptor);
	private static GetFenceFileDescriptorKHRDelegate_0 GetFenceFileDescriptorKHR_0;
	public static VkResult GetFenceFileDescriptorKHR(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor) => GetFenceFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
	public static bool GetFenceFileDescriptorKHR(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor, out VkResult result)
	{
		result = GetFenceFileDescriptorKHR_1(device, ref getFileDescriptorInfo, out fileDescriptor);
		return result == VkResult.Success;
	}
	private delegate VkResult GetFenceFileDescriptorKHRDelegate_1(VkDevice device, ref VkFenceGetFdInfoKHR getFileDescriptorInfo, out int fileDescriptor);
	private static GetFenceFileDescriptorKHRDelegate_1 GetFenceFileDescriptorKHR_1;
	public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions) => EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0(physicalDevice, queueFamilyIndex, counterCount, counters, counterDescriptions);
	public static bool EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions, out VkResult result)
	{
		result = EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0(physicalDevice, queueFamilyIndex, counterCount, counters, counterDescriptions);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions);
	private static EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0 EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0;
	public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions) => EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1(physicalDevice, queueFamilyIndex, ref counterCount, counters, counterDescriptions);
	public static bool EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions, out VkResult result)
	{
		result = EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1(physicalDevice, queueFamilyIndex, ref counterCount, counters, counterDescriptions);
		return result == VkResult.Success;
	}
	private delegate VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_1(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint counterCount, VkPerformanceCounterKHR[] counters, [In, Out] VkPerformanceCounterDescriptionKHR[] counterDescriptions);
	private static EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_1 EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1;
	public static void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* performanceQueryCreateInfo, out uint numPasses) => GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0(physicalDevice, performanceQueryCreateInfo, out numPasses);
	private delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* performanceQueryCreateInfo, out uint numPasses);
	private static GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0 GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0;
	public static void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR performanceQueryCreateInfo, out uint numPasses) => GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_1(physicalDevice, ref performanceQueryCreateInfo, out numPasses);
	private delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR performanceQueryCreateInfo, out uint numPasses);
	private static GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_1 GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_1;
	public static VkResult AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* info) => AcquireProfilingLockKHR_0(device, info);
	public static bool AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* info, out VkResult result)
	{
		result = AcquireProfilingLockKHR_0(device, info);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireProfilingLockKHRDelegate_0(VkDevice device, VkAcquireProfilingLockInfoKHR* info);
	private static AcquireProfilingLockKHRDelegate_0 AcquireProfilingLockKHR_0;
	public static VkResult AcquireProfilingLockKHR(VkDevice device, ref VkAcquireProfilingLockInfoKHR info) => AcquireProfilingLockKHR_1(device, ref info);
	public static bool AcquireProfilingLockKHR(VkDevice device, ref VkAcquireProfilingLockInfoKHR info, out VkResult result)
	{
		result = AcquireProfilingLockKHR_1(device, ref info);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireProfilingLockKHRDelegate_1(VkDevice device, ref VkAcquireProfilingLockInfoKHR info);
	private static AcquireProfilingLockKHRDelegate_1 AcquireProfilingLockKHR_1;
	public static void ReleaseProfilingLockKHR(VkDevice device) => ReleaseProfilingLockKHR_0(device);
	private delegate void ReleaseProfilingLockKHRDelegate_0(VkDevice device);
	private static ReleaseProfilingLockKHRDelegate_0 ReleaseProfilingLockKHR_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, surfaceInfo, out surfaceCapabilities);
	public static bool GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceCapabilities2KHR_0(physicalDevice, surfaceInfo, out surfaceCapabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0 GetPhysicalDeviceSurfaceCapabilities2KHR_0;
	public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities) => GetPhysicalDeviceSurfaceCapabilities2KHR_1(physicalDevice, ref surfaceInfo, out surfaceCapabilities);
	public static bool GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceCapabilities2KHR_1(physicalDevice, ref surfaceInfo, out surfaceCapabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkSurfaceCapabilities2KHR surfaceCapabilities);
	private static GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1 GetPhysicalDeviceSurfaceCapabilities2KHR_1;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, surfaceInfo, surfaceFormatCount, surfaceFormats);
	public static bool GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceFormats2KHR_0(physicalDevice, surfaceInfo, surfaceFormatCount, surfaceFormats);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_0 GetPhysicalDeviceSurfaceFormats2KHR_0;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_1(physicalDevice, surfaceInfo, ref surfaceFormatCount, surfaceFormats);
	public static bool GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceFormats2KHR_1(physicalDevice, surfaceInfo, ref surfaceFormatCount, surfaceFormats);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_1 GetPhysicalDeviceSurfaceFormats2KHR_1;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_2(physicalDevice, ref surfaceInfo, surfaceFormatCount, surfaceFormats);
	public static bool GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceFormats2KHR_2(physicalDevice, ref surfaceInfo, surfaceFormatCount, surfaceFormats);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_2 GetPhysicalDeviceSurfaceFormats2KHR_2;
	public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats) => GetPhysicalDeviceSurfaceFormats2KHR_3(physicalDevice, ref surfaceInfo, ref surfaceFormatCount, surfaceFormats);
	public static bool GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats, out VkResult result)
	{
		result = GetPhysicalDeviceSurfaceFormats2KHR_3(physicalDevice, ref surfaceInfo, ref surfaceFormatCount, surfaceFormats);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfaceFormats2KHRDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint surfaceFormatCount, [In, Out] VkSurfaceFormat2KHR[] surfaceFormats);
	private static GetPhysicalDeviceSurfaceFormats2KHRDelegate_3 GetPhysicalDeviceSurfaceFormats2KHR_3;
	public static VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayProperties2KHR[] properties) => GetPhysicalDeviceDisplayProperties2KHR_0(physicalDevice, propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayProperties2KHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayProperties2KHR_0(physicalDevice, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayProperties2KHR[] properties);
	private static GetPhysicalDeviceDisplayProperties2KHRDelegate_0 GetPhysicalDeviceDisplayProperties2KHR_0;
	public static VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayProperties2KHR[] properties) => GetPhysicalDeviceDisplayProperties2KHR_1(physicalDevice, ref propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayProperties2KHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayProperties2KHR_1(physicalDevice, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayProperties2KHR[] properties);
	private static GetPhysicalDeviceDisplayProperties2KHRDelegate_1 GetPhysicalDeviceDisplayProperties2KHR_1;
	public static VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties) => GetPhysicalDeviceDisplayPlaneProperties2KHR_0(physicalDevice, propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayPlaneProperties2KHR_0(physicalDevice, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties);
	private static GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0 GetPhysicalDeviceDisplayPlaneProperties2KHR_0;
	public static VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties) => GetPhysicalDeviceDisplayPlaneProperties2KHR_1(physicalDevice, ref propertyCount, properties);
	public static bool GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceDisplayPlaneProperties2KHR_1(physicalDevice, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkDisplayPlaneProperties2KHR[] properties);
	private static GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_1 GetPhysicalDeviceDisplayPlaneProperties2KHR_1;
	public static VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties) => GetDisplayModeProperties2KHR_0(physicalDevice, display, propertyCount, properties);
	public static bool GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties, out VkResult result)
	{
		result = GetDisplayModeProperties2KHR_0(physicalDevice, display, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayModeProperties2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties);
	private static GetDisplayModeProperties2KHRDelegate_0 GetDisplayModeProperties2KHR_0;
	public static VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties) => GetDisplayModeProperties2KHR_1(physicalDevice, display, ref propertyCount, properties);
	public static bool GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties, out VkResult result)
	{
		result = GetDisplayModeProperties2KHR_1(physicalDevice, display, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayModeProperties2KHRDelegate_1(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint propertyCount, [In, Out] VkDisplayModeProperties2KHR[] properties);
	private static GetDisplayModeProperties2KHRDelegate_1 GetDisplayModeProperties2KHR_1;
	public static VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities) => GetDisplayPlaneCapabilities2KHR_0(physicalDevice, displayPlaneInfo, out capabilities);
	public static bool GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities, out VkResult result)
	{
		result = GetDisplayPlaneCapabilities2KHR_0(physicalDevice, displayPlaneInfo, out capabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayPlaneCapabilities2KHRDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities);
	private static GetDisplayPlaneCapabilities2KHRDelegate_0 GetDisplayPlaneCapabilities2KHR_0;
	public static VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities) => GetDisplayPlaneCapabilities2KHR_1(physicalDevice, ref displayPlaneInfo, out capabilities);
	public static bool GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities, out VkResult result)
	{
		result = GetDisplayPlaneCapabilities2KHR_1(physicalDevice, ref displayPlaneInfo, out capabilities);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDisplayPlaneCapabilities2KHRDelegate_1(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR displayPlaneInfo, out VkDisplayPlaneCapabilities2KHR capabilities);
	private static GetDisplayPlaneCapabilities2KHRDelegate_1 GetDisplayPlaneCapabilities2KHR_1;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_0(instance, createInfo, allocator, out surface);
	public static bool CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateMacOSSurfaceMVK_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_0(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_0 CreateMacOSSurfaceMVK_0;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateMacOSSurfaceMVK_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_1(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_1 CreateMacOSSurfaceMVK_1;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateMacOSSurfaceMVK_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_2(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_2 CreateMacOSSurfaceMVK_2;
	public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateMacOSSurfaceMVK_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateMacOSSurfaceMVK_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateMacOSSurfaceMVKDelegate_3(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateMacOSSurfaceMVKDelegate_3 CreateMacOSSurfaceMVK_3;
	public static VkResult SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* nameInfo) => SetDebugUtilsObjectNameEXT_0(device, nameInfo);
	public static bool SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* nameInfo, out VkResult result)
	{
		result = SetDebugUtilsObjectNameEXT_0(device, nameInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult SetDebugUtilsObjectNameEXTDelegate_0(VkDevice device, VkDebugUtilsObjectNameInfoEXT* nameInfo);
	private static SetDebugUtilsObjectNameEXTDelegate_0 SetDebugUtilsObjectNameEXT_0;
	public static VkResult SetDebugUtilsObjectNameEXT(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT nameInfo) => SetDebugUtilsObjectNameEXT_1(device, ref nameInfo);
	public static bool SetDebugUtilsObjectNameEXT(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT nameInfo, out VkResult result)
	{
		result = SetDebugUtilsObjectNameEXT_1(device, ref nameInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult SetDebugUtilsObjectNameEXTDelegate_1(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT nameInfo);
	private static SetDebugUtilsObjectNameEXTDelegate_1 SetDebugUtilsObjectNameEXT_1;
	public static VkResult SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* tagInfo) => SetDebugUtilsObjectTagEXT_0(device, tagInfo);
	public static bool SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* tagInfo, out VkResult result)
	{
		result = SetDebugUtilsObjectTagEXT_0(device, tagInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult SetDebugUtilsObjectTagEXTDelegate_0(VkDevice device, VkDebugUtilsObjectTagInfoEXT* tagInfo);
	private static SetDebugUtilsObjectTagEXTDelegate_0 SetDebugUtilsObjectTagEXT_0;
	public static VkResult SetDebugUtilsObjectTagEXT(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT tagInfo) => SetDebugUtilsObjectTagEXT_1(device, ref tagInfo);
	public static bool SetDebugUtilsObjectTagEXT(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT tagInfo, out VkResult result)
	{
		result = SetDebugUtilsObjectTagEXT_1(device, ref tagInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult SetDebugUtilsObjectTagEXTDelegate_1(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT tagInfo);
	private static SetDebugUtilsObjectTagEXTDelegate_1 SetDebugUtilsObjectTagEXT_1;
	public static void QueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo) => QueueBeginDebugUtilsLabelEXT_0(queue, labelInfo);
	private delegate void QueueBeginDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo);
	private static QueueBeginDebugUtilsLabelEXTDelegate_0 QueueBeginDebugUtilsLabelEXT_0;
	public static void QueueBeginDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo) => QueueBeginDebugUtilsLabelEXT_1(queue, ref labelInfo);
	private delegate void QueueBeginDebugUtilsLabelEXTDelegate_1(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo);
	private static QueueBeginDebugUtilsLabelEXTDelegate_1 QueueBeginDebugUtilsLabelEXT_1;
	public static void QueueEndDebugUtilsLabelEXT(VkQueue queue) => QueueEndDebugUtilsLabelEXT_0(queue);
	private delegate void QueueEndDebugUtilsLabelEXTDelegate_0(VkQueue queue);
	private static QueueEndDebugUtilsLabelEXTDelegate_0 QueueEndDebugUtilsLabelEXT_0;
	public static void QueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo) => QueueInsertDebugUtilsLabelEXT_0(queue, labelInfo);
	private delegate void QueueInsertDebugUtilsLabelEXTDelegate_0(VkQueue queue, VkDebugUtilsLabelEXT* labelInfo);
	private static QueueInsertDebugUtilsLabelEXTDelegate_0 QueueInsertDebugUtilsLabelEXT_0;
	public static void QueueInsertDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo) => QueueInsertDebugUtilsLabelEXT_1(queue, ref labelInfo);
	private delegate void QueueInsertDebugUtilsLabelEXTDelegate_1(VkQueue queue, ref VkDebugUtilsLabelEXT labelInfo);
	private static QueueInsertDebugUtilsLabelEXTDelegate_1 QueueInsertDebugUtilsLabelEXT_1;
	public static void CommandBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo) => CommandBeginDebugUtilsLabelEXT_0(commandBuffer, labelInfo);
	private delegate void CommandBeginDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo);
	private static CommandBeginDebugUtilsLabelEXTDelegate_0 CommandBeginDebugUtilsLabelEXT_0;
	public static void CommandBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo) => CommandBeginDebugUtilsLabelEXT_1(commandBuffer, ref labelInfo);
	private delegate void CommandBeginDebugUtilsLabelEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo);
	private static CommandBeginDebugUtilsLabelEXTDelegate_1 CommandBeginDebugUtilsLabelEXT_1;
	public static void CommandEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer) => CommandEndDebugUtilsLabelEXT_0(commandBuffer);
	private delegate void CommandEndDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandEndDebugUtilsLabelEXTDelegate_0 CommandEndDebugUtilsLabelEXT_0;
	public static void CommandInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo) => CommandInsertDebugUtilsLabelEXT_0(commandBuffer, labelInfo);
	private delegate void CommandInsertDebugUtilsLabelEXTDelegate_0(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* labelInfo);
	private static CommandInsertDebugUtilsLabelEXTDelegate_0 CommandInsertDebugUtilsLabelEXT_0;
	public static void CommandInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo) => CommandInsertDebugUtilsLabelEXT_1(commandBuffer, ref labelInfo);
	private delegate void CommandInsertDebugUtilsLabelEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT labelInfo);
	private static CommandInsertDebugUtilsLabelEXTDelegate_1 CommandInsertDebugUtilsLabelEXT_1;
	public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_0(instance, createInfo, allocator, out messenger);
	public static bool CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger, out VkResult result)
	{
		result = CreateDebugUtilsMessengerEXT_0(instance, createInfo, allocator, out messenger);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger);
	private static CreateDebugUtilsMessengerEXTDelegate_0 CreateDebugUtilsMessengerEXT_0;
	public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_1(instance, createInfo, ref allocator, out messenger);
	public static bool CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger, out VkResult result)
	{
		result = CreateDebugUtilsMessengerEXT_1(instance, createInfo, ref allocator, out messenger);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugUtilsMessengerEXTDelegate_1(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger);
	private static CreateDebugUtilsMessengerEXTDelegate_1 CreateDebugUtilsMessengerEXT_1;
	public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_2(instance, ref createInfo, allocator, out messenger);
	public static bool CreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger, out VkResult result)
	{
		result = CreateDebugUtilsMessengerEXT_2(instance, ref createInfo, allocator, out messenger);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugUtilsMessengerEXTDelegate_2(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkDebugUtilsMessengerEXT messenger);
	private static CreateDebugUtilsMessengerEXTDelegate_2 CreateDebugUtilsMessengerEXT_2;
	public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger) => CreateDebugUtilsMessengerEXT_3(instance, ref createInfo, ref allocator, out messenger);
	public static bool CreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger, out VkResult result)
	{
		result = CreateDebugUtilsMessengerEXT_3(instance, ref createInfo, ref allocator, out messenger);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDebugUtilsMessengerEXTDelegate_3(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkDebugUtilsMessengerEXT messenger);
	private static CreateDebugUtilsMessengerEXTDelegate_3 CreateDebugUtilsMessengerEXT_3;
	public static void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* allocator) => DestroyDebugUtilsMessengerEXT_0(instance, messenger, allocator);
	private delegate void DestroyDebugUtilsMessengerEXTDelegate_0(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* allocator);
	private static DestroyDebugUtilsMessengerEXTDelegate_0 DestroyDebugUtilsMessengerEXT_0;
	public static void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, ref VkAllocationCallbacks allocator) => DestroyDebugUtilsMessengerEXT_1(instance, messenger, ref allocator);
	private delegate void DestroyDebugUtilsMessengerEXTDelegate_1(VkInstance instance, VkDebugUtilsMessengerEXT messenger, ref VkAllocationCallbacks allocator);
	private static DestroyDebugUtilsMessengerEXTDelegate_1 DestroyDebugUtilsMessengerEXT_1;
	public static void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData) => SubmitDebugUtilsMessageEXT_0(instance, messageSeverity, messageTypes, callbackData);
	private delegate void SubmitDebugUtilsMessageEXTDelegate_0(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* callbackData);
	private static SubmitDebugUtilsMessageEXTDelegate_0 SubmitDebugUtilsMessageEXT_0;
	public static void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, ref VkDebugUtilsMessengerCallbackDataEXT callbackData) => SubmitDebugUtilsMessageEXT_1(instance, messageSeverity, messageTypes, ref callbackData);
	private delegate void SubmitDebugUtilsMessageEXTDelegate_1(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, ref VkDebugUtilsMessengerCallbackDataEXT callbackData);
	private static SubmitDebugUtilsMessageEXTDelegate_1 SubmitDebugUtilsMessageEXT_1;
	public static VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, void* buffer, out VkAndroidHardwareBufferPropertiesANDROID properties) => GetAndroidHardwareBufferPropertiesANDROID_0(device, buffer, out properties);
	public static bool GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, void* buffer, out VkAndroidHardwareBufferPropertiesANDROID properties, out VkResult result)
	{
		result = GetAndroidHardwareBufferPropertiesANDROID_0(device, buffer, out properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetAndroidHardwareBufferPropertiesANDROIDDelegate_0(VkDevice device, void* buffer, out VkAndroidHardwareBufferPropertiesANDROID properties);
	private static GetAndroidHardwareBufferPropertiesANDROIDDelegate_0 GetAndroidHardwareBufferPropertiesANDROID_0;
	public static VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* info, void** buffer) => GetMemoryAndroidHardwareBufferANDROID_0(device, info, buffer);
	public static bool GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* info, void** buffer, out VkResult result)
	{
		result = GetMemoryAndroidHardwareBufferANDROID_0(device, info, buffer);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryAndroidHardwareBufferANDROIDDelegate_0(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* info, void** buffer);
	private static GetMemoryAndroidHardwareBufferANDROIDDelegate_0 GetMemoryAndroidHardwareBufferANDROID_0;
	public static VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID info, void** buffer) => GetMemoryAndroidHardwareBufferANDROID_1(device, ref info, buffer);
	public static bool GetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID info, void** buffer, out VkResult result)
	{
		result = GetMemoryAndroidHardwareBufferANDROID_1(device, ref info, buffer);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryAndroidHardwareBufferANDROIDDelegate_1(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID info, void** buffer);
	private static GetMemoryAndroidHardwareBufferANDROIDDelegate_1 GetMemoryAndroidHardwareBufferANDROID_1;
	public static void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* sampleLocationsInfo) => CommandSetSampleLocationsEXT_0(commandBuffer, sampleLocationsInfo);
	private delegate void CommandSetSampleLocationsEXTDelegate_0(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* sampleLocationsInfo);
	private static CommandSetSampleLocationsEXTDelegate_0 CommandSetSampleLocationsEXT_0;
	public static void CommandSetSampleLocationsEXT(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT sampleLocationsInfo) => CommandSetSampleLocationsEXT_1(commandBuffer, ref sampleLocationsInfo);
	private delegate void CommandSetSampleLocationsEXTDelegate_1(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT sampleLocationsInfo);
	private static CommandSetSampleLocationsEXTDelegate_1 CommandSetSampleLocationsEXT_1;
	public static void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT multisampleProperties) => GetPhysicalDeviceMultisamplePropertiesEXT_0(physicalDevice, samples, out multisampleProperties);
	private delegate void GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT multisampleProperties);
	private static GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0 GetPhysicalDeviceMultisamplePropertiesEXT_0;
	[Obsolete("Use GetImageMemoryRequirements2")]
	public static void GetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements) => GetImageMemoryRequirements2KHR_0(device, info, out memoryRequirements);
	private delegate void GetImageMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetImageMemoryRequirements2KHRDelegate_0 GetImageMemoryRequirements2KHR_0;
	[Obsolete("Use GetImageMemoryRequirements2")]
	public static void GetImageMemoryRequirements2KHR(VkDevice device, ref VkImageMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements) => GetImageMemoryRequirements2KHR_1(device, ref info, out memoryRequirements);
	private delegate void GetImageMemoryRequirements2KHRDelegate_1(VkDevice device, ref VkImageMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetImageMemoryRequirements2KHRDelegate_1 GetImageMemoryRequirements2KHR_1;
	[Obsolete("Use GetBufferMemoryRequirements2")]
	public static void GetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements) => GetBufferMemoryRequirements2KHR_0(device, info, out memoryRequirements);
	private delegate void GetBufferMemoryRequirements2KHRDelegate_0(VkDevice device, VkBufferMemoryRequirementsInfo2KHR* info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetBufferMemoryRequirements2KHRDelegate_0 GetBufferMemoryRequirements2KHR_0;
	[Obsolete("Use GetBufferMemoryRequirements2")]
	public static void GetBufferMemoryRequirements2KHR(VkDevice device, ref VkBufferMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements) => GetBufferMemoryRequirements2KHR_1(device, ref info, out memoryRequirements);
	private delegate void GetBufferMemoryRequirements2KHRDelegate_1(VkDevice device, ref VkBufferMemoryRequirementsInfo2KHR info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetBufferMemoryRequirements2KHRDelegate_1 GetBufferMemoryRequirements2KHR_1;
	[Obsolete("Use GetImageSparseMemoryRequirements2")]
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_0(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_0(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_0 GetImageSparseMemoryRequirements2KHR_0;
	[Obsolete("Use GetImageSparseMemoryRequirements2")]
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_1(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_1(VkDevice device, VkImageSparseMemoryRequirementsInfo2KHR* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_1 GetImageSparseMemoryRequirements2KHR_1;
	[Obsolete("Use GetImageSparseMemoryRequirements2")]
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_2(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_2 GetImageSparseMemoryRequirements2KHR_2;
	[Obsolete("Use GetImageSparseMemoryRequirements2")]
	public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements) => GetImageSparseMemoryRequirements2KHR_3(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetImageSparseMemoryRequirements2KHRDelegate_3(VkDevice device, ref VkImageSparseMemoryRequirementsInfo2KHR info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2KHR[] sparseMemoryRequirements);
	private static GetImageSparseMemoryRequirements2KHRDelegate_3 GetImageSparseMemoryRequirements2KHR_3;
	public static VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_0(device, createInfo, allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureKHR_0(device, createInfo, allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureKHRDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure);
	private static CreateAccelerationStructureKHRDelegate_0 CreateAccelerationStructureKHR_0;
	public static VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_1(device, createInfo, ref allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureKHR_1(device, createInfo, ref allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureKHRDelegate_1(VkDevice device, VkAccelerationStructureCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure);
	private static CreateAccelerationStructureKHRDelegate_1 CreateAccelerationStructureKHR_1;
	public static VkResult CreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_2(device, ref createInfo, allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureKHR_2(device, ref createInfo, allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureKHRDelegate_2(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureKHR accelerationStructure);
	private static CreateAccelerationStructureKHRDelegate_2 CreateAccelerationStructureKHR_2;
	public static VkResult CreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure) => CreateAccelerationStructureKHR_3(device, ref createInfo, ref allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureKHR_3(device, ref createInfo, ref allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureKHRDelegate_3(VkDevice device, ref VkAccelerationStructureCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureKHR accelerationStructure);
	private static CreateAccelerationStructureKHRDelegate_3 CreateAccelerationStructureKHR_3;
	public static void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* allocator) => DestroyAccelerationStructureKHR_0(device, accelerationStructure, allocator);
	private delegate void DestroyAccelerationStructureKHRDelegate_0(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* allocator);
	private static DestroyAccelerationStructureKHRDelegate_0 DestroyAccelerationStructureKHR_0;
	public static void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, ref VkAllocationCallbacks allocator) => DestroyAccelerationStructureKHR_1(device, accelerationStructure, ref allocator);
	private delegate void DestroyAccelerationStructureKHRDelegate_1(VkDevice device, VkAccelerationStructureKHR accelerationStructure, ref VkAllocationCallbacks allocator);
	private static DestroyAccelerationStructureKHRDelegate_1 DestroyAccelerationStructureKHR_1;
	public static void CommandBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] buildRangeInfos) => CommandBuildAccelerationStructuresKHR_0(commandBuffer, infoCount, infos, buildRangeInfos);
	private delegate void CommandBuildAccelerationStructuresKHRDelegate_0(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] buildRangeInfos);
	private static CommandBuildAccelerationStructuresKHRDelegate_0 CommandBuildAccelerationStructuresKHR_0;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_0(commandBuffer, infoCount, infos, indirectDeviceAddresses, indirectStrides, maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_0(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_0 CommandBuildAccelerationStructuresIndirectKHR_0;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, ref uint maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_1(commandBuffer, infoCount, infos, indirectDeviceAddresses, indirectStrides, ref maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_1(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, uint* indirectStrides, ref uint maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_1 CommandBuildAccelerationStructuresIndirectKHR_1;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_2(commandBuffer, infoCount, infos, indirectDeviceAddresses, ref indirectStrides, maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_2(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_2 CommandBuildAccelerationStructuresIndirectKHR_2;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, ref uint maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_3(commandBuffer, infoCount, infos, indirectDeviceAddresses, ref indirectStrides, ref maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_3(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkDeviceAddress* indirectDeviceAddresses, ref uint indirectStrides, ref uint maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_3 CommandBuildAccelerationStructuresIndirectKHR_3;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_4(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, indirectStrides, maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_4(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, uint** maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_4 CommandBuildAccelerationStructuresIndirectKHR_4;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, ref uint maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_5(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, indirectStrides, ref maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_5(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, uint* indirectStrides, ref uint maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_5 CommandBuildAccelerationStructuresIndirectKHR_5;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_6(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, ref indirectStrides, maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_6(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, uint** maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_6 CommandBuildAccelerationStructuresIndirectKHR_6;
	public static void CommandBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, ref uint maxPrimitiveCounts) => CommandBuildAccelerationStructuresIndirectKHR_7(commandBuffer, infoCount, infos, ref indirectDeviceAddresses, ref indirectStrides, ref maxPrimitiveCounts);
	private delegate void CommandBuildAccelerationStructuresIndirectKHRDelegate_7(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, ref VkDeviceAddress indirectDeviceAddresses, ref uint indirectStrides, ref uint maxPrimitiveCounts);
	private static CommandBuildAccelerationStructuresIndirectKHRDelegate_7 CommandBuildAccelerationStructuresIndirectKHR_7;
	public static VkResult BuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] buildRangeInfos) => BuildAccelerationStructuresKHR_0(device, deferredOperation, infoCount, infos, buildRangeInfos);
	public static bool BuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] buildRangeInfos, out VkResult result)
	{
		result = BuildAccelerationStructuresKHR_0(device, deferredOperation, infoCount, infos, buildRangeInfos);
		return result == VkResult.Success;
	}
	private delegate VkResult BuildAccelerationStructuresKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] infos, VkAccelerationStructureBuildRangeInfoKHR[] buildRangeInfos);
	private static BuildAccelerationStructuresKHRDelegate_0 BuildAccelerationStructuresKHR_0;
	public static VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* info) => CopyAccelerationStructureKHR_0(device, deferredOperation, info);
	public static bool CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* info, out VkResult result)
	{
		result = CopyAccelerationStructureKHR_0(device, deferredOperation, info);
		return result == VkResult.Success;
	}
	private delegate VkResult CopyAccelerationStructureKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* info);
	private static CopyAccelerationStructureKHRDelegate_0 CopyAccelerationStructureKHR_0;
	public static VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR info) => CopyAccelerationStructureKHR_1(device, deferredOperation, ref info);
	public static bool CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR info, out VkResult result)
	{
		result = CopyAccelerationStructureKHR_1(device, deferredOperation, ref info);
		return result == VkResult.Success;
	}
	private delegate VkResult CopyAccelerationStructureKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR info);
	private static CopyAccelerationStructureKHRDelegate_1 CopyAccelerationStructureKHR_1;
	public static VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* info) => CopyAccelerationStructureToMemoryKHR_0(device, deferredOperation, info);
	public static bool CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* info, out VkResult result)
	{
		result = CopyAccelerationStructureToMemoryKHR_0(device, deferredOperation, info);
		return result == VkResult.Success;
	}
	private delegate VkResult CopyAccelerationStructureToMemoryKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* info);
	private static CopyAccelerationStructureToMemoryKHRDelegate_0 CopyAccelerationStructureToMemoryKHR_0;
	public static VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR info) => CopyAccelerationStructureToMemoryKHR_1(device, deferredOperation, ref info);
	public static bool CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR info, out VkResult result)
	{
		result = CopyAccelerationStructureToMemoryKHR_1(device, deferredOperation, ref info);
		return result == VkResult.Success;
	}
	private delegate VkResult CopyAccelerationStructureToMemoryKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR info);
	private static CopyAccelerationStructureToMemoryKHRDelegate_1 CopyAccelerationStructureToMemoryKHR_1;
	public static VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* info) => CopyMemoryToAccelerationStructureKHR_0(device, deferredOperation, info);
	public static bool CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* info, out VkResult result)
	{
		result = CopyMemoryToAccelerationStructureKHR_0(device, deferredOperation, info);
		return result == VkResult.Success;
	}
	private delegate VkResult CopyMemoryToAccelerationStructureKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* info);
	private static CopyMemoryToAccelerationStructureKHRDelegate_0 CopyMemoryToAccelerationStructureKHR_0;
	public static VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR info) => CopyMemoryToAccelerationStructureKHR_1(device, deferredOperation, ref info);
	public static bool CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR info, out VkResult result)
	{
		result = CopyMemoryToAccelerationStructureKHR_1(device, deferredOperation, ref info);
		return result == VkResult.Success;
	}
	private delegate VkResult CopyMemoryToAccelerationStructureKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR info);
	private static CopyMemoryToAccelerationStructureKHRDelegate_1 CopyMemoryToAccelerationStructureKHR_1;
	public static VkResult WriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, nuint dataSize, void* data, nuint stride) => WriteAccelerationStructuresPropertiesKHR_0(device, accelerationStructureCount, accelerationStructures, queryType, dataSize, data, stride);
	public static bool WriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, nuint dataSize, void* data, nuint stride, out VkResult result)
	{
		result = WriteAccelerationStructuresPropertiesKHR_0(device, accelerationStructureCount, accelerationStructures, queryType, dataSize, data, stride);
		return result == VkResult.Success;
	}
	private delegate VkResult WriteAccelerationStructuresPropertiesKHRDelegate_0(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, nuint dataSize, void* data, nuint stride);
	private static WriteAccelerationStructuresPropertiesKHRDelegate_0 WriteAccelerationStructuresPropertiesKHR_0;
	public static void CommandCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* info) => CommandCopyAccelerationStructureKHR_0(commandBuffer, info);
	private delegate void CommandCopyAccelerationStructureKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* info);
	private static CommandCopyAccelerationStructureKHRDelegate_0 CommandCopyAccelerationStructureKHR_0;
	public static void CommandCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureInfoKHR info) => CommandCopyAccelerationStructureKHR_1(commandBuffer, ref info);
	private delegate void CommandCopyAccelerationStructureKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureInfoKHR info);
	private static CommandCopyAccelerationStructureKHRDelegate_1 CommandCopyAccelerationStructureKHR_1;
	public static void CommandCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* info) => CommandCopyAccelerationStructureToMemoryKHR_0(commandBuffer, info);
	private delegate void CommandCopyAccelerationStructureToMemoryKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* info);
	private static CommandCopyAccelerationStructureToMemoryKHRDelegate_0 CommandCopyAccelerationStructureToMemoryKHR_0;
	public static void CommandCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureToMemoryInfoKHR info) => CommandCopyAccelerationStructureToMemoryKHR_1(commandBuffer, ref info);
	private delegate void CommandCopyAccelerationStructureToMemoryKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureToMemoryInfoKHR info);
	private static CommandCopyAccelerationStructureToMemoryKHRDelegate_1 CommandCopyAccelerationStructureToMemoryKHR_1;
	public static void CommandCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* info) => CommandCopyMemoryToAccelerationStructureKHR_0(commandBuffer, info);
	private delegate void CommandCopyMemoryToAccelerationStructureKHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* info);
	private static CommandCopyMemoryToAccelerationStructureKHRDelegate_0 CommandCopyMemoryToAccelerationStructureKHR_0;
	public static void CommandCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyMemoryToAccelerationStructureInfoKHR info) => CommandCopyMemoryToAccelerationStructureKHR_1(commandBuffer, ref info);
	private delegate void CommandCopyMemoryToAccelerationStructureKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyMemoryToAccelerationStructureInfoKHR info);
	private static CommandCopyMemoryToAccelerationStructureKHRDelegate_1 CommandCopyMemoryToAccelerationStructureKHR_1;
	public static VkDeviceAddress GetAccelerationStructureDeviceAddressKHR(VkDevice device, out VkAccelerationStructureDeviceAddressInfoKHR info) => GetAccelerationStructureDeviceAddressKHR_0(device, out info);
	private delegate VkDeviceAddress GetAccelerationStructureDeviceAddressKHRDelegate_0(VkDevice device, out VkAccelerationStructureDeviceAddressInfoKHR info);
	private static GetAccelerationStructureDeviceAddressKHRDelegate_0 GetAccelerationStructureDeviceAddressKHR_0;
	public static void CommandWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery) => CommandWriteAccelerationStructuresPropertiesKHR_0(commandBuffer, accelerationStructureCount, accelerationStructures, queryType, queryPool, firstQuery);
	private delegate void CommandWriteAccelerationStructuresPropertiesKHRDelegate_0(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
	private static CommandWriteAccelerationStructuresPropertiesKHRDelegate_0 CommandWriteAccelerationStructuresPropertiesKHR_0;
	public static void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility) => GetDeviceAccelerationStructureCompatibilityKHR_0(device, versionInfo, out compatibility);
	private delegate void GetDeviceAccelerationStructureCompatibilityKHRDelegate_0(VkDevice device, VkAccelerationStructureVersionInfoKHR* versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility);
	private static GetDeviceAccelerationStructureCompatibilityKHRDelegate_0 GetDeviceAccelerationStructureCompatibilityKHR_0;
	public static void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, ref VkAccelerationStructureVersionInfoKHR versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility) => GetDeviceAccelerationStructureCompatibilityKHR_1(device, ref versionInfo, out compatibility);
	private delegate void GetDeviceAccelerationStructureCompatibilityKHRDelegate_1(VkDevice device, ref VkAccelerationStructureVersionInfoKHR versionInfo, out VkAccelerationStructureCompatibilityKHR compatibility);
	private static GetDeviceAccelerationStructureCompatibilityKHRDelegate_1 GetDeviceAccelerationStructureCompatibilityKHR_1;
	public static void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, uint* maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo) => GetAccelerationStructureBuildSizesKHR_0(device, buildType, buildInfo, maxPrimitiveCounts, out sizeInfo);
	private delegate void GetAccelerationStructureBuildSizesKHRDelegate_0(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, uint* maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo);
	private static GetAccelerationStructureBuildSizesKHRDelegate_0 GetAccelerationStructureBuildSizesKHR_0;
	public static void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, ref uint maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo) => GetAccelerationStructureBuildSizesKHR_1(device, buildType, buildInfo, ref maxPrimitiveCounts, out sizeInfo);
	private delegate void GetAccelerationStructureBuildSizesKHRDelegate_1(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* buildInfo, ref uint maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo);
	private static GetAccelerationStructureBuildSizesKHRDelegate_1 GetAccelerationStructureBuildSizesKHR_1;
	public static void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, uint* maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo) => GetAccelerationStructureBuildSizesKHR_2(device, buildType, ref buildInfo, maxPrimitiveCounts, out sizeInfo);
	private delegate void GetAccelerationStructureBuildSizesKHRDelegate_2(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, uint* maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo);
	private static GetAccelerationStructureBuildSizesKHRDelegate_2 GetAccelerationStructureBuildSizesKHR_2;
	public static void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, ref uint maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo) => GetAccelerationStructureBuildSizesKHR_3(device, buildType, ref buildInfo, ref maxPrimitiveCounts, out sizeInfo);
	private delegate void GetAccelerationStructureBuildSizesKHRDelegate_3(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR buildInfo, ref uint maxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR sizeInfo);
	private static GetAccelerationStructureBuildSizesKHRDelegate_3 GetAccelerationStructureBuildSizesKHR_3;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_0(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_0(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_0 CommandTraceRaysKHR_0;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_1(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_1(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_1 CommandTraceRaysKHR_1;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_2(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_2(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_2 CommandTraceRaysKHR_2;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_3(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_3(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_3 CommandTraceRaysKHR_3;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_4(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_4(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_4 CommandTraceRaysKHR_4;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_5(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_5(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_5 CommandTraceRaysKHR_5;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_6(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_6(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_6 CommandTraceRaysKHR_6;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_7(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_7(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_7 CommandTraceRaysKHR_7;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_8(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_8(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_8 CommandTraceRaysKHR_8;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_9(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_9(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_9 CommandTraceRaysKHR_9;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_10(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_10(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_10 CommandTraceRaysKHR_10;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_11(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_11(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_11 CommandTraceRaysKHR_11;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_12(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_12(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_12 CommandTraceRaysKHR_12;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_13(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_13(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_13 CommandTraceRaysKHR_13;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_14(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_14(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_14 CommandTraceRaysKHR_14;
	public static void CommandTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth) => CommandTraceRaysKHR_15(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, width, height, depth);
	private delegate void CommandTraceRaysKHRDelegate_15(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, uint width, uint height, uint depth);
	private static CommandTraceRaysKHRDelegate_15 CommandTraceRaysKHR_15;
	public static VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesKHR_0(device, deferredOperation, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
	public static bool CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateRayTracingPipelinesKHR_0(device, deferredOperation, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRayTracingPipelinesKHRDelegate_0(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
	private static CreateRayTracingPipelinesKHRDelegate_0 CreateRayTracingPipelinesKHR_0;
	public static VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesKHR_1(device, deferredOperation, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
	public static bool CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateRayTracingPipelinesKHR_1(device, deferredOperation, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRayTracingPipelinesKHRDelegate_1(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
	private static CreateRayTracingPipelinesKHRDelegate_1 CreateRayTracingPipelinesKHR_1;
	public static VkResult GetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data) => GetRayTracingShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, data);
	public static bool GetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data, out VkResult result)
	{
		result = GetRayTracingShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetRayTracingShaderGroupHandlesKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data);
	private static GetRayTracingShaderGroupHandlesKHRDelegate_0 GetRayTracingShaderGroupHandlesKHR_0;
	public static VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data) => GetRayTracingCaptureReplayShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, data);
	public static bool GetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data, out VkResult result)
	{
		result = GetRayTracingCaptureReplayShaderGroupHandlesKHR_0(device, pipeline, firstGroup, groupCount, dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data);
	private static GetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0 GetRayTracingCaptureReplayShaderGroupHandlesKHR_0;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_0(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_0(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_0 CommandTraceRaysIndirectKHR_0;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_1(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_1(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_1 CommandTraceRaysIndirectKHR_1;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_2(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_2(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_2 CommandTraceRaysIndirectKHR_2;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_3(commandBuffer, raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_3(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_3 CommandTraceRaysIndirectKHR_3;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_4(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_4(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_4 CommandTraceRaysIndirectKHR_4;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_5(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_5(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_5 CommandTraceRaysIndirectKHR_5;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_6(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_6(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_6 CommandTraceRaysIndirectKHR_6;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_7(commandBuffer, raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_7(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_7 CommandTraceRaysIndirectKHR_7;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_8(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_8(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_8 CommandTraceRaysIndirectKHR_8;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_9(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_9(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_9 CommandTraceRaysIndirectKHR_9;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_10(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_10(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_10 CommandTraceRaysIndirectKHR_10;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_11(commandBuffer, ref raygenShaderBindingTable, missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_11(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_11 CommandTraceRaysIndirectKHR_11;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_12(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_12(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_12 CommandTraceRaysIndirectKHR_12;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_13(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_13(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, VkStridedDeviceAddressRegionKHR* hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_13 CommandTraceRaysIndirectKHR_13;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_14(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_14(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, VkStridedDeviceAddressRegionKHR* callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_14 CommandTraceRaysIndirectKHR_14;
	public static void CommandTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress) => CommandTraceRaysIndirectKHR_15(commandBuffer, ref raygenShaderBindingTable, ref missShaderBindingTable, ref hitShaderBindingTable, ref callableShaderBindingTable, indirectDeviceAddress);
	private delegate void CommandTraceRaysIndirectKHRDelegate_15(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR raygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR missShaderBindingTable, ref VkStridedDeviceAddressRegionKHR hitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR callableShaderBindingTable, VkDeviceAddress indirectDeviceAddress);
	private static CommandTraceRaysIndirectKHRDelegate_15 CommandTraceRaysIndirectKHR_15;
	public static VkDeviceSize GetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader) => GetRayTracingShaderGroupStackSizeKHR_0(device, pipeline, group, groupShader);
	private delegate VkDeviceSize GetRayTracingShaderGroupStackSizeKHRDelegate_0(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader);
	private static GetRayTracingShaderGroupStackSizeKHRDelegate_0 GetRayTracingShaderGroupStackSizeKHR_0;
	public static void CommandSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize) => CommandSetRayTracingPipelineStackSizeKHR_0(commandBuffer, pipelineStackSize);
	private delegate void CommandSetRayTracingPipelineStackSizeKHRDelegate_0(VkCommandBuffer commandBuffer, uint pipelineStackSize);
	private static CommandSetRayTracingPipelineStackSizeKHRDelegate_0 CommandSetRayTracingPipelineStackSizeKHR_0;
	[Obsolete("Use CreateSamplerYcbcrConversion")]
	public static void CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_0(device, createInfo, allocator, out ycbcrConversion);
	private delegate void CreateSamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_0 CreateSamplerYcbcrConversionKHR_0;
	[Obsolete("Use CreateSamplerYcbcrConversion")]
	public static void CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_1(device, createInfo, ref allocator, out ycbcrConversion);
	private delegate void CreateSamplerYcbcrConversionKHRDelegate_1(VkDevice device, VkSamplerYcbcrConversionCreateInfoKHR* createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_1 CreateSamplerYcbcrConversionKHR_1;
	[Obsolete("Use CreateSamplerYcbcrConversion")]
	public static void CreateSamplerYcbcrConversionKHR(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_2(device, ref createInfo, allocator, out ycbcrConversion);
	private delegate void CreateSamplerYcbcrConversionKHRDelegate_2(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, VkAllocationCallbacks* allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_2 CreateSamplerYcbcrConversionKHR_2;
	[Obsolete("Use CreateSamplerYcbcrConversion")]
	public static void CreateSamplerYcbcrConversionKHR(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion) => CreateSamplerYcbcrConversionKHR_3(device, ref createInfo, ref allocator, out ycbcrConversion);
	private delegate void CreateSamplerYcbcrConversionKHRDelegate_3(VkDevice device, ref VkSamplerYcbcrConversionCreateInfoKHR createInfo, ref VkAllocationCallbacks allocator, out VkSamplerYcbcrConversionKHR ycbcrConversion);
	private static CreateSamplerYcbcrConversionKHRDelegate_3 CreateSamplerYcbcrConversionKHR_3;
	[Obsolete("Use DestroySamplerYcbcrConversion")]
	public static void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, VkAllocationCallbacks* allocator) => DestroySamplerYcbcrConversionKHR_0(device, ycbcrConversion, allocator);
	private delegate void DestroySamplerYcbcrConversionKHRDelegate_0(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, VkAllocationCallbacks* allocator);
	private static DestroySamplerYcbcrConversionKHRDelegate_0 DestroySamplerYcbcrConversionKHR_0;
	[Obsolete("Use DestroySamplerYcbcrConversion")]
	public static void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, ref VkAllocationCallbacks allocator) => DestroySamplerYcbcrConversionKHR_1(device, ycbcrConversion, ref allocator);
	private delegate void DestroySamplerYcbcrConversionKHRDelegate_1(VkDevice device, VkSamplerYcbcrConversionKHR ycbcrConversion, ref VkAllocationCallbacks allocator);
	private static DestroySamplerYcbcrConversionKHRDelegate_1 DestroySamplerYcbcrConversionKHR_1;
	[Obsolete("Use BindBufferMemory2")]
	public static void BindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfoKHR[] bindInfos) => BindBufferMemory2KHR_0(device, bindInfoCount, bindInfos);
	private delegate void BindBufferMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfoKHR[] bindInfos);
	private static BindBufferMemory2KHRDelegate_0 BindBufferMemory2KHR_0;
	[Obsolete("Use BindImageMemory2")]
	public static void BindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfoKHR[] bindInfos) => BindImageMemory2KHR_0(device, bindInfoCount, bindInfos);
	private delegate void BindImageMemory2KHRDelegate_0(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfoKHR[] bindInfos);
	private static BindImageMemory2KHRDelegate_0 BindImageMemory2KHR_0;
	public static VkResult GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT properties) => GetImageDrmFormatModifierPropertiesEXT_0(device, image, out properties);
	public static bool GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT properties, out VkResult result)
	{
		result = GetImageDrmFormatModifierPropertiesEXT_0(device, image, out properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetImageDrmFormatModifierPropertiesEXTDelegate_0(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT properties);
	private static GetImageDrmFormatModifierPropertiesEXTDelegate_0 GetImageDrmFormatModifierPropertiesEXT_0;
	public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_0(device, createInfo, allocator, out validationCache);
	public static bool CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache, out VkResult result)
	{
		result = CreateValidationCacheEXT_0(device, createInfo, allocator, out validationCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_0 CreateValidationCacheEXT_0;
	public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_1(device, createInfo, ref allocator, out validationCache);
	public static bool CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache, out VkResult result)
	{
		result = CreateValidationCacheEXT_1(device, createInfo, ref allocator, out validationCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateValidationCacheEXTDelegate_1(VkDevice device, VkValidationCacheCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_1 CreateValidationCacheEXT_1;
	public static VkResult CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_2(device, ref createInfo, allocator, out validationCache);
	public static bool CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache, out VkResult result)
	{
		result = CreateValidationCacheEXT_2(device, ref createInfo, allocator, out validationCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateValidationCacheEXTDelegate_2(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_2 CreateValidationCacheEXT_2;
	public static VkResult CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache) => CreateValidationCacheEXT_3(device, ref createInfo, ref allocator, out validationCache);
	public static bool CreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache, out VkResult result)
	{
		result = CreateValidationCacheEXT_3(device, ref createInfo, ref allocator, out validationCache);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateValidationCacheEXTDelegate_3(VkDevice device, ref VkValidationCacheCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkValidationCacheEXT validationCache);
	private static CreateValidationCacheEXTDelegate_3 CreateValidationCacheEXT_3;
	public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* allocator) => DestroyValidationCacheEXT_0(device, validationCache, allocator);
	private delegate void DestroyValidationCacheEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* allocator);
	private static DestroyValidationCacheEXTDelegate_0 DestroyValidationCacheEXT_0;
	public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks allocator) => DestroyValidationCacheEXT_1(device, validationCache, ref allocator);
	private delegate void DestroyValidationCacheEXTDelegate_1(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks allocator);
	private static DestroyValidationCacheEXTDelegate_1 DestroyValidationCacheEXT_1;
	public static VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches) => MergeValidationCachesEXT_0(device, destinationCache, sourceCacheCount, sourceCaches);
	public static bool MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches, out VkResult result)
	{
		result = MergeValidationCachesEXT_0(device, destinationCache, sourceCacheCount, sourceCaches);
		return result == VkResult.Success;
	}
	private delegate VkResult MergeValidationCachesEXTDelegate_0(VkDevice device, VkValidationCacheEXT destinationCache, uint sourceCacheCount, VkValidationCacheEXT[] sourceCaches);
	private static MergeValidationCachesEXTDelegate_0 MergeValidationCachesEXT_0;
	public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data) => GetValidationCacheDataEXT_0(device, validationCache, dataSize, data);
	public static bool GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data, out VkResult result)
	{
		result = GetValidationCacheDataEXT_0(device, validationCache, dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetValidationCacheDataEXTDelegate_0(VkDevice device, VkValidationCacheEXT validationCache, nuint* dataSize, void* data);
	private static GetValidationCacheDataEXTDelegate_0 GetValidationCacheDataEXT_0;
	public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data) => GetValidationCacheDataEXT_1(device, validationCache, ref dataSize, data);
	public static bool GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data, out VkResult result)
	{
		result = GetValidationCacheDataEXT_1(device, validationCache, ref dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetValidationCacheDataEXTDelegate_1(VkDevice device, VkValidationCacheEXT validationCache, ref nuint dataSize, void* data);
	private static GetValidationCacheDataEXTDelegate_1 GetValidationCacheDataEXT_1;
	public static void CommandBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => CommandBindShadingRateImageNV_0(commandBuffer, imageView, imageLayout);
	private delegate void CommandBindShadingRateImageNVDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
	private static CommandBindShadingRateImageNVDelegate_0 CommandBindShadingRateImageNV_0;
	public static void CommandSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* shadingRatePalettes) => CommandSetViewportShadingRatePaletteNV_0(commandBuffer, firstViewport, viewportCount, shadingRatePalettes);
	private delegate void CommandSetViewportShadingRatePaletteNVDelegate_0(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* shadingRatePalettes);
	private static CommandSetViewportShadingRatePaletteNVDelegate_0 CommandSetViewportShadingRatePaletteNV_0;
	public static void CommandSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkShadingRatePaletteNV shadingRatePalettes) => CommandSetViewportShadingRatePaletteNV_1(commandBuffer, firstViewport, viewportCount, ref shadingRatePalettes);
	private delegate void CommandSetViewportShadingRatePaletteNVDelegate_1(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkShadingRatePaletteNV shadingRatePalettes);
	private static CommandSetViewportShadingRatePaletteNVDelegate_1 CommandSetViewportShadingRatePaletteNV_1;
	public static void CommandSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV[] customSampleOrders) => CommandSetCoarseSampleOrderNV_0(commandBuffer, sampleOrderType, customSampleOrderCount, customSampleOrders);
	private delegate void CommandSetCoarseSampleOrderNVDelegate_0(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV[] customSampleOrders);
	private static CommandSetCoarseSampleOrderNVDelegate_0 CommandSetCoarseSampleOrderNV_0;
	public static VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_0(device, createInfo, allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureNV_0(device, createInfo, allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure);
	private static CreateAccelerationStructureNVDelegate_0 CreateAccelerationStructureNV_0;
	public static VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_1(device, createInfo, ref allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureNV_1(device, createInfo, ref allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureNVDelegate_1(VkDevice device, VkAccelerationStructureCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure);
	private static CreateAccelerationStructureNVDelegate_1 CreateAccelerationStructureNV_1;
	public static VkResult CreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_2(device, ref createInfo, allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureNV_2(device, ref createInfo, allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureNVDelegate_2(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkAccelerationStructureNV accelerationStructure);
	private static CreateAccelerationStructureNVDelegate_2 CreateAccelerationStructureNV_2;
	public static VkResult CreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure) => CreateAccelerationStructureNV_3(device, ref createInfo, ref allocator, out accelerationStructure);
	public static bool CreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure, out VkResult result)
	{
		result = CreateAccelerationStructureNV_3(device, ref createInfo, ref allocator, out accelerationStructure);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateAccelerationStructureNVDelegate_3(VkDevice device, ref VkAccelerationStructureCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkAccelerationStructureNV accelerationStructure);
	private static CreateAccelerationStructureNVDelegate_3 CreateAccelerationStructureNV_3;
	public static void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* allocator) => DestroyAccelerationStructureNV_0(device, accelerationStructure, allocator);
	private delegate void DestroyAccelerationStructureNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* allocator);
	private static DestroyAccelerationStructureNVDelegate_0 DestroyAccelerationStructureNV_0;
	public static void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, ref VkAllocationCallbacks allocator) => DestroyAccelerationStructureNV_1(device, accelerationStructure, ref allocator);
	private delegate void DestroyAccelerationStructureNVDelegate_1(VkDevice device, VkAccelerationStructureNV accelerationStructure, ref VkAllocationCallbacks allocator);
	private static DestroyAccelerationStructureNVDelegate_1 DestroyAccelerationStructureNV_1;
	public static void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* info, out VkMemoryRequirements2KHR memoryRequirements) => GetAccelerationStructureMemoryRequirementsNV_0(device, info, out memoryRequirements);
	private delegate void GetAccelerationStructureMemoryRequirementsNVDelegate_0(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetAccelerationStructureMemoryRequirementsNVDelegate_0 GetAccelerationStructureMemoryRequirementsNV_0;
	public static void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV info, out VkMemoryRequirements2KHR memoryRequirements) => GetAccelerationStructureMemoryRequirementsNV_1(device, ref info, out memoryRequirements);
	private delegate void GetAccelerationStructureMemoryRequirementsNVDelegate_1(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV info, out VkMemoryRequirements2KHR memoryRequirements);
	private static GetAccelerationStructureMemoryRequirementsNVDelegate_1 GetAccelerationStructureMemoryRequirementsNV_1;
	public static VkResult BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] bindInfos) => BindAccelerationStructureMemoryNV_0(device, bindInfoCount, bindInfos);
	public static bool BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] bindInfos, out VkResult result)
	{
		result = BindAccelerationStructureMemoryNV_0(device, bindInfoCount, bindInfos);
		return result == VkResult.Success;
	}
	private delegate VkResult BindAccelerationStructureMemoryNVDelegate_0(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] bindInfos);
	private static BindAccelerationStructureMemoryNVDelegate_0 BindAccelerationStructureMemoryNV_0;
	public static void CommandBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset) => CommandBuildAccelerationStructureNV_0(commandBuffer, info, instanceData, instanceOffset, update, destination, source, scratch, scratchOffset);
	private delegate void CommandBuildAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset);
	private static CommandBuildAccelerationStructureNVDelegate_0 CommandBuildAccelerationStructureNV_0;
	public static void CommandBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, ref VkAccelerationStructureInfoNV info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset) => CommandBuildAccelerationStructureNV_1(commandBuffer, ref info, instanceData, instanceOffset, update, destination, source, scratch, scratchOffset);
	private delegate void CommandBuildAccelerationStructureNVDelegate_1(VkCommandBuffer commandBuffer, ref VkAccelerationStructureInfoNV info, VkBuffer instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkBuffer scratch, VkDeviceSize scratchOffset);
	private static CommandBuildAccelerationStructureNVDelegate_1 CommandBuildAccelerationStructureNV_1;
	public static void CommandCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkCopyAccelerationStructureModeKHR mode) => CommandCopyAccelerationStructureNV_0(commandBuffer, destination, source, mode);
	private delegate void CommandCopyAccelerationStructureNVDelegate_0(VkCommandBuffer commandBuffer, VkAccelerationStructureNV destination, VkAccelerationStructureNV source, VkCopyAccelerationStructureModeKHR mode);
	private static CommandCopyAccelerationStructureNVDelegate_0 CommandCopyAccelerationStructureNV_0;
	public static void CommandTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth) => CommandTraceRaysNV_0(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
	private delegate void CommandTraceRaysNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth);
	private static CommandTraceRaysNVDelegate_0 CommandTraceRaysNV_0;
	public static VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesNV_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
	public static bool CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateRayTracingPipelinesNV_0(device, pipelineCache, createInfoCount, createInfos, allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRayTracingPipelinesNVDelegate_0(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, VkAllocationCallbacks* allocator, out VkPipeline pipelines);
	private static CreateRayTracingPipelinesNVDelegate_0 CreateRayTracingPipelinesNV_0;
	public static VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines) => CreateRayTracingPipelinesNV_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
	public static bool CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines, out VkResult result)
	{
		result = CreateRayTracingPipelinesNV_1(device, pipelineCache, createInfoCount, createInfos, ref allocator, out pipelines);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateRayTracingPipelinesNVDelegate_1(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] createInfos, ref VkAllocationCallbacks allocator, out VkPipeline pipelines);
	private static CreateRayTracingPipelinesNVDelegate_1 CreateRayTracingPipelinesNV_1;
	[Obsolete("Use GetRayTracingShaderGroupHandlesKHR")]
	public static void GetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data) => GetRayTracingShaderGroupHandlesNV_0(device, pipeline, firstGroup, groupCount, dataSize, data);
	private delegate void GetRayTracingShaderGroupHandlesNVDelegate_0(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* data);
	private static GetRayTracingShaderGroupHandlesNVDelegate_0 GetRayTracingShaderGroupHandlesNV_0;
	public static VkResult GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* data) => GetAccelerationStructureHandleNV_0(device, accelerationStructure, dataSize, data);
	public static bool GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* data, out VkResult result)
	{
		result = GetAccelerationStructureHandleNV_0(device, accelerationStructure, dataSize, data);
		return result == VkResult.Success;
	}
	private delegate VkResult GetAccelerationStructureHandleNVDelegate_0(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* data);
	private static GetAccelerationStructureHandleNVDelegate_0 GetAccelerationStructureHandleNV_0;
	public static void CommandWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery) => CommandWriteAccelerationStructuresPropertiesNV_0(commandBuffer, accelerationStructureCount, accelerationStructures, queryType, queryPool, firstQuery);
	private delegate void CommandWriteAccelerationStructuresPropertiesNVDelegate_0(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV[] accelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
	private static CommandWriteAccelerationStructuresPropertiesNVDelegate_0 CommandWriteAccelerationStructuresPropertiesNV_0;
	public static VkResult CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader) => CompileDeferredNV_0(device, pipeline, shader);
	public static bool CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader, out VkResult result)
	{
		result = CompileDeferredNV_0(device, pipeline, shader);
		return result == VkResult.Success;
	}
	private delegate VkResult CompileDeferredNVDelegate_0(VkDevice device, VkPipeline pipeline, uint shader);
	private static CompileDeferredNVDelegate_0 CompileDeferredNV_0;
	[Obsolete("Use GetDescriptorSetLayoutSupport")]
	public static void GetDescriptorSetLayoutSupportKHR(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupportKHR support) => GetDescriptorSetLayoutSupportKHR_0(device, createInfo, out support);
	private delegate void GetDescriptorSetLayoutSupportKHRDelegate_0(VkDevice device, VkDescriptorSetLayoutCreateInfo* createInfo, out VkDescriptorSetLayoutSupportKHR support);
	private static GetDescriptorSetLayoutSupportKHRDelegate_0 GetDescriptorSetLayoutSupportKHR_0;
	[Obsolete("Use GetDescriptorSetLayoutSupport")]
	public static void GetDescriptorSetLayoutSupportKHR(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupportKHR support) => GetDescriptorSetLayoutSupportKHR_1(device, ref createInfo, out support);
	private delegate void GetDescriptorSetLayoutSupportKHRDelegate_1(VkDevice device, ref VkDescriptorSetLayoutCreateInfo createInfo, out VkDescriptorSetLayoutSupportKHR support);
	private static GetDescriptorSetLayoutSupportKHRDelegate_1 GetDescriptorSetLayoutSupportKHR_1;
	[Obsolete("Use CommandDrawIndirectCount")]
	public static void CommandDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndirectCountKHRDelegate_0 CommandDrawIndirectCountKHR_0;
	[Obsolete("Use CommandDrawIndexedIndirectCount")]
	public static void CommandDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawIndexedIndirectCountKHR_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawIndexedIndirectCountKHRDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawIndexedIndirectCountKHRDelegate_0 CommandDrawIndexedIndirectCountKHR_0;
	public static VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties) => GetMemoryHostPointerPropertiesEXT_0(device, handleType, hostPointer, out memoryHostPointerProperties);
	public static bool GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties, out VkResult result)
	{
		result = GetMemoryHostPointerPropertiesEXT_0(device, handleType, hostPointer, out memoryHostPointerProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryHostPointerPropertiesEXTDelegate_0(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, out VkMemoryHostPointerPropertiesEXT memoryHostPointerProperties);
	private static GetMemoryHostPointerPropertiesEXTDelegate_0 GetMemoryHostPointerPropertiesEXT_0;
	public static void CommandWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker) => CommandWriteBufferMarkerAMD_0(commandBuffer, pipelineStage, destinationBuffer, destinationOffset, marker);
	private delegate void CommandWriteBufferMarkerAMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker);
	private static CommandWriteBufferMarkerAMDDelegate_0 CommandWriteBufferMarkerAMD_0;
	public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains) => GetPhysicalDeviceCalibrateableTimeDomainsEXT_0(physicalDevice, timeDomainCount, timeDomains);
	public static bool GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains, out VkResult result)
	{
		result = GetPhysicalDeviceCalibrateableTimeDomainsEXT_0(physicalDevice, timeDomainCount, timeDomains);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0(VkPhysicalDevice physicalDevice, uint* timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains);
	private static GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0 GetPhysicalDeviceCalibrateableTimeDomainsEXT_0;
	public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains) => GetPhysicalDeviceCalibrateableTimeDomainsEXT_1(physicalDevice, ref timeDomainCount, timeDomains);
	public static bool GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains, out VkResult result)
	{
		result = GetPhysicalDeviceCalibrateableTimeDomainsEXT_1(physicalDevice, ref timeDomainCount, timeDomains);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_1(VkPhysicalDevice physicalDevice, ref uint timeDomainCount, [In, Out] VkTimeDomainEXT[] timeDomains);
	private static GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_1 GetPhysicalDeviceCalibrateableTimeDomainsEXT_1;
	public static VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ulong* timestamps, out ulong maxDeviation) => GetCalibratedTimestampsEXT_0(device, timestampCount, timestampInfos, timestamps, out maxDeviation);
	public static bool GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ulong* timestamps, out ulong maxDeviation, out VkResult result)
	{
		result = GetCalibratedTimestampsEXT_0(device, timestampCount, timestampInfos, timestamps, out maxDeviation);
		return result == VkResult.Success;
	}
	private delegate VkResult GetCalibratedTimestampsEXTDelegate_0(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ulong* timestamps, out ulong maxDeviation);
	private static GetCalibratedTimestampsEXTDelegate_0 GetCalibratedTimestampsEXT_0;
	public static VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ref ulong timestamps, out ulong maxDeviation) => GetCalibratedTimestampsEXT_1(device, timestampCount, timestampInfos, ref timestamps, out maxDeviation);
	public static bool GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ref ulong timestamps, out ulong maxDeviation, out VkResult result)
	{
		result = GetCalibratedTimestampsEXT_1(device, timestampCount, timestampInfos, ref timestamps, out maxDeviation);
		return result == VkResult.Success;
	}
	private delegate VkResult GetCalibratedTimestampsEXTDelegate_1(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] timestampInfos, ref ulong timestamps, out ulong maxDeviation);
	private static GetCalibratedTimestampsEXTDelegate_1 GetCalibratedTimestampsEXT_1;
	public static void CommandDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask) => CommandDrawMeshTasksNV_0(commandBuffer, taskCount, firstTask);
	private delegate void CommandDrawMeshTasksNVDelegate_0(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
	private static CommandDrawMeshTasksNVDelegate_0 CommandDrawMeshTasksNV_0;
	public static void CommandDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride) => CommandDrawMeshTasksIndirectNV_0(commandBuffer, buffer, offset, drawCount, stride);
	private delegate void CommandDrawMeshTasksIndirectNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride);
	private static CommandDrawMeshTasksIndirectNVDelegate_0 CommandDrawMeshTasksIndirectNV_0;
	public static void CommandDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride) => CommandDrawMeshTasksIndirectCountNV_0(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
	private delegate void CommandDrawMeshTasksIndirectCountNVDelegate_0(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride);
	private static CommandDrawMeshTasksIndirectCountNVDelegate_0 CommandDrawMeshTasksIndirectCountNV_0;
	public static void CommandSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D[] exclusiveScissors) => CommandSetExclusiveScissorNV_0(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, exclusiveScissors);
	private delegate void CommandSetExclusiveScissorNVDelegate_0(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D[] exclusiveScissors);
	private static CommandSetExclusiveScissorNVDelegate_0 CommandSetExclusiveScissorNV_0;
	public static void CommandSetCheckpointNV(VkCommandBuffer commandBuffer, void* checkpointMarker) => CommandSetCheckpointNV_0(commandBuffer, checkpointMarker);
	private delegate void CommandSetCheckpointNVDelegate_0(VkCommandBuffer commandBuffer, void* checkpointMarker);
	private static CommandSetCheckpointNVDelegate_0 CommandSetCheckpointNV_0;
	public static void GetQueueCheckpointDataNV(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData) => GetQueueCheckpointDataNV_0(queue, checkpointDataCount, checkpointData);
	private delegate void GetQueueCheckpointDataNVDelegate_0(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData);
	private static GetQueueCheckpointDataNVDelegate_0 GetQueueCheckpointDataNV_0;
	public static void GetQueueCheckpointDataNV(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData) => GetQueueCheckpointDataNV_1(queue, ref checkpointDataCount, checkpointData);
	private delegate void GetQueueCheckpointDataNVDelegate_1(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointDataNV[] checkpointData);
	private static GetQueueCheckpointDataNVDelegate_1 GetQueueCheckpointDataNV_1;
	[Obsolete("Use GetSemaphoreCounterValue")]
	public static void GetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, out ulong value) => GetSemaphoreCounterValueKHR_0(device, semaphore, out value);
	private delegate void GetSemaphoreCounterValueKHRDelegate_0(VkDevice device, VkSemaphore semaphore, out ulong value);
	private static GetSemaphoreCounterValueKHRDelegate_0 GetSemaphoreCounterValueKHR_0;
	[Obsolete("Use WaitSemaphores")]
	public static void WaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfoKHR* waitInfo, ulong timeout) => WaitSemaphoresKHR_0(device, waitInfo, timeout);
	private delegate void WaitSemaphoresKHRDelegate_0(VkDevice device, VkSemaphoreWaitInfoKHR* waitInfo, ulong timeout);
	private static WaitSemaphoresKHRDelegate_0 WaitSemaphoresKHR_0;
	[Obsolete("Use WaitSemaphores")]
	public static void WaitSemaphoresKHR(VkDevice device, ref VkSemaphoreWaitInfoKHR waitInfo, ulong timeout) => WaitSemaphoresKHR_1(device, ref waitInfo, timeout);
	private delegate void WaitSemaphoresKHRDelegate_1(VkDevice device, ref VkSemaphoreWaitInfoKHR waitInfo, ulong timeout);
	private static WaitSemaphoresKHRDelegate_1 WaitSemaphoresKHR_1;
	[Obsolete("Use SignalSemaphore")]
	public static void SignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfoKHR* signalInfo) => SignalSemaphoreKHR_0(device, signalInfo);
	private delegate void SignalSemaphoreKHRDelegate_0(VkDevice device, VkSemaphoreSignalInfoKHR* signalInfo);
	private static SignalSemaphoreKHRDelegate_0 SignalSemaphoreKHR_0;
	[Obsolete("Use SignalSemaphore")]
	public static void SignalSemaphoreKHR(VkDevice device, ref VkSemaphoreSignalInfoKHR signalInfo) => SignalSemaphoreKHR_1(device, ref signalInfo);
	private delegate void SignalSemaphoreKHRDelegate_1(VkDevice device, ref VkSemaphoreSignalInfoKHR signalInfo);
	private static SignalSemaphoreKHRDelegate_1 SignalSemaphoreKHR_1;
	public static VkResult InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* initializeInfo) => InitializePerformanceApiINTEL_0(device, initializeInfo);
	public static bool InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* initializeInfo, out VkResult result)
	{
		result = InitializePerformanceApiINTEL_0(device, initializeInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult InitializePerformanceApiINTELDelegate_0(VkDevice device, VkInitializePerformanceApiInfoINTEL* initializeInfo);
	private static InitializePerformanceApiINTELDelegate_0 InitializePerformanceApiINTEL_0;
	public static VkResult InitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfoINTEL initializeInfo) => InitializePerformanceApiINTEL_1(device, ref initializeInfo);
	public static bool InitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfoINTEL initializeInfo, out VkResult result)
	{
		result = InitializePerformanceApiINTEL_1(device, ref initializeInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult InitializePerformanceApiINTELDelegate_1(VkDevice device, ref VkInitializePerformanceApiInfoINTEL initializeInfo);
	private static InitializePerformanceApiINTELDelegate_1 InitializePerformanceApiINTEL_1;
	public static void UninitializePerformanceApiINTEL(VkDevice device) => UninitializePerformanceApiINTEL_0(device);
	private delegate void UninitializePerformanceApiINTELDelegate_0(VkDevice device);
	private static UninitializePerformanceApiINTELDelegate_0 UninitializePerformanceApiINTEL_0;
	public static VkResult CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* markerInfo) => CommandSetPerformanceMarkerINTEL_0(commandBuffer, markerInfo);
	public static bool CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* markerInfo, out VkResult result)
	{
		result = CommandSetPerformanceMarkerINTEL_0(commandBuffer, markerInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult CommandSetPerformanceMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* markerInfo);
	private static CommandSetPerformanceMarkerINTELDelegate_0 CommandSetPerformanceMarkerINTEL_0;
	public static VkResult CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL markerInfo) => CommandSetPerformanceMarkerINTEL_1(commandBuffer, ref markerInfo);
	public static bool CommandSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL markerInfo, out VkResult result)
	{
		result = CommandSetPerformanceMarkerINTEL_1(commandBuffer, ref markerInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult CommandSetPerformanceMarkerINTELDelegate_1(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL markerInfo);
	private static CommandSetPerformanceMarkerINTELDelegate_1 CommandSetPerformanceMarkerINTEL_1;
	public static VkResult CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* markerInfo) => CommandSetPerformanceStreamMarkerINTEL_0(commandBuffer, markerInfo);
	public static bool CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* markerInfo, out VkResult result)
	{
		result = CommandSetPerformanceStreamMarkerINTEL_0(commandBuffer, markerInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult CommandSetPerformanceStreamMarkerINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* markerInfo);
	private static CommandSetPerformanceStreamMarkerINTELDelegate_0 CommandSetPerformanceStreamMarkerINTEL_0;
	public static VkResult CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL markerInfo) => CommandSetPerformanceStreamMarkerINTEL_1(commandBuffer, ref markerInfo);
	public static bool CommandSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL markerInfo, out VkResult result)
	{
		result = CommandSetPerformanceStreamMarkerINTEL_1(commandBuffer, ref markerInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult CommandSetPerformanceStreamMarkerINTELDelegate_1(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL markerInfo);
	private static CommandSetPerformanceStreamMarkerINTELDelegate_1 CommandSetPerformanceStreamMarkerINTEL_1;
	public static VkResult CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* overrideInfo) => CommandSetPerformanceOverrideINTEL_0(commandBuffer, overrideInfo);
	public static bool CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* overrideInfo, out VkResult result)
	{
		result = CommandSetPerformanceOverrideINTEL_0(commandBuffer, overrideInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult CommandSetPerformanceOverrideINTELDelegate_0(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* overrideInfo);
	private static CommandSetPerformanceOverrideINTELDelegate_0 CommandSetPerformanceOverrideINTEL_0;
	public static VkResult CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL overrideInfo) => CommandSetPerformanceOverrideINTEL_1(commandBuffer, ref overrideInfo);
	public static bool CommandSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL overrideInfo, out VkResult result)
	{
		result = CommandSetPerformanceOverrideINTEL_1(commandBuffer, ref overrideInfo);
		return result == VkResult.Success;
	}
	private delegate VkResult CommandSetPerformanceOverrideINTELDelegate_1(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL overrideInfo);
	private static CommandSetPerformanceOverrideINTELDelegate_1 CommandSetPerformanceOverrideINTEL_1;
	public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, VkPerformanceConfigurationINTEL* configuration) => AcquirePerformanceConfigurationINTEL_0(device, acquireInfo, configuration);
	public static bool AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, VkPerformanceConfigurationINTEL* configuration, out VkResult result)
	{
		result = AcquirePerformanceConfigurationINTEL_0(device, acquireInfo, configuration);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquirePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, VkPerformanceConfigurationINTEL* configuration);
	private static AcquirePerformanceConfigurationINTELDelegate_0 AcquirePerformanceConfigurationINTEL_0;
	public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, ref VkPerformanceConfigurationINTEL configuration) => AcquirePerformanceConfigurationINTEL_1(device, acquireInfo, ref configuration);
	public static bool AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, ref VkPerformanceConfigurationINTEL configuration, out VkResult result)
	{
		result = AcquirePerformanceConfigurationINTEL_1(device, acquireInfo, ref configuration);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquirePerformanceConfigurationINTELDelegate_1(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* acquireInfo, ref VkPerformanceConfigurationINTEL configuration);
	private static AcquirePerformanceConfigurationINTELDelegate_1 AcquirePerformanceConfigurationINTEL_1;
	public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, VkPerformanceConfigurationINTEL* configuration) => AcquirePerformanceConfigurationINTEL_2(device, ref acquireInfo, configuration);
	public static bool AcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, VkPerformanceConfigurationINTEL* configuration, out VkResult result)
	{
		result = AcquirePerformanceConfigurationINTEL_2(device, ref acquireInfo, configuration);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquirePerformanceConfigurationINTELDelegate_2(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, VkPerformanceConfigurationINTEL* configuration);
	private static AcquirePerformanceConfigurationINTELDelegate_2 AcquirePerformanceConfigurationINTEL_2;
	public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, ref VkPerformanceConfigurationINTEL configuration) => AcquirePerformanceConfigurationINTEL_3(device, ref acquireInfo, ref configuration);
	public static bool AcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, ref VkPerformanceConfigurationINTEL configuration, out VkResult result)
	{
		result = AcquirePerformanceConfigurationINTEL_3(device, ref acquireInfo, ref configuration);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquirePerformanceConfigurationINTELDelegate_3(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL acquireInfo, ref VkPerformanceConfigurationINTEL configuration);
	private static AcquirePerformanceConfigurationINTELDelegate_3 AcquirePerformanceConfigurationINTEL_3;
	public static VkResult ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration) => ReleasePerformanceConfigurationINTEL_0(device, configuration);
	public static bool ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration, out VkResult result)
	{
		result = ReleasePerformanceConfigurationINTEL_0(device, configuration);
		return result == VkResult.Success;
	}
	private delegate VkResult ReleasePerformanceConfigurationINTELDelegate_0(VkDevice device, VkPerformanceConfigurationINTEL configuration);
	private static ReleasePerformanceConfigurationINTELDelegate_0 ReleasePerformanceConfigurationINTEL_0;
	public static VkResult QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration) => QueueSetPerformanceConfigurationINTEL_0(queue, configuration);
	public static bool QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration, out VkResult result)
	{
		result = QueueSetPerformanceConfigurationINTEL_0(queue, configuration);
		return result == VkResult.Success;
	}
	private delegate VkResult QueueSetPerformanceConfigurationINTELDelegate_0(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
	private static QueueSetPerformanceConfigurationINTELDelegate_0 QueueSetPerformanceConfigurationINTEL_0;
	public static VkResult GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL value) => GetPerformanceParameterINTEL_0(device, parameter, out value);
	public static bool GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL value, out VkResult result)
	{
		result = GetPerformanceParameterINTEL_0(device, parameter, out value);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPerformanceParameterINTELDelegate_0(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL value);
	private static GetPerformanceParameterINTELDelegate_0 GetPerformanceParameterINTEL_0;
	public static void SetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable) => SetLocalDimmingAMD_0(device, swapChain, localDimmingEnable);
	private delegate void SetLocalDimmingAMDDelegate_0(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
	private static SetLocalDimmingAMDDelegate_0 SetLocalDimmingAMD_0;
	public static VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates) => GetPhysicalDeviceFragmentShadingRatesKHR_0(physicalDevice, fragmentShadingRateCount, fragmentShadingRates);
	public static bool GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates, out VkResult result)
	{
		result = GetPhysicalDeviceFragmentShadingRatesKHR_0(physicalDevice, fragmentShadingRateCount, fragmentShadingRates);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceFragmentShadingRatesKHRDelegate_0(VkPhysicalDevice physicalDevice, uint* fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates);
	private static GetPhysicalDeviceFragmentShadingRatesKHRDelegate_0 GetPhysicalDeviceFragmentShadingRatesKHR_0;
	public static VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates) => GetPhysicalDeviceFragmentShadingRatesKHR_1(physicalDevice, ref fragmentShadingRateCount, fragmentShadingRates);
	public static bool GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates, out VkResult result)
	{
		result = GetPhysicalDeviceFragmentShadingRatesKHR_1(physicalDevice, ref fragmentShadingRateCount, fragmentShadingRates);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceFragmentShadingRatesKHRDelegate_1(VkPhysicalDevice physicalDevice, ref uint fragmentShadingRateCount, [In, Out] VkPhysicalDeviceFragmentShadingRateKHR[] fragmentShadingRates);
	private static GetPhysicalDeviceFragmentShadingRatesKHRDelegate_1 GetPhysicalDeviceFragmentShadingRatesKHR_1;
	public static void CommandSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps) => CommandSetFragmentShadingRateKHR_0(commandBuffer, fragmentSize, combinerOps);
	private delegate void CommandSetFragmentShadingRateKHRDelegate_0(VkCommandBuffer commandBuffer, VkExtent2D* fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
	private static CommandSetFragmentShadingRateKHRDelegate_0 CommandSetFragmentShadingRateKHR_0;
	public static void CommandSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, ref VkExtent2D fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps) => CommandSetFragmentShadingRateKHR_1(commandBuffer, ref fragmentSize, combinerOps);
	private delegate void CommandSetFragmentShadingRateKHRDelegate_1(VkCommandBuffer commandBuffer, ref VkExtent2D fragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
	private static CommandSetFragmentShadingRateKHRDelegate_1 CommandSetFragmentShadingRateKHR_1;
	[Obsolete("Use GetBufferDeviceAddress")]
	public static void GetBufferDeviceAddressEXT(VkDevice device, out VkBufferDeviceAddressInfoKHR info) => GetBufferDeviceAddressEXT_0(device, out info);
	private delegate void GetBufferDeviceAddressEXTDelegate_0(VkDevice device, out VkBufferDeviceAddressInfoKHR info);
	private static GetBufferDeviceAddressEXTDelegate_0 GetBufferDeviceAddressEXT_0;
	public static VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* toolCount, [In, Out] VkPhysicalDeviceToolPropertiesEXT[] toolProperties) => GetPhysicalDeviceToolPropertiesEXT_0(physicalDevice, toolCount, toolProperties);
	public static bool GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* toolCount, [In, Out] VkPhysicalDeviceToolPropertiesEXT[] toolProperties, out VkResult result)
	{
		result = GetPhysicalDeviceToolPropertiesEXT_0(physicalDevice, toolCount, toolProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceToolPropertiesEXTDelegate_0(VkPhysicalDevice physicalDevice, uint* toolCount, [In, Out] VkPhysicalDeviceToolPropertiesEXT[] toolProperties);
	private static GetPhysicalDeviceToolPropertiesEXTDelegate_0 GetPhysicalDeviceToolPropertiesEXT_0;
	public static VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, ref uint toolCount, [In, Out] VkPhysicalDeviceToolPropertiesEXT[] toolProperties) => GetPhysicalDeviceToolPropertiesEXT_1(physicalDevice, ref toolCount, toolProperties);
	public static bool GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, ref uint toolCount, [In, Out] VkPhysicalDeviceToolPropertiesEXT[] toolProperties, out VkResult result)
	{
		result = GetPhysicalDeviceToolPropertiesEXT_1(physicalDevice, ref toolCount, toolProperties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceToolPropertiesEXTDelegate_1(VkPhysicalDevice physicalDevice, ref uint toolCount, [In, Out] VkPhysicalDeviceToolPropertiesEXT[] toolProperties);
	private static GetPhysicalDeviceToolPropertiesEXTDelegate_1 GetPhysicalDeviceToolPropertiesEXT_1;
	public static VkResult WaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout) => WaitForPresentKHR_0(device, swapchain, presentId, timeout);
	public static bool WaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout, out VkResult result)
	{
		result = WaitForPresentKHR_0(device, swapchain, presentId, timeout);
		return result == VkResult.Success;
	}
	private delegate VkResult WaitForPresentKHRDelegate_0(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout);
	private static WaitForPresentKHRDelegate_0 WaitForPresentKHR_0;
	public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties) => GetPhysicalDeviceCooperativeMatrixPropertiesNV_0(physicalDevice, propertyCount, properties);
	public static bool GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceCooperativeMatrixPropertiesNV_0(physicalDevice, propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0(VkPhysicalDevice physicalDevice, uint* propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties);
	private static GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0 GetPhysicalDeviceCooperativeMatrixPropertiesNV_0;
	public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties) => GetPhysicalDeviceCooperativeMatrixPropertiesNV_1(physicalDevice, ref propertyCount, properties);
	public static bool GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties, out VkResult result)
	{
		result = GetPhysicalDeviceCooperativeMatrixPropertiesNV_1(physicalDevice, ref propertyCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_1(VkPhysicalDevice physicalDevice, ref uint propertyCount, [In, Out] VkCooperativeMatrixPropertiesNV[] properties);
	private static GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_1 GetPhysicalDeviceCooperativeMatrixPropertiesNV_1;
	public static VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations) => GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0(physicalDevice, combinationCount, combinations);
	public static bool GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations, out VkResult result)
	{
		result = GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0(physicalDevice, combinationCount, combinations);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0(VkPhysicalDevice physicalDevice, uint* combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations);
	private static GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0 GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0;
	public static VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations) => GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1(physicalDevice, ref combinationCount, combinations);
	public static bool GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations, out VkResult result)
	{
		result = GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1(physicalDevice, ref combinationCount, combinations);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_1(VkPhysicalDevice physicalDevice, ref uint combinationCount, [In, Out] VkFramebufferMixedSamplesCombinationNV[] combinations);
	private static GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_1 GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1;
	public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_0(physicalDevice, surfaceInfo, presentModeCount, presentModes);
	public static bool GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes, out VkResult result)
	{
		result = GetPhysicalDeviceSurfacePresentModes2EXT_0(physicalDevice, surfaceInfo, presentModeCount, presentModes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0 GetPhysicalDeviceSurfacePresentModes2EXT_0;
	public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_1(physicalDevice, surfaceInfo, ref presentModeCount, presentModes);
	public static bool GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes, out VkResult result)
	{
		result = GetPhysicalDeviceSurfacePresentModes2EXT_1(physicalDevice, surfaceInfo, ref presentModeCount, presentModes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_1(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_1 GetPhysicalDeviceSurfacePresentModes2EXT_1;
	public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_2(physicalDevice, ref surfaceInfo, presentModeCount, presentModes);
	public static bool GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes, out VkResult result)
	{
		result = GetPhysicalDeviceSurfacePresentModes2EXT_2(physicalDevice, ref surfaceInfo, presentModeCount, presentModes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_2(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, uint* presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_2 GetPhysicalDeviceSurfacePresentModes2EXT_2;
	public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes) => GetPhysicalDeviceSurfacePresentModes2EXT_3(physicalDevice, ref surfaceInfo, ref presentModeCount, presentModes);
	public static bool GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes, out VkResult result)
	{
		result = GetPhysicalDeviceSurfacePresentModes2EXT_3(physicalDevice, ref surfaceInfo, ref presentModeCount, presentModes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXTDelegate_3(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, ref uint presentModeCount, [In, Out] VkPresentModeKHR[] presentModes);
	private static GetPhysicalDeviceSurfacePresentModes2EXTDelegate_3 GetPhysicalDeviceSurfacePresentModes2EXT_3;
	public static VkResult AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => AcquireFullScreenExclusiveModeEXT_0(device, swapchain);
	public static bool AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain, out VkResult result)
	{
		result = AcquireFullScreenExclusiveModeEXT_0(device, swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static AcquireFullScreenExclusiveModeEXTDelegate_0 AcquireFullScreenExclusiveModeEXT_0;
	public static VkResult ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain) => ReleaseFullScreenExclusiveModeEXT_0(device, swapchain);
	public static bool ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain, out VkResult result)
	{
		result = ReleaseFullScreenExclusiveModeEXT_0(device, swapchain);
		return result == VkResult.Success;
	}
	private delegate VkResult ReleaseFullScreenExclusiveModeEXTDelegate_0(VkDevice device, VkSwapchainKHR swapchain);
	private static ReleaseFullScreenExclusiveModeEXTDelegate_0 ReleaseFullScreenExclusiveModeEXT_0;
	public static VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes) => GetDeviceGroupSurfacePresentModes2EXT_0(device, surfaceInfo, out modes);
	public static bool GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes, out VkResult result)
	{
		result = GetDeviceGroupSurfacePresentModes2EXT_0(device, surfaceInfo, out modes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDeviceGroupSurfacePresentModes2EXTDelegate_0(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes);
	private static GetDeviceGroupSurfacePresentModes2EXTDelegate_0 GetDeviceGroupSurfacePresentModes2EXT_0;
	public static VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes) => GetDeviceGroupSurfacePresentModes2EXT_1(device, ref surfaceInfo, out modes);
	public static bool GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes, out VkResult result)
	{
		result = GetDeviceGroupSurfacePresentModes2EXT_1(device, ref surfaceInfo, out modes);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDeviceGroupSurfacePresentModes2EXTDelegate_1(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR surfaceInfo, out VkDeviceGroupPresentModeFlagsKHR modes);
	private static GetDeviceGroupSurfacePresentModes2EXTDelegate_1 GetDeviceGroupSurfacePresentModes2EXT_1;
	public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_0(instance, createInfo, allocator, out surface);
	public static bool CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateHeadlessSurfaceEXT_0(instance, createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateHeadlessSurfaceEXTDelegate_0(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateHeadlessSurfaceEXTDelegate_0 CreateHeadlessSurfaceEXT_0;
	public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_1(instance, createInfo, ref allocator, out surface);
	public static bool CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateHeadlessSurfaceEXT_1(instance, createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateHeadlessSurfaceEXTDelegate_1(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateHeadlessSurfaceEXTDelegate_1 CreateHeadlessSurfaceEXT_1;
	public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_2(instance, ref createInfo, allocator, out surface);
	public static bool CreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateHeadlessSurfaceEXT_2(instance, ref createInfo, allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateHeadlessSurfaceEXTDelegate_2(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
	private static CreateHeadlessSurfaceEXTDelegate_2 CreateHeadlessSurfaceEXT_2;
	public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface) => CreateHeadlessSurfaceEXT_3(instance, ref createInfo, ref allocator, out surface);
	public static bool CreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface, out VkResult result)
	{
		result = CreateHeadlessSurfaceEXT_3(instance, ref createInfo, ref allocator, out surface);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateHeadlessSurfaceEXTDelegate_3(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkSurfaceKHR surface);
	private static CreateHeadlessSurfaceEXTDelegate_3 CreateHeadlessSurfaceEXT_3;
	[Obsolete("Use GetBufferDeviceAddress")]
	public static void GetBufferDeviceAddressKHR(VkDevice device, out VkBufferDeviceAddressInfoKHR info) => GetBufferDeviceAddressKHR_0(device, out info);
	private delegate void GetBufferDeviceAddressKHRDelegate_0(VkDevice device, out VkBufferDeviceAddressInfoKHR info);
	private static GetBufferDeviceAddressKHRDelegate_0 GetBufferDeviceAddressKHR_0;
	[Obsolete("Use GetBufferOpaqueCaptureAddress")]
	public static void GetBufferOpaqueCaptureAddressKHR(VkDevice device, out VkBufferDeviceAddressInfoKHR info) => GetBufferOpaqueCaptureAddressKHR_0(device, out info);
	private delegate void GetBufferOpaqueCaptureAddressKHRDelegate_0(VkDevice device, out VkBufferDeviceAddressInfoKHR info);
	private static GetBufferOpaqueCaptureAddressKHRDelegate_0 GetBufferOpaqueCaptureAddressKHR_0;
	[Obsolete("Use GetDeviceMemoryOpaqueCaptureAddress")]
	public static void GetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfoKHR info) => GetDeviceMemoryOpaqueCaptureAddressKHR_0(device, out info);
	private delegate void GetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0(VkDevice device, out VkDeviceMemoryOpaqueCaptureAddressInfoKHR info);
	private static GetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0 GetDeviceMemoryOpaqueCaptureAddressKHR_0;
	public static void CommandSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern) => CommandSetLineStippleEXT_0(commandBuffer, lineStippleFactor, lineStipplePattern);
	private delegate void CommandSetLineStippleEXTDelegate_0(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
	private static CommandSetLineStippleEXTDelegate_0 CommandSetLineStippleEXT_0;
	[Obsolete("Use ResetQueryPool")]
	public static void ResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount) => ResetQueryPoolEXT_0(device, queryPool, firstQuery, queryCount);
	private delegate void ResetQueryPoolEXTDelegate_0(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
	private static ResetQueryPoolEXTDelegate_0 ResetQueryPoolEXT_0;
	public static void CommandSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode) => CommandSetCullModeEXT_0(commandBuffer, cullMode);
	private delegate void CommandSetCullModeEXTDelegate_0(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);
	private static CommandSetCullModeEXTDelegate_0 CommandSetCullModeEXT_0;
	public static void CommandSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace) => CommandSetFrontFaceEXT_0(commandBuffer, frontFace);
	private delegate void CommandSetFrontFaceEXTDelegate_0(VkCommandBuffer commandBuffer, VkFrontFace frontFace);
	private static CommandSetFrontFaceEXTDelegate_0 CommandSetFrontFaceEXT_0;
	public static void CommandSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology) => CommandSetPrimitiveTopologyEXT_0(commandBuffer, primitiveTopology);
	private delegate void CommandSetPrimitiveTopologyEXTDelegate_0(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);
	private static CommandSetPrimitiveTopologyEXTDelegate_0 CommandSetPrimitiveTopologyEXT_0;
	public static void CommandSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport[] viewports) => CommandSetViewportWithCountEXT_0(commandBuffer, viewportCount, viewports);
	private delegate void CommandSetViewportWithCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport[] viewports);
	private static CommandSetViewportWithCountEXTDelegate_0 CommandSetViewportWithCountEXT_0;
	public static void CommandSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D[] scissors) => CommandSetScissorWithCountEXT_0(commandBuffer, scissorCount, scissors);
	private delegate void CommandSetScissorWithCountEXTDelegate_0(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D[] scissors);
	private static CommandSetScissorWithCountEXTDelegate_0 CommandSetScissorWithCountEXT_0;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_0(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_0(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_0 CommandBindVertexBuffers2EXT_0;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_1(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_1(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_1 CommandBindVertexBuffers2EXT_1;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_2(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_2 CommandBindVertexBuffers2EXT_2;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_3(commandBuffer, firstBinding, bindingCount, buffers, offsets, ref sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_3(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_3 CommandBindVertexBuffers2EXT_3;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_4(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_4(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_4 CommandBindVertexBuffers2EXT_4;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_5(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_5(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_5 CommandBindVertexBuffers2EXT_5;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_6(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_6(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_6 CommandBindVertexBuffers2EXT_6;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_7(commandBuffer, firstBinding, bindingCount, buffers, ref offsets, ref sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_7(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_7 CommandBindVertexBuffers2EXT_7;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_8(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_8(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_8 CommandBindVertexBuffers2EXT_8;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_9(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_9(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_9 CommandBindVertexBuffers2EXT_9;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_10(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_10(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_10 CommandBindVertexBuffers2EXT_10;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_11(commandBuffer, firstBinding, bindingCount, ref buffers, offsets, ref sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_11(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, VkDeviceSize* offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_11 CommandBindVertexBuffers2EXT_11;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_12(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_12(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_12 CommandBindVertexBuffers2EXT_12;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_13(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_13(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, VkDeviceSize* sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_13 CommandBindVertexBuffers2EXT_13;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides) => CommandBindVertexBuffers2EXT_14(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes, strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_14(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, VkDeviceSize* strides);
	private static CommandBindVertexBuffers2EXTDelegate_14 CommandBindVertexBuffers2EXT_14;
	public static void CommandBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides) => CommandBindVertexBuffers2EXT_15(commandBuffer, firstBinding, bindingCount, ref buffers, ref offsets, ref sizes, ref strides);
	private delegate void CommandBindVertexBuffers2EXTDelegate_15(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer buffers, ref VkDeviceSize offsets, ref VkDeviceSize sizes, ref VkDeviceSize strides);
	private static CommandBindVertexBuffers2EXTDelegate_15 CommandBindVertexBuffers2EXT_15;
	public static void CommandSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable) => CommandSetDepthTestEnableEXT_0(commandBuffer, depthTestEnable);
	private delegate void CommandSetDepthTestEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);
	private static CommandSetDepthTestEnableEXTDelegate_0 CommandSetDepthTestEnableEXT_0;
	public static void CommandSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable) => CommandSetDepthWriteEnableEXT_0(commandBuffer, depthWriteEnable);
	private delegate void CommandSetDepthWriteEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);
	private static CommandSetDepthWriteEnableEXTDelegate_0 CommandSetDepthWriteEnableEXT_0;
	public static void CommandSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp) => CommandSetDepthCompareOpEXT_0(commandBuffer, depthCompareOp);
	private delegate void CommandSetDepthCompareOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);
	private static CommandSetDepthCompareOpEXTDelegate_0 CommandSetDepthCompareOpEXT_0;
	public static void CommandSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable) => CommandSetDepthBoundsTestEnableEXT_0(commandBuffer, depthBoundsTestEnable);
	private delegate void CommandSetDepthBoundsTestEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);
	private static CommandSetDepthBoundsTestEnableEXTDelegate_0 CommandSetDepthBoundsTestEnableEXT_0;
	public static void CommandSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable) => CommandSetStencilTestEnableEXT_0(commandBuffer, stencilTestEnable);
	private delegate void CommandSetStencilTestEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);
	private static CommandSetStencilTestEnableEXTDelegate_0 CommandSetStencilTestEnableEXT_0;
	public static void CommandSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp) => CommandSetStencilOpEXT_0(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
	private delegate void CommandSetStencilOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);
	private static CommandSetStencilOpEXTDelegate_0 CommandSetStencilOpEXT_0;
	public static VkResult CreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* allocator, out VkDeferredOperationKHR deferredOperation) => CreateDeferredOperationKHR_0(device, allocator, out deferredOperation);
	public static bool CreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* allocator, out VkDeferredOperationKHR deferredOperation, out VkResult result)
	{
		result = CreateDeferredOperationKHR_0(device, allocator, out deferredOperation);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDeferredOperationKHRDelegate_0(VkDevice device, VkAllocationCallbacks* allocator, out VkDeferredOperationKHR deferredOperation);
	private static CreateDeferredOperationKHRDelegate_0 CreateDeferredOperationKHR_0;
	public static VkResult CreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks allocator, out VkDeferredOperationKHR deferredOperation) => CreateDeferredOperationKHR_1(device, ref allocator, out deferredOperation);
	public static bool CreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks allocator, out VkDeferredOperationKHR deferredOperation, out VkResult result)
	{
		result = CreateDeferredOperationKHR_1(device, ref allocator, out deferredOperation);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateDeferredOperationKHRDelegate_1(VkDevice device, ref VkAllocationCallbacks allocator, out VkDeferredOperationKHR deferredOperation);
	private static CreateDeferredOperationKHRDelegate_1 CreateDeferredOperationKHR_1;
	public static void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* allocator) => DestroyDeferredOperationKHR_0(device, operation, allocator);
	private delegate void DestroyDeferredOperationKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* allocator);
	private static DestroyDeferredOperationKHRDelegate_0 DestroyDeferredOperationKHR_0;
	public static void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, ref VkAllocationCallbacks allocator) => DestroyDeferredOperationKHR_1(device, operation, ref allocator);
	private delegate void DestroyDeferredOperationKHRDelegate_1(VkDevice device, VkDeferredOperationKHR operation, ref VkAllocationCallbacks allocator);
	private static DestroyDeferredOperationKHRDelegate_1 DestroyDeferredOperationKHR_1;
	public static uint GetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation) => GetDeferredOperationMaxConcurrencyKHR_0(device, operation);
	private delegate uint GetDeferredOperationMaxConcurrencyKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
	private static GetDeferredOperationMaxConcurrencyKHRDelegate_0 GetDeferredOperationMaxConcurrencyKHR_0;
	public static VkResult GetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation) => GetDeferredOperationResultKHR_0(device, operation);
	public static bool GetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation, out VkResult result)
	{
		result = GetDeferredOperationResultKHR_0(device, operation);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDeferredOperationResultKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
	private static GetDeferredOperationResultKHRDelegate_0 GetDeferredOperationResultKHR_0;
	public static VkResult DeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation) => DeferredOperationJoinKHR_0(device, operation);
	public static bool DeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation, out VkResult result)
	{
		result = DeferredOperationJoinKHR_0(device, operation);
		return result == VkResult.Success;
	}
	private delegate VkResult DeferredOperationJoinKHRDelegate_0(VkDevice device, VkDeferredOperationKHR operation);
	private static DeferredOperationJoinKHRDelegate_0 DeferredOperationJoinKHR_0;
	public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_0(device, pipelineInfo, executableCount, properties);
	public static bool GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties, out VkResult result)
	{
		result = GetPipelineExecutablePropertiesKHR_0(device, pipelineInfo, executableCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_0(VkDevice device, VkPipelineInfoKHR* pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
	private static GetPipelineExecutablePropertiesKHRDelegate_0 GetPipelineExecutablePropertiesKHR_0;
	public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_1(device, pipelineInfo, ref executableCount, properties);
	public static bool GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties, out VkResult result)
	{
		result = GetPipelineExecutablePropertiesKHR_1(device, pipelineInfo, ref executableCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_1(VkDevice device, VkPipelineInfoKHR* pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
	private static GetPipelineExecutablePropertiesKHRDelegate_1 GetPipelineExecutablePropertiesKHR_1;
	public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_2(device, ref pipelineInfo, executableCount, properties);
	public static bool GetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties, out VkResult result)
	{
		result = GetPipelineExecutablePropertiesKHR_2(device, ref pipelineInfo, executableCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_2(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, uint* executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
	private static GetPipelineExecutablePropertiesKHRDelegate_2 GetPipelineExecutablePropertiesKHR_2;
	public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties) => GetPipelineExecutablePropertiesKHR_3(device, ref pipelineInfo, ref executableCount, properties);
	public static bool GetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties, out VkResult result)
	{
		result = GetPipelineExecutablePropertiesKHR_3(device, ref pipelineInfo, ref executableCount, properties);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutablePropertiesKHRDelegate_3(VkDevice device, ref VkPipelineInfoKHR pipelineInfo, ref uint executableCount, [In, Out] VkPipelineExecutablePropertiesKHR[] properties);
	private static GetPipelineExecutablePropertiesKHRDelegate_3 GetPipelineExecutablePropertiesKHR_3;
	public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_0(device, executableInfo, statisticCount, statistics);
	public static bool GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics, out VkResult result)
	{
		result = GetPipelineExecutableStatisticsKHR_0(device, executableInfo, statisticCount, statistics);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
	private static GetPipelineExecutableStatisticsKHRDelegate_0 GetPipelineExecutableStatisticsKHR_0;
	public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_1(device, executableInfo, ref statisticCount, statistics);
	public static bool GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics, out VkResult result)
	{
		result = GetPipelineExecutableStatisticsKHR_1(device, executableInfo, ref statisticCount, statistics);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_1(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
	private static GetPipelineExecutableStatisticsKHRDelegate_1 GetPipelineExecutableStatisticsKHR_1;
	public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_2(device, ref executableInfo, statisticCount, statistics);
	public static bool GetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics, out VkResult result)
	{
		result = GetPipelineExecutableStatisticsKHR_2(device, ref executableInfo, statisticCount, statistics);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_2(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
	private static GetPipelineExecutableStatisticsKHRDelegate_2 GetPipelineExecutableStatisticsKHR_2;
	public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics) => GetPipelineExecutableStatisticsKHR_3(device, ref executableInfo, ref statisticCount, statistics);
	public static bool GetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics, out VkResult result)
	{
		result = GetPipelineExecutableStatisticsKHR_3(device, ref executableInfo, ref statisticCount, statistics);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableStatisticsKHRDelegate_3(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint statisticCount, [In, Out] VkPipelineExecutableStatisticKHR[] statistics);
	private static GetPipelineExecutableStatisticsKHRDelegate_3 GetPipelineExecutableStatisticsKHR_3;
	public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_0(device, executableInfo, internalRepresentationCount, internalRepresentations);
	public static bool GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations, out VkResult result)
	{
		result = GetPipelineExecutableInternalRepresentationsKHR_0(device, executableInfo, internalRepresentationCount, internalRepresentations);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_0(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
	private static GetPipelineExecutableInternalRepresentationsKHRDelegate_0 GetPipelineExecutableInternalRepresentationsKHR_0;
	public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_1(device, executableInfo, ref internalRepresentationCount, internalRepresentations);
	public static bool GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations, out VkResult result)
	{
		result = GetPipelineExecutableInternalRepresentationsKHR_1(device, executableInfo, ref internalRepresentationCount, internalRepresentations);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_1(VkDevice device, VkPipelineExecutableInfoKHR* executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
	private static GetPipelineExecutableInternalRepresentationsKHRDelegate_1 GetPipelineExecutableInternalRepresentationsKHR_1;
	public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_2(device, ref executableInfo, internalRepresentationCount, internalRepresentations);
	public static bool GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations, out VkResult result)
	{
		result = GetPipelineExecutableInternalRepresentationsKHR_2(device, ref executableInfo, internalRepresentationCount, internalRepresentations);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_2(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, uint* internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
	private static GetPipelineExecutableInternalRepresentationsKHRDelegate_2 GetPipelineExecutableInternalRepresentationsKHR_2;
	public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations) => GetPipelineExecutableInternalRepresentationsKHR_3(device, ref executableInfo, ref internalRepresentationCount, internalRepresentations);
	public static bool GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations, out VkResult result)
	{
		result = GetPipelineExecutableInternalRepresentationsKHR_3(device, ref executableInfo, ref internalRepresentationCount, internalRepresentations);
		return result == VkResult.Success;
	}
	private delegate VkResult GetPipelineExecutableInternalRepresentationsKHRDelegate_3(VkDevice device, ref VkPipelineExecutableInfoKHR executableInfo, ref uint internalRepresentationCount, [In, Out] VkPipelineExecutableInternalRepresentationKHR[] internalRepresentations);
	private static GetPipelineExecutableInternalRepresentationsKHRDelegate_3 GetPipelineExecutableInternalRepresentationsKHR_3;
	public static void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* info, out VkMemoryRequirements2 memoryRequirements) => GetGeneratedCommandsMemoryRequirementsNV_0(device, info, out memoryRequirements);
	private delegate void GetGeneratedCommandsMemoryRequirementsNVDelegate_0(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* info, out VkMemoryRequirements2 memoryRequirements);
	private static GetGeneratedCommandsMemoryRequirementsNVDelegate_0 GetGeneratedCommandsMemoryRequirementsNV_0;
	public static void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV info, out VkMemoryRequirements2 memoryRequirements) => GetGeneratedCommandsMemoryRequirementsNV_1(device, ref info, out memoryRequirements);
	private delegate void GetGeneratedCommandsMemoryRequirementsNVDelegate_1(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV info, out VkMemoryRequirements2 memoryRequirements);
	private static GetGeneratedCommandsMemoryRequirementsNVDelegate_1 GetGeneratedCommandsMemoryRequirementsNV_1;
	public static void CommandPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* generatedCommandsInfo) => CommandPreprocessGeneratedCommandsNV_0(commandBuffer, generatedCommandsInfo);
	private delegate void CommandPreprocessGeneratedCommandsNVDelegate_0(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* generatedCommandsInfo);
	private static CommandPreprocessGeneratedCommandsNVDelegate_0 CommandPreprocessGeneratedCommandsNV_0;
	public static void CommandPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, ref VkGeneratedCommandsInfoNV generatedCommandsInfo) => CommandPreprocessGeneratedCommandsNV_1(commandBuffer, ref generatedCommandsInfo);
	private delegate void CommandPreprocessGeneratedCommandsNVDelegate_1(VkCommandBuffer commandBuffer, ref VkGeneratedCommandsInfoNV generatedCommandsInfo);
	private static CommandPreprocessGeneratedCommandsNVDelegate_1 CommandPreprocessGeneratedCommandsNV_1;
	public static void CommandExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* generatedCommandsInfo) => CommandExecuteGeneratedCommandsNV_0(commandBuffer, isPreprocessed, generatedCommandsInfo);
	private delegate void CommandExecuteGeneratedCommandsNVDelegate_0(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* generatedCommandsInfo);
	private static CommandExecuteGeneratedCommandsNVDelegate_0 CommandExecuteGeneratedCommandsNV_0;
	public static void CommandExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, ref VkGeneratedCommandsInfoNV generatedCommandsInfo) => CommandExecuteGeneratedCommandsNV_1(commandBuffer, isPreprocessed, ref generatedCommandsInfo);
	private delegate void CommandExecuteGeneratedCommandsNVDelegate_1(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, ref VkGeneratedCommandsInfoNV generatedCommandsInfo);
	private static CommandExecuteGeneratedCommandsNVDelegate_1 CommandExecuteGeneratedCommandsNV_1;
	public static void CommandBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex) => CommandBindPipelineShaderGroupNV_0(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
	private delegate void CommandBindPipelineShaderGroupNVDelegate_0(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
	private static CommandBindPipelineShaderGroupNVDelegate_0 CommandBindPipelineShaderGroupNV_0;
	public static VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_0(device, createInfo, allocator, out indirectCommandsLayout);
	public static bool CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout, out VkResult result)
	{
		result = CreateIndirectCommandsLayoutNV_0(device, createInfo, allocator, out indirectCommandsLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateIndirectCommandsLayoutNVDelegate_0(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVDelegate_0 CreateIndirectCommandsLayoutNV_0;
	public static VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_1(device, createInfo, ref allocator, out indirectCommandsLayout);
	public static bool CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout, out VkResult result)
	{
		result = CreateIndirectCommandsLayoutNV_1(device, createInfo, ref allocator, out indirectCommandsLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateIndirectCommandsLayoutNVDelegate_1(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVDelegate_1 CreateIndirectCommandsLayoutNV_1;
	public static VkResult CreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_2(device, ref createInfo, allocator, out indirectCommandsLayout);
	public static bool CreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout, out VkResult result)
	{
		result = CreateIndirectCommandsLayoutNV_2(device, ref createInfo, allocator, out indirectCommandsLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateIndirectCommandsLayoutNVDelegate_2(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, VkAllocationCallbacks* allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVDelegate_2 CreateIndirectCommandsLayoutNV_2;
	public static VkResult CreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout) => CreateIndirectCommandsLayoutNV_3(device, ref createInfo, ref allocator, out indirectCommandsLayout);
	public static bool CreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout, out VkResult result)
	{
		result = CreateIndirectCommandsLayoutNV_3(device, ref createInfo, ref allocator, out indirectCommandsLayout);
		return result == VkResult.Success;
	}
	private delegate VkResult CreateIndirectCommandsLayoutNVDelegate_3(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV createInfo, ref VkAllocationCallbacks allocator, out VkIndirectCommandsLayoutNV indirectCommandsLayout);
	private static CreateIndirectCommandsLayoutNVDelegate_3 CreateIndirectCommandsLayoutNV_3;
	public static void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* allocator) => DestroyIndirectCommandsLayoutNV_0(device, indirectCommandsLayout, allocator);
	private delegate void DestroyIndirectCommandsLayoutNVDelegate_0(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* allocator);
	private static DestroyIndirectCommandsLayoutNVDelegate_0 DestroyIndirectCommandsLayoutNV_0;
	public static void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, ref VkAllocationCallbacks allocator) => DestroyIndirectCommandsLayoutNV_1(device, indirectCommandsLayout, ref allocator);
	private delegate void DestroyIndirectCommandsLayoutNVDelegate_1(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, ref VkAllocationCallbacks allocator);
	private static DestroyIndirectCommandsLayoutNVDelegate_1 DestroyIndirectCommandsLayoutNV_1;
	public static VkResult AcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFileDescriptor, VkDisplayKHR display) => AcquireDrmDisplayEXT_0(physicalDevice, drmFileDescriptor, display);
	public static bool AcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFileDescriptor, VkDisplayKHR display, out VkResult result)
	{
		result = AcquireDrmDisplayEXT_0(physicalDevice, drmFileDescriptor, display);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireDrmDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, int drmFileDescriptor, VkDisplayKHR display);
	private static AcquireDrmDisplayEXTDelegate_0 AcquireDrmDisplayEXT_0;
	public static VkResult GetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFileDescriptor, uint connectorId, out VkDisplayKHR display) => GetDrmDisplayEXT_0(physicalDevice, drmFileDescriptor, connectorId, out display);
	public static bool GetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFileDescriptor, uint connectorId, out VkDisplayKHR display, out VkResult result)
	{
		result = GetDrmDisplayEXT_0(physicalDevice, drmFileDescriptor, connectorId, out display);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDrmDisplayEXTDelegate_0(VkPhysicalDevice physicalDevice, int drmFileDescriptor, uint connectorId, out VkDisplayKHR display);
	private static GetDrmDisplayEXTDelegate_0 GetDrmDisplayEXT_0;
	public static VkResult CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlotEXT privateDataSlot) => CreatePrivateDataSlotEXT_0(device, createInfo, allocator, out privateDataSlot);
	public static bool CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlotEXT privateDataSlot, out VkResult result)
	{
		result = CreatePrivateDataSlotEXT_0(device, createInfo, allocator, out privateDataSlot);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePrivateDataSlotEXTDelegate_0(VkDevice device, VkPrivateDataSlotCreateInfoEXT* createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlotEXT privateDataSlot);
	private static CreatePrivateDataSlotEXTDelegate_0 CreatePrivateDataSlotEXT_0;
	public static VkResult CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlotEXT privateDataSlot) => CreatePrivateDataSlotEXT_1(device, createInfo, ref allocator, out privateDataSlot);
	public static bool CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlotEXT privateDataSlot, out VkResult result)
	{
		result = CreatePrivateDataSlotEXT_1(device, createInfo, ref allocator, out privateDataSlot);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePrivateDataSlotEXTDelegate_1(VkDevice device, VkPrivateDataSlotCreateInfoEXT* createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlotEXT privateDataSlot);
	private static CreatePrivateDataSlotEXTDelegate_1 CreatePrivateDataSlotEXT_1;
	public static VkResult CreatePrivateDataSlotEXT(VkDevice device, ref VkPrivateDataSlotCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlotEXT privateDataSlot) => CreatePrivateDataSlotEXT_2(device, ref createInfo, allocator, out privateDataSlot);
	public static bool CreatePrivateDataSlotEXT(VkDevice device, ref VkPrivateDataSlotCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlotEXT privateDataSlot, out VkResult result)
	{
		result = CreatePrivateDataSlotEXT_2(device, ref createInfo, allocator, out privateDataSlot);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePrivateDataSlotEXTDelegate_2(VkDevice device, ref VkPrivateDataSlotCreateInfoEXT createInfo, VkAllocationCallbacks* allocator, out VkPrivateDataSlotEXT privateDataSlot);
	private static CreatePrivateDataSlotEXTDelegate_2 CreatePrivateDataSlotEXT_2;
	public static VkResult CreatePrivateDataSlotEXT(VkDevice device, ref VkPrivateDataSlotCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlotEXT privateDataSlot) => CreatePrivateDataSlotEXT_3(device, ref createInfo, ref allocator, out privateDataSlot);
	public static bool CreatePrivateDataSlotEXT(VkDevice device, ref VkPrivateDataSlotCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlotEXT privateDataSlot, out VkResult result)
	{
		result = CreatePrivateDataSlotEXT_3(device, ref createInfo, ref allocator, out privateDataSlot);
		return result == VkResult.Success;
	}
	private delegate VkResult CreatePrivateDataSlotEXTDelegate_3(VkDevice device, ref VkPrivateDataSlotCreateInfoEXT createInfo, ref VkAllocationCallbacks allocator, out VkPrivateDataSlotEXT privateDataSlot);
	private static CreatePrivateDataSlotEXTDelegate_3 CreatePrivateDataSlotEXT_3;
	public static void DestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, VkAllocationCallbacks* allocator) => DestroyPrivateDataSlotEXT_0(device, privateDataSlot, allocator);
	private delegate void DestroyPrivateDataSlotEXTDelegate_0(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, VkAllocationCallbacks* allocator);
	private static DestroyPrivateDataSlotEXTDelegate_0 DestroyPrivateDataSlotEXT_0;
	public static void DestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, ref VkAllocationCallbacks allocator) => DestroyPrivateDataSlotEXT_1(device, privateDataSlot, ref allocator);
	private delegate void DestroyPrivateDataSlotEXTDelegate_1(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, ref VkAllocationCallbacks allocator);
	private static DestroyPrivateDataSlotEXTDelegate_1 DestroyPrivateDataSlotEXT_1;
	public static VkResult SetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data) => SetPrivateDataEXT_0(device, objectType, objectHandle, privateDataSlot, data);
	public static bool SetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data, out VkResult result)
	{
		result = SetPrivateDataEXT_0(device, objectType, objectHandle, privateDataSlot, data);
		return result == VkResult.Success;
	}
	private delegate VkResult SetPrivateDataEXTDelegate_0(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data);
	private static SetPrivateDataEXTDelegate_0 SetPrivateDataEXT_0;
	public static void GetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, out ulong data) => GetPrivateDataEXT_0(device, objectType, objectHandle, privateDataSlot, out data);
	private delegate void GetPrivateDataEXTDelegate_0(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, out ulong data);
	private static GetPrivateDataEXTDelegate_0 GetPrivateDataEXT_0;
	public static void CommandSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfoKHR* dependencyInfo) => CommandSetEvent2KHR_0(commandBuffer, @event, dependencyInfo);
	private delegate void CommandSetEvent2KHRDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfoKHR* dependencyInfo);
	private static CommandSetEvent2KHRDelegate_0 CommandSetEvent2KHR_0;
	public static void CommandSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, ref VkDependencyInfoKHR dependencyInfo) => CommandSetEvent2KHR_1(commandBuffer, @event, ref dependencyInfo);
	private delegate void CommandSetEvent2KHRDelegate_1(VkCommandBuffer commandBuffer, VkEvent @event, ref VkDependencyInfoKHR dependencyInfo);
	private static CommandSetEvent2KHRDelegate_1 CommandSetEvent2KHR_1;
	public static void CommandResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2KHR stageMask) => CommandResetEvent2KHR_0(commandBuffer, @event, stageMask);
	private delegate void CommandResetEvent2KHRDelegate_0(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2KHR stageMask);
	private static CommandResetEvent2KHRDelegate_0 CommandResetEvent2KHR_0;
	public static void CommandWaitEvents2KHR(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkDependencyInfoKHR[] dependencyInfos) => CommandWaitEvents2KHR_0(commandBuffer, eventCount, events, dependencyInfos);
	private delegate void CommandWaitEvents2KHRDelegate_0(VkCommandBuffer commandBuffer, uint eventCount, VkEvent[] events, VkDependencyInfoKHR[] dependencyInfos);
	private static CommandWaitEvents2KHRDelegate_0 CommandWaitEvents2KHR_0;
	public static void CommandPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* dependencyInfo) => CommandPipelineBarrier2KHR_0(commandBuffer, dependencyInfo);
	private delegate void CommandPipelineBarrier2KHRDelegate_0(VkCommandBuffer commandBuffer, VkDependencyInfoKHR* dependencyInfo);
	private static CommandPipelineBarrier2KHRDelegate_0 CommandPipelineBarrier2KHR_0;
	public static void CommandPipelineBarrier2KHR(VkCommandBuffer commandBuffer, ref VkDependencyInfoKHR dependencyInfo) => CommandPipelineBarrier2KHR_1(commandBuffer, ref dependencyInfo);
	private delegate void CommandPipelineBarrier2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkDependencyInfoKHR dependencyInfo);
	private static CommandPipelineBarrier2KHRDelegate_1 CommandPipelineBarrier2KHR_1;
	public static void CommandWriteTimestamp2KHR(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint query) => CommandWriteTimestamp2KHR_0(commandBuffer, stage, queryPool, query);
	private delegate void CommandWriteTimestamp2KHRDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint query);
	private static CommandWriteTimestamp2KHRDelegate_0 CommandWriteTimestamp2KHR_0;
	public static VkResult QueueSubmit2KHR(VkQueue queue, uint submitCount, VkSubmitInfo2KHR[] submits, VkFence fence) => QueueSubmit2KHR_0(queue, submitCount, submits, fence);
	public static bool QueueSubmit2KHR(VkQueue queue, uint submitCount, VkSubmitInfo2KHR[] submits, VkFence fence, out VkResult result)
	{
		result = QueueSubmit2KHR_0(queue, submitCount, submits, fence);
		return result == VkResult.Success;
	}
	private delegate VkResult QueueSubmit2KHRDelegate_0(VkQueue queue, uint submitCount, VkSubmitInfo2KHR[] submits, VkFence fence);
	private static QueueSubmit2KHRDelegate_0 QueueSubmit2KHR_0;
	public static void CommandWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker) => CommandWriteBufferMarker2AMD_0(commandBuffer, stage, destinationBuffer, destinationOffset, marker);
	private delegate void CommandWriteBufferMarker2AMDDelegate_0(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkBuffer destinationBuffer, VkDeviceSize destinationOffset, uint marker);
	private static CommandWriteBufferMarker2AMDDelegate_0 CommandWriteBufferMarker2AMD_0;
	public static void GetQueueCheckpointData2NV(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData) => GetQueueCheckpointData2NV_0(queue, checkpointDataCount, checkpointData);
	private delegate void GetQueueCheckpointData2NVDelegate_0(VkQueue queue, uint* checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData);
	private static GetQueueCheckpointData2NVDelegate_0 GetQueueCheckpointData2NV_0;
	public static void GetQueueCheckpointData2NV(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData) => GetQueueCheckpointData2NV_1(queue, ref checkpointDataCount, checkpointData);
	private delegate void GetQueueCheckpointData2NVDelegate_1(VkQueue queue, ref uint checkpointDataCount, [In, Out] VkCheckpointData2NV[] checkpointData);
	private static GetQueueCheckpointData2NVDelegate_1 GetQueueCheckpointData2NV_1;
	public static void CommandSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps) => CommandSetFragmentShadingRateEnumNV_0(commandBuffer, shadingRate, combinerOps);
	private delegate void CommandSetFragmentShadingRateEnumNVDelegate_0(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps);
	private static CommandSetFragmentShadingRateEnumNVDelegate_0 CommandSetFragmentShadingRateEnumNV_0;
	public static void CommandCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* copyBufferInfo) => CommandCopyBuffer2KHR_0(commandBuffer, copyBufferInfo);
	private delegate void CommandCopyBuffer2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyBufferInfo2KHR* copyBufferInfo);
	private static CommandCopyBuffer2KHRDelegate_0 CommandCopyBuffer2KHR_0;
	public static void CommandCopyBuffer2KHR(VkCommandBuffer commandBuffer, ref VkCopyBufferInfo2KHR copyBufferInfo) => CommandCopyBuffer2KHR_1(commandBuffer, ref copyBufferInfo);
	private delegate void CommandCopyBuffer2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyBufferInfo2KHR copyBufferInfo);
	private static CommandCopyBuffer2KHRDelegate_1 CommandCopyBuffer2KHR_1;
	public static void CommandCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* copyImageInfo) => CommandCopyImage2KHR_0(commandBuffer, copyImageInfo);
	private delegate void CommandCopyImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyImageInfo2KHR* copyImageInfo);
	private static CommandCopyImage2KHRDelegate_0 CommandCopyImage2KHR_0;
	public static void CommandCopyImage2KHR(VkCommandBuffer commandBuffer, ref VkCopyImageInfo2KHR copyImageInfo) => CommandCopyImage2KHR_1(commandBuffer, ref copyImageInfo);
	private delegate void CommandCopyImage2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyImageInfo2KHR copyImageInfo);
	private static CommandCopyImage2KHRDelegate_1 CommandCopyImage2KHR_1;
	public static void CommandCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* copyBufferToImageInfo) => CommandCopyBufferToImage2KHR_0(commandBuffer, copyBufferToImageInfo);
	private delegate void CommandCopyBufferToImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2KHR* copyBufferToImageInfo);
	private static CommandCopyBufferToImage2KHRDelegate_0 CommandCopyBufferToImage2KHR_0;
	public static void CommandCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, ref VkCopyBufferToImageInfo2KHR copyBufferToImageInfo) => CommandCopyBufferToImage2KHR_1(commandBuffer, ref copyBufferToImageInfo);
	private delegate void CommandCopyBufferToImage2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyBufferToImageInfo2KHR copyBufferToImageInfo);
	private static CommandCopyBufferToImage2KHRDelegate_1 CommandCopyBufferToImage2KHR_1;
	public static void CommandCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* copyImageToBufferInfo) => CommandCopyImageToBuffer2KHR_0(commandBuffer, copyImageToBufferInfo);
	private delegate void CommandCopyImageToBuffer2KHRDelegate_0(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2KHR* copyImageToBufferInfo);
	private static CommandCopyImageToBuffer2KHRDelegate_0 CommandCopyImageToBuffer2KHR_0;
	public static void CommandCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, ref VkCopyImageToBufferInfo2KHR copyImageToBufferInfo) => CommandCopyImageToBuffer2KHR_1(commandBuffer, ref copyImageToBufferInfo);
	private delegate void CommandCopyImageToBuffer2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkCopyImageToBufferInfo2KHR copyImageToBufferInfo);
	private static CommandCopyImageToBuffer2KHRDelegate_1 CommandCopyImageToBuffer2KHR_1;
	public static void CommandBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* blitImageInfo) => CommandBlitImage2KHR_0(commandBuffer, blitImageInfo);
	private delegate void CommandBlitImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkBlitImageInfo2KHR* blitImageInfo);
	private static CommandBlitImage2KHRDelegate_0 CommandBlitImage2KHR_0;
	public static void CommandBlitImage2KHR(VkCommandBuffer commandBuffer, ref VkBlitImageInfo2KHR blitImageInfo) => CommandBlitImage2KHR_1(commandBuffer, ref blitImageInfo);
	private delegate void CommandBlitImage2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkBlitImageInfo2KHR blitImageInfo);
	private static CommandBlitImage2KHRDelegate_1 CommandBlitImage2KHR_1;
	public static void CommandResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* resolveImageInfo) => CommandResolveImage2KHR_0(commandBuffer, resolveImageInfo);
	private delegate void CommandResolveImage2KHRDelegate_0(VkCommandBuffer commandBuffer, VkResolveImageInfo2KHR* resolveImageInfo);
	private static CommandResolveImage2KHRDelegate_0 CommandResolveImage2KHR_0;
	public static void CommandResolveImage2KHR(VkCommandBuffer commandBuffer, ref VkResolveImageInfo2KHR resolveImageInfo) => CommandResolveImage2KHR_1(commandBuffer, ref resolveImageInfo);
	private delegate void CommandResolveImage2KHRDelegate_1(VkCommandBuffer commandBuffer, ref VkResolveImageInfo2KHR resolveImageInfo);
	private static CommandResolveImage2KHRDelegate_1 CommandResolveImage2KHR_1;
	public static VkResult AcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display) => AcquireWinrtDisplayNV_0(physicalDevice, display);
	public static bool AcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display, out VkResult result)
	{
		result = AcquireWinrtDisplayNV_0(physicalDevice, display);
		return result == VkResult.Success;
	}
	private delegate VkResult AcquireWinrtDisplayNVDelegate_0(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
	private static AcquireWinrtDisplayNVDelegate_0 AcquireWinrtDisplayNV_0;
	public static VkResult GetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR display) => GetWinrtDisplayNV_0(physicalDevice, deviceRelativeId, out display);
	public static bool GetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR display, out VkResult result)
	{
		result = GetWinrtDisplayNV_0(physicalDevice, deviceRelativeId, out display);
		return result == VkResult.Success;
	}
	private delegate VkResult GetWinrtDisplayNVDelegate_0(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR display);
	private static GetWinrtDisplayNVDelegate_0 GetWinrtDisplayNV_0;
	public static void CommandSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT[] vertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT[] vertexAttributeDescriptions) => CommandSetVertexInputEXT_0(commandBuffer, vertexBindingDescriptionCount, vertexBindingDescriptions, vertexAttributeDescriptionCount, vertexAttributeDescriptions);
	private delegate void CommandSetVertexInputEXTDelegate_0(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT[] vertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT[] vertexAttributeDescriptions);
	private static CommandSetVertexInputEXTDelegate_0 CommandSetVertexInputEXT_0;
	public static VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, out VkExtent2D maxWorkgroupSize) => GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0(device, renderpass, out maxWorkgroupSize);
	public static bool GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, out VkExtent2D maxWorkgroupSize, out VkResult result)
	{
		result = GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0(device, renderpass, out maxWorkgroupSize);
		return result == VkResult.Success;
	}
	private delegate VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0(VkDevice device, VkRenderPass renderpass, out VkExtent2D maxWorkgroupSize);
	private static GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0 GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0;
	public static void CommandSubpassShadingHUAWEI(VkCommandBuffer commandBuffer) => CommandSubpassShadingHUAWEI_0(commandBuffer);
	private delegate void CommandSubpassShadingHUAWEIDelegate_0(VkCommandBuffer commandBuffer);
	private static CommandSubpassShadingHUAWEIDelegate_0 CommandSubpassShadingHUAWEI_0;
	public static void CommandBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout) => CommandBindInvocationMaskHUAWEI_0(commandBuffer, imageView, imageLayout);
	private delegate void CommandBindInvocationMaskHUAWEIDelegate_0(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
	private static CommandBindInvocationMaskHUAWEIDelegate_0 CommandBindInvocationMaskHUAWEI_0;
	public static VkResult GetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* memoryGetRemoteAddressInfo, out IntPtr address) => GetMemoryRemoteAddressNV_0(device, memoryGetRemoteAddressInfo, out address);
	public static bool GetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* memoryGetRemoteAddressInfo, out IntPtr address, out VkResult result)
	{
		result = GetMemoryRemoteAddressNV_0(device, memoryGetRemoteAddressInfo, out address);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryRemoteAddressNVDelegate_0(VkDevice device, VkMemoryGetRemoteAddressInfoNV* memoryGetRemoteAddressInfo, out IntPtr address);
	private static GetMemoryRemoteAddressNVDelegate_0 GetMemoryRemoteAddressNV_0;
	public static VkResult GetMemoryRemoteAddressNV(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV memoryGetRemoteAddressInfo, out IntPtr address) => GetMemoryRemoteAddressNV_1(device, ref memoryGetRemoteAddressInfo, out address);
	public static bool GetMemoryRemoteAddressNV(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV memoryGetRemoteAddressInfo, out IntPtr address, out VkResult result)
	{
		result = GetMemoryRemoteAddressNV_1(device, ref memoryGetRemoteAddressInfo, out address);
		return result == VkResult.Success;
	}
	private delegate VkResult GetMemoryRemoteAddressNVDelegate_1(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV memoryGetRemoteAddressInfo, out IntPtr address);
	private static GetMemoryRemoteAddressNVDelegate_1 GetMemoryRemoteAddressNV_1;
	public static void CommandSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints) => CommandSetPatchControlPointsEXT_0(commandBuffer, patchControlPoints);
	private delegate void CommandSetPatchControlPointsEXTDelegate_0(VkCommandBuffer commandBuffer, uint patchControlPoints);
	private static CommandSetPatchControlPointsEXTDelegate_0 CommandSetPatchControlPointsEXT_0;
	public static void CommandSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable) => CommandSetRasterizerDiscardEnableEXT_0(commandBuffer, rasterizerDiscardEnable);
	private delegate void CommandSetRasterizerDiscardEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);
	private static CommandSetRasterizerDiscardEnableEXTDelegate_0 CommandSetRasterizerDiscardEnableEXT_0;
	public static void CommandSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable) => CommandSetDepthBiasEnableEXT_0(commandBuffer, depthBiasEnable);
	private delegate void CommandSetDepthBiasEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);
	private static CommandSetDepthBiasEnableEXTDelegate_0 CommandSetDepthBiasEnableEXT_0;
	public static void CommandSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp) => CommandSetLogicOpEXT_0(commandBuffer, logicOp);
	private delegate void CommandSetLogicOpEXTDelegate_0(VkCommandBuffer commandBuffer, VkLogicOp logicOp);
	private static CommandSetLogicOpEXTDelegate_0 CommandSetLogicOpEXT_0;
	public static void CommandSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable) => CommandSetPrimitiveRestartEnableEXT_0(commandBuffer, primitiveRestartEnable);
	private delegate void CommandSetPrimitiveRestartEnableEXTDelegate_0(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);
	private static CommandSetPrimitiveRestartEnableEXTDelegate_0 CommandSetPrimitiveRestartEnableEXT_0;
	public static void CommandSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* colorWriteEnables) => CommandSetColorWriteEnableEXT_0(commandBuffer, attachmentCount, colorWriteEnables);
	private delegate void CommandSetColorWriteEnableEXTDelegate_0(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* colorWriteEnables);
	private static CommandSetColorWriteEnableEXTDelegate_0 CommandSetColorWriteEnableEXT_0;
	public static void CommandSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, ref VkBool32 colorWriteEnables) => CommandSetColorWriteEnableEXT_1(commandBuffer, attachmentCount, ref colorWriteEnables);
	private delegate void CommandSetColorWriteEnableEXTDelegate_1(VkCommandBuffer commandBuffer, uint attachmentCount, ref VkBool32 colorWriteEnables);
	private static CommandSetColorWriteEnableEXTDelegate_1 CommandSetColorWriteEnableEXT_1;
	public static void CommandDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* vertexInfo, uint instanceCount, uint firstInstance, uint stride) => CommandDrawMultiEXT_0(commandBuffer, drawCount, vertexInfo, instanceCount, firstInstance, stride);
	private delegate void CommandDrawMultiEXTDelegate_0(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* vertexInfo, uint instanceCount, uint firstInstance, uint stride);
	private static CommandDrawMultiEXTDelegate_0 CommandDrawMultiEXT_0;
	public static void CommandDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawInfoEXT vertexInfo, uint instanceCount, uint firstInstance, uint stride) => CommandDrawMultiEXT_1(commandBuffer, drawCount, ref vertexInfo, instanceCount, firstInstance, stride);
	private delegate void CommandDrawMultiEXTDelegate_1(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawInfoEXT vertexInfo, uint instanceCount, uint firstInstance, uint stride);
	private static CommandDrawMultiEXTDelegate_1 CommandDrawMultiEXT_1;
	public static void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset) => CommandDrawMultiIndexedEXT_0(commandBuffer, drawCount, indexInfo, instanceCount, firstInstance, stride, vertexOffset);
	private delegate void CommandDrawMultiIndexedEXTDelegate_0(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset);
	private static CommandDrawMultiIndexedEXTDelegate_0 CommandDrawMultiIndexedEXT_0;
	public static void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset) => CommandDrawMultiIndexedEXT_1(commandBuffer, drawCount, indexInfo, instanceCount, firstInstance, stride, ref vertexOffset);
	private delegate void CommandDrawMultiIndexedEXTDelegate_1(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset);
	private static CommandDrawMultiIndexedEXTDelegate_1 CommandDrawMultiIndexedEXT_1;
	public static void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset) => CommandDrawMultiIndexedEXT_2(commandBuffer, drawCount, ref indexInfo, instanceCount, firstInstance, stride, vertexOffset);
	private delegate void CommandDrawMultiIndexedEXTDelegate_2(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, int* vertexOffset);
	private static CommandDrawMultiIndexedEXTDelegate_2 CommandDrawMultiIndexedEXT_2;
	public static void CommandDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset) => CommandDrawMultiIndexedEXT_3(commandBuffer, drawCount, ref indexInfo, instanceCount, firstInstance, stride, ref vertexOffset);
	private delegate void CommandDrawMultiIndexedEXTDelegate_3(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT indexInfo, uint instanceCount, uint firstInstance, uint stride, ref int vertexOffset);
	private static CommandDrawMultiIndexedEXTDelegate_3 CommandDrawMultiIndexedEXT_3;
	public static void SetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority) => SetDeviceMemoryPriorityEXT_0(device, memory, priority);
	private delegate void SetDeviceMemoryPriorityEXTDelegate_0(VkDevice device, VkDeviceMemory memory, float priority);
	private static SetDeviceMemoryPriorityEXTDelegate_0 SetDeviceMemoryPriorityEXT_0;
	public static void GetDeviceBufferMemoryRequirementsKHR(VkDevice device, VkDeviceBufferMemoryRequirementsKHR* info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceBufferMemoryRequirementsKHR_0(device, info, out memoryRequirements);
	private delegate void GetDeviceBufferMemoryRequirementsKHRDelegate_0(VkDevice device, VkDeviceBufferMemoryRequirementsKHR* info, out VkMemoryRequirements2 memoryRequirements);
	private static GetDeviceBufferMemoryRequirementsKHRDelegate_0 GetDeviceBufferMemoryRequirementsKHR_0;
	public static void GetDeviceBufferMemoryRequirementsKHR(VkDevice device, ref VkDeviceBufferMemoryRequirementsKHR info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceBufferMemoryRequirementsKHR_1(device, ref info, out memoryRequirements);
	private delegate void GetDeviceBufferMemoryRequirementsKHRDelegate_1(VkDevice device, ref VkDeviceBufferMemoryRequirementsKHR info, out VkMemoryRequirements2 memoryRequirements);
	private static GetDeviceBufferMemoryRequirementsKHRDelegate_1 GetDeviceBufferMemoryRequirementsKHR_1;
	public static void GetDeviceImageMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirementsKHR* info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceImageMemoryRequirementsKHR_0(device, info, out memoryRequirements);
	private delegate void GetDeviceImageMemoryRequirementsKHRDelegate_0(VkDevice device, VkDeviceImageMemoryRequirementsKHR* info, out VkMemoryRequirements2 memoryRequirements);
	private static GetDeviceImageMemoryRequirementsKHRDelegate_0 GetDeviceImageMemoryRequirementsKHR_0;
	public static void GetDeviceImageMemoryRequirementsKHR(VkDevice device, ref VkDeviceImageMemoryRequirementsKHR info, out VkMemoryRequirements2 memoryRequirements) => GetDeviceImageMemoryRequirementsKHR_1(device, ref info, out memoryRequirements);
	private delegate void GetDeviceImageMemoryRequirementsKHRDelegate_1(VkDevice device, ref VkDeviceImageMemoryRequirementsKHR info, out VkMemoryRequirements2 memoryRequirements);
	private static GetDeviceImageMemoryRequirementsKHRDelegate_1 GetDeviceImageMemoryRequirementsKHR_1;
	public static void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirementsKHR* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirementsKHR_0(device, info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetDeviceImageSparseMemoryRequirementsKHRDelegate_0(VkDevice device, VkDeviceImageMemoryRequirementsKHR* info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetDeviceImageSparseMemoryRequirementsKHRDelegate_0 GetDeviceImageSparseMemoryRequirementsKHR_0;
	public static void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirementsKHR* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirementsKHR_1(device, info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetDeviceImageSparseMemoryRequirementsKHRDelegate_1(VkDevice device, VkDeviceImageMemoryRequirementsKHR* info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetDeviceImageSparseMemoryRequirementsKHRDelegate_1 GetDeviceImageSparseMemoryRequirementsKHR_1;
	public static void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, ref VkDeviceImageMemoryRequirementsKHR info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirementsKHR_2(device, ref info, sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetDeviceImageSparseMemoryRequirementsKHRDelegate_2(VkDevice device, ref VkDeviceImageMemoryRequirementsKHR info, uint* sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetDeviceImageSparseMemoryRequirementsKHRDelegate_2 GetDeviceImageSparseMemoryRequirementsKHR_2;
	public static void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, ref VkDeviceImageMemoryRequirementsKHR info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements) => GetDeviceImageSparseMemoryRequirementsKHR_3(device, ref info, ref sparseMemoryRequirementCount, sparseMemoryRequirements);
	private delegate void GetDeviceImageSparseMemoryRequirementsKHRDelegate_3(VkDevice device, ref VkDeviceImageMemoryRequirementsKHR info, ref uint sparseMemoryRequirementCount, [In, Out] VkSparseImageMemoryRequirements2[] sparseMemoryRequirements);
	private static GetDeviceImageSparseMemoryRequirementsKHRDelegate_3 GetDeviceImageSparseMemoryRequirementsKHR_3;
	private static readonly OSVulkanLibraryBase VulkanLibrary;
	static VK()
	{
		VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();
		InitialiseRequiredMethods();
	}
	private static void InitialiseRequiredMethods()
	{
		var createInstance = VulkanLibrary.GetFunctionPointer("vkCreateInstance");
		CreateInstance_0 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_0>(createInstance);
		CreateInstance_1 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_1>(createInstance);
		CreateInstance_2 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_2>(createInstance);
		CreateInstance_3 = Marshal.GetDelegateForFunctionPointer<CreateInstanceDelegate_3>(createInstance);
		var getInstanceProcedureAddress = VulkanLibrary.GetFunctionPointer("vkGetInstanceProcAddr");
		GetInstanceProcedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetInstanceProcedureAddressDelegate_0>(getInstanceProcedureAddress);
		var enumerateInstanceExtensionProperties = VulkanLibrary.GetFunctionPointer("vkEnumerateInstanceExtensionProperties");
		EnumerateInstanceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_0>(enumerateInstanceExtensionProperties);
		EnumerateInstanceExtensionProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceExtensionPropertiesDelegate_1>(enumerateInstanceExtensionProperties);
		var enumerateInstanceLayerProperties = VulkanLibrary.GetFunctionPointer("vkEnumerateInstanceLayerProperties");
		EnumerateInstanceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_0>(enumerateInstanceLayerProperties);
		EnumerateInstanceLayerProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceLayerPropertiesDelegate_1>(enumerateInstanceLayerProperties);
	}
	public static void InitialiseInstanceMethods(VkInstance instance)
	{
		var destroyInstance = (nint)GetInstanceProcedureAddress(instance, "vkDestroyInstance");
		if (destroyInstance != nint.Zero)
		{
			DestroyInstance_0 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_0>(destroyInstance);
			DestroyInstance_1 = Marshal.GetDelegateForFunctionPointer<DestroyInstanceDelegate_1>(destroyInstance);
		}
		var enumeratePhysicalDevices = (nint)GetInstanceProcedureAddress(instance, "vkEnumeratePhysicalDevices");
		if (enumeratePhysicalDevices != nint.Zero)
		{
			EnumeratePhysicalDevices_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_0>(enumeratePhysicalDevices);
			EnumeratePhysicalDevices_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDevicesDelegate_1>(enumeratePhysicalDevices);
		}
		var getPhysicalDeviceFeatures = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFeatures");
		if (getPhysicalDeviceFeatures != nint.Zero)
		{
			GetPhysicalDeviceFeatures_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeaturesDelegate_0>(getPhysicalDeviceFeatures);
		}
		var getPhysicalDeviceFormatProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFormatProperties");
		if (getPhysicalDeviceFormatProperties != nint.Zero)
		{
			GetPhysicalDeviceFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatPropertiesDelegate_0>(getPhysicalDeviceFormatProperties);
		}
		var getPhysicalDeviceImageFormatProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceImageFormatProperties");
		if (getPhysicalDeviceImageFormatProperties != nint.Zero)
		{
			GetPhysicalDeviceImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatPropertiesDelegate_0>(getPhysicalDeviceImageFormatProperties);
		}
		var getPhysicalDeviceProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceProperties");
		if (getPhysicalDeviceProperties != nint.Zero)
		{
			GetPhysicalDeviceProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePropertiesDelegate_0>(getPhysicalDeviceProperties);
		}
		var getPhysicalDeviceQueueFamilyProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties");
		if (getPhysicalDeviceQueueFamilyProperties != nint.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPropertiesDelegate_0>(getPhysicalDeviceQueueFamilyProperties);
			GetPhysicalDeviceQueueFamilyProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPropertiesDelegate_1>(getPhysicalDeviceQueueFamilyProperties);
		}
		var getPhysicalDeviceMemoryProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceMemoryProperties");
		if (getPhysicalDeviceMemoryProperties != nint.Zero)
		{
			GetPhysicalDeviceMemoryProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryPropertiesDelegate_0>(getPhysicalDeviceMemoryProperties);
		}
		var getDeviceProcedureAddress = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceProcAddr");
		if (getDeviceProcedureAddress != nint.Zero)
		{
			GetDeviceProcedureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceProcedureAddressDelegate_0>(getDeviceProcedureAddress);
		}
		var createDevice = (nint)GetInstanceProcedureAddress(instance, "vkCreateDevice");
		if (createDevice != nint.Zero)
		{
			CreateDevice_0 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_0>(createDevice);
			CreateDevice_1 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_1>(createDevice);
			CreateDevice_2 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_2>(createDevice);
			CreateDevice_3 = Marshal.GetDelegateForFunctionPointer<CreateDeviceDelegate_3>(createDevice);
		}
		var destroyDevice = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDevice");
		if (destroyDevice != nint.Zero)
		{
			DestroyDevice_0 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_0>(destroyDevice);
			DestroyDevice_1 = Marshal.GetDelegateForFunctionPointer<DestroyDeviceDelegate_1>(destroyDevice);
		}
		var enumerateDeviceExtensionProperties = (nint)GetInstanceProcedureAddress(instance, "vkEnumerateDeviceExtensionProperties");
		if (enumerateDeviceExtensionProperties != nint.Zero)
		{
			EnumerateDeviceExtensionProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_0>(enumerateDeviceExtensionProperties);
			EnumerateDeviceExtensionProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceExtensionPropertiesDelegate_1>(enumerateDeviceExtensionProperties);
		}
		var enumerateDeviceLayerProperties = (nint)GetInstanceProcedureAddress(instance, "vkEnumerateDeviceLayerProperties");
		if (enumerateDeviceLayerProperties != nint.Zero)
		{
			EnumerateDeviceLayerProperties_0 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_0>(enumerateDeviceLayerProperties);
			EnumerateDeviceLayerProperties_1 = Marshal.GetDelegateForFunctionPointer<EnumerateDeviceLayerPropertiesDelegate_1>(enumerateDeviceLayerProperties);
		}
		var getDeviceQueue = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceQueue");
		if (getDeviceQueue != nint.Zero)
		{
			GetDeviceQueue_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueueDelegate_0>(getDeviceQueue);
		}
		var queueSubmit = (nint)GetInstanceProcedureAddress(instance, "vkQueueSubmit");
		if (queueSubmit != nint.Zero)
		{
			QueueSubmit_0 = Marshal.GetDelegateForFunctionPointer<QueueSubmitDelegate_0>(queueSubmit);
		}
		var queueWaitIdle = (nint)GetInstanceProcedureAddress(instance, "vkQueueWaitIdle");
		if (queueWaitIdle != nint.Zero)
		{
			QueueWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<QueueWaitIdleDelegate_0>(queueWaitIdle);
		}
		var deviceWaitIdle = (nint)GetInstanceProcedureAddress(instance, "vkDeviceWaitIdle");
		if (deviceWaitIdle != nint.Zero)
		{
			DeviceWaitIdle_0 = Marshal.GetDelegateForFunctionPointer<DeviceWaitIdleDelegate_0>(deviceWaitIdle);
		}
		var allocateMemory = (nint)GetInstanceProcedureAddress(instance, "vkAllocateMemory");
		if (allocateMemory != nint.Zero)
		{
			AllocateMemory_0 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_0>(allocateMemory);
			AllocateMemory_1 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_1>(allocateMemory);
			AllocateMemory_2 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_2>(allocateMemory);
			AllocateMemory_3 = Marshal.GetDelegateForFunctionPointer<AllocateMemoryDelegate_3>(allocateMemory);
		}
		var freeMemory = (nint)GetInstanceProcedureAddress(instance, "vkFreeMemory");
		if (freeMemory != nint.Zero)
		{
			FreeMemory_0 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_0>(freeMemory);
			FreeMemory_1 = Marshal.GetDelegateForFunctionPointer<FreeMemoryDelegate_1>(freeMemory);
		}
		var mapMemory = (nint)GetInstanceProcedureAddress(instance, "vkMapMemory");
		if (mapMemory != nint.Zero)
		{
			MapMemory_0 = Marshal.GetDelegateForFunctionPointer<MapMemoryDelegate_0>(mapMemory);
		}
		var unmapMemory = (nint)GetInstanceProcedureAddress(instance, "vkUnmapMemory");
		if (unmapMemory != nint.Zero)
		{
			UnmapMemory_0 = Marshal.GetDelegateForFunctionPointer<UnmapMemoryDelegate_0>(unmapMemory);
		}
		var flushMappedMemoryRanges = (nint)GetInstanceProcedureAddress(instance, "vkFlushMappedMemoryRanges");
		if (flushMappedMemoryRanges != nint.Zero)
		{
			FlushMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<FlushMappedMemoryRangesDelegate_0>(flushMappedMemoryRanges);
		}
		var invalidateMappedMemoryRanges = (nint)GetInstanceProcedureAddress(instance, "vkInvalidateMappedMemoryRanges");
		if (invalidateMappedMemoryRanges != nint.Zero)
		{
			InvalidateMappedMemoryRanges_0 = Marshal.GetDelegateForFunctionPointer<InvalidateMappedMemoryRangesDelegate_0>(invalidateMappedMemoryRanges);
		}
		var getDeviceMemoryCommitment = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceMemoryCommitment");
		if (getDeviceMemoryCommitment != nint.Zero)
		{
			GetDeviceMemoryCommitment_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryCommitmentDelegate_0>(getDeviceMemoryCommitment);
		}
		var bindBufferMemory = (nint)GetInstanceProcedureAddress(instance, "vkBindBufferMemory");
		if (bindBufferMemory != nint.Zero)
		{
			BindBufferMemory_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemoryDelegate_0>(bindBufferMemory);
		}
		var bindImageMemory = (nint)GetInstanceProcedureAddress(instance, "vkBindImageMemory");
		if (bindImageMemory != nint.Zero)
		{
			BindImageMemory_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemoryDelegate_0>(bindImageMemory);
		}
		var getBufferMemoryRequirements = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferMemoryRequirements");
		if (getBufferMemoryRequirements != nint.Zero)
		{
			GetBufferMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirementsDelegate_0>(getBufferMemoryRequirements);
		}
		var getImageMemoryRequirements = (nint)GetInstanceProcedureAddress(instance, "vkGetImageMemoryRequirements");
		if (getImageMemoryRequirements != nint.Zero)
		{
			GetImageMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirementsDelegate_0>(getImageMemoryRequirements);
		}
		var getImageSparseMemoryRequirements = (nint)GetInstanceProcedureAddress(instance, "vkGetImageSparseMemoryRequirements");
		if (getImageSparseMemoryRequirements != nint.Zero)
		{
			GetImageSparseMemoryRequirements_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirementsDelegate_0>(getImageSparseMemoryRequirements);
			GetImageSparseMemoryRequirements_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirementsDelegate_1>(getImageSparseMemoryRequirements);
		}
		var getPhysicalDeviceSparseImageFormatProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties");
		if (getPhysicalDeviceSparseImageFormatProperties != nint.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_0>(getPhysicalDeviceSparseImageFormatProperties);
			GetPhysicalDeviceSparseImageFormatProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatPropertiesDelegate_1>(getPhysicalDeviceSparseImageFormatProperties);
		}
		var queueBindSparse = (nint)GetInstanceProcedureAddress(instance, "vkQueueBindSparse");
		if (queueBindSparse != nint.Zero)
		{
			QueueBindSparse_0 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_0>(queueBindSparse);
			QueueBindSparse_1 = Marshal.GetDelegateForFunctionPointer<QueueBindSparseDelegate_1>(queueBindSparse);
		}
		var createFence = (nint)GetInstanceProcedureAddress(instance, "vkCreateFence");
		if (createFence != nint.Zero)
		{
			CreateFence_0 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_0>(createFence);
			CreateFence_1 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_1>(createFence);
			CreateFence_2 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_2>(createFence);
			CreateFence_3 = Marshal.GetDelegateForFunctionPointer<CreateFenceDelegate_3>(createFence);
		}
		var destroyFence = (nint)GetInstanceProcedureAddress(instance, "vkDestroyFence");
		if (destroyFence != nint.Zero)
		{
			DestroyFence_0 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_0>(destroyFence);
			DestroyFence_1 = Marshal.GetDelegateForFunctionPointer<DestroyFenceDelegate_1>(destroyFence);
		}
		var resetFences = (nint)GetInstanceProcedureAddress(instance, "vkResetFences");
		if (resetFences != nint.Zero)
		{
			ResetFences_0 = Marshal.GetDelegateForFunctionPointer<ResetFencesDelegate_0>(resetFences);
		}
		var getFenceStatus = (nint)GetInstanceProcedureAddress(instance, "vkGetFenceStatus");
		if (getFenceStatus != nint.Zero)
		{
			GetFenceStatus_0 = Marshal.GetDelegateForFunctionPointer<GetFenceStatusDelegate_0>(getFenceStatus);
		}
		var waitForFences = (nint)GetInstanceProcedureAddress(instance, "vkWaitForFences");
		if (waitForFences != nint.Zero)
		{
			WaitForFences_0 = Marshal.GetDelegateForFunctionPointer<WaitForFencesDelegate_0>(waitForFences);
		}
		var createSemaphore = (nint)GetInstanceProcedureAddress(instance, "vkCreateSemaphore");
		if (createSemaphore != nint.Zero)
		{
			CreateSemaphore_0 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_0>(createSemaphore);
			CreateSemaphore_1 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_1>(createSemaphore);
			CreateSemaphore_2 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_2>(createSemaphore);
			CreateSemaphore_3 = Marshal.GetDelegateForFunctionPointer<CreateSemaphoreDelegate_3>(createSemaphore);
		}
		var destroySemaphore = (nint)GetInstanceProcedureAddress(instance, "vkDestroySemaphore");
		if (destroySemaphore != nint.Zero)
		{
			DestroySemaphore_0 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_0>(destroySemaphore);
			DestroySemaphore_1 = Marshal.GetDelegateForFunctionPointer<DestroySemaphoreDelegate_1>(destroySemaphore);
		}
		var createEvent = (nint)GetInstanceProcedureAddress(instance, "vkCreateEvent");
		if (createEvent != nint.Zero)
		{
			CreateEvent_0 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_0>(createEvent);
			CreateEvent_1 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_1>(createEvent);
			CreateEvent_2 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_2>(createEvent);
			CreateEvent_3 = Marshal.GetDelegateForFunctionPointer<CreateEventDelegate_3>(createEvent);
		}
		var destroyEvent = (nint)GetInstanceProcedureAddress(instance, "vkDestroyEvent");
		if (destroyEvent != nint.Zero)
		{
			DestroyEvent_0 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_0>(destroyEvent);
			DestroyEvent_1 = Marshal.GetDelegateForFunctionPointer<DestroyEventDelegate_1>(destroyEvent);
		}
		var getEventStatus = (nint)GetInstanceProcedureAddress(instance, "vkGetEventStatus");
		if (getEventStatus != nint.Zero)
		{
			GetEventStatus_0 = Marshal.GetDelegateForFunctionPointer<GetEventStatusDelegate_0>(getEventStatus);
		}
		var setEvent = (nint)GetInstanceProcedureAddress(instance, "vkSetEvent");
		if (setEvent != nint.Zero)
		{
			SetEvent_0 = Marshal.GetDelegateForFunctionPointer<SetEventDelegate_0>(setEvent);
		}
		var resetEvent = (nint)GetInstanceProcedureAddress(instance, "vkResetEvent");
		if (resetEvent != nint.Zero)
		{
			ResetEvent_0 = Marshal.GetDelegateForFunctionPointer<ResetEventDelegate_0>(resetEvent);
		}
		var createQueryPool = (nint)GetInstanceProcedureAddress(instance, "vkCreateQueryPool");
		if (createQueryPool != nint.Zero)
		{
			CreateQueryPool_0 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_0>(createQueryPool);
			CreateQueryPool_1 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_1>(createQueryPool);
			CreateQueryPool_2 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_2>(createQueryPool);
			CreateQueryPool_3 = Marshal.GetDelegateForFunctionPointer<CreateQueryPoolDelegate_3>(createQueryPool);
		}
		var destroyQueryPool = (nint)GetInstanceProcedureAddress(instance, "vkDestroyQueryPool");
		if (destroyQueryPool != nint.Zero)
		{
			DestroyQueryPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_0>(destroyQueryPool);
			DestroyQueryPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyQueryPoolDelegate_1>(destroyQueryPool);
		}
		var getQueryPoolResults = (nint)GetInstanceProcedureAddress(instance, "vkGetQueryPoolResults");
		if (getQueryPoolResults != nint.Zero)
		{
			GetQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<GetQueryPoolResultsDelegate_0>(getQueryPoolResults);
		}
		var createBuffer = (nint)GetInstanceProcedureAddress(instance, "vkCreateBuffer");
		if (createBuffer != nint.Zero)
		{
			CreateBuffer_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_0>(createBuffer);
			CreateBuffer_1 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_1>(createBuffer);
			CreateBuffer_2 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_2>(createBuffer);
			CreateBuffer_3 = Marshal.GetDelegateForFunctionPointer<CreateBufferDelegate_3>(createBuffer);
		}
		var destroyBuffer = (nint)GetInstanceProcedureAddress(instance, "vkDestroyBuffer");
		if (destroyBuffer != nint.Zero)
		{
			DestroyBuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_0>(destroyBuffer);
			DestroyBuffer_1 = Marshal.GetDelegateForFunctionPointer<DestroyBufferDelegate_1>(destroyBuffer);
		}
		var createBufferView = (nint)GetInstanceProcedureAddress(instance, "vkCreateBufferView");
		if (createBufferView != nint.Zero)
		{
			CreateBufferView_0 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_0>(createBufferView);
			CreateBufferView_1 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_1>(createBufferView);
			CreateBufferView_2 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_2>(createBufferView);
			CreateBufferView_3 = Marshal.GetDelegateForFunctionPointer<CreateBufferViewDelegate_3>(createBufferView);
		}
		var destroyBufferView = (nint)GetInstanceProcedureAddress(instance, "vkDestroyBufferView");
		if (destroyBufferView != nint.Zero)
		{
			DestroyBufferView_0 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_0>(destroyBufferView);
			DestroyBufferView_1 = Marshal.GetDelegateForFunctionPointer<DestroyBufferViewDelegate_1>(destroyBufferView);
		}
		var createImage = (nint)GetInstanceProcedureAddress(instance, "vkCreateImage");
		if (createImage != nint.Zero)
		{
			CreateImage_0 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_0>(createImage);
			CreateImage_1 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_1>(createImage);
			CreateImage_2 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_2>(createImage);
			CreateImage_3 = Marshal.GetDelegateForFunctionPointer<CreateImageDelegate_3>(createImage);
		}
		var destroyImage = (nint)GetInstanceProcedureAddress(instance, "vkDestroyImage");
		if (destroyImage != nint.Zero)
		{
			DestroyImage_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_0>(destroyImage);
			DestroyImage_1 = Marshal.GetDelegateForFunctionPointer<DestroyImageDelegate_1>(destroyImage);
		}
		var getImageSubresourceLayout = (nint)GetInstanceProcedureAddress(instance, "vkGetImageSubresourceLayout");
		if (getImageSubresourceLayout != nint.Zero)
		{
			GetImageSubresourceLayout_0 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_0>(getImageSubresourceLayout);
			GetImageSubresourceLayout_1 = Marshal.GetDelegateForFunctionPointer<GetImageSubresourceLayoutDelegate_1>(getImageSubresourceLayout);
		}
		var createImageView = (nint)GetInstanceProcedureAddress(instance, "vkCreateImageView");
		if (createImageView != nint.Zero)
		{
			CreateImageView_0 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_0>(createImageView);
			CreateImageView_1 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_1>(createImageView);
			CreateImageView_2 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_2>(createImageView);
			CreateImageView_3 = Marshal.GetDelegateForFunctionPointer<CreateImageViewDelegate_3>(createImageView);
		}
		var destroyImageView = (nint)GetInstanceProcedureAddress(instance, "vkDestroyImageView");
		if (destroyImageView != nint.Zero)
		{
			DestroyImageView_0 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_0>(destroyImageView);
			DestroyImageView_1 = Marshal.GetDelegateForFunctionPointer<DestroyImageViewDelegate_1>(destroyImageView);
		}
		var createShaderModule = (nint)GetInstanceProcedureAddress(instance, "vkCreateShaderModule");
		if (createShaderModule != nint.Zero)
		{
			CreateShaderModule_0 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_0>(createShaderModule);
			CreateShaderModule_1 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_1>(createShaderModule);
			CreateShaderModule_2 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_2>(createShaderModule);
			CreateShaderModule_3 = Marshal.GetDelegateForFunctionPointer<CreateShaderModuleDelegate_3>(createShaderModule);
		}
		var destroyShaderModule = (nint)GetInstanceProcedureAddress(instance, "vkDestroyShaderModule");
		if (destroyShaderModule != nint.Zero)
		{
			DestroyShaderModule_0 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_0>(destroyShaderModule);
			DestroyShaderModule_1 = Marshal.GetDelegateForFunctionPointer<DestroyShaderModuleDelegate_1>(destroyShaderModule);
		}
		var createPipelineCache = (nint)GetInstanceProcedureAddress(instance, "vkCreatePipelineCache");
		if (createPipelineCache != nint.Zero)
		{
			CreatePipelineCache_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_0>(createPipelineCache);
			CreatePipelineCache_1 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_1>(createPipelineCache);
			CreatePipelineCache_2 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_2>(createPipelineCache);
			CreatePipelineCache_3 = Marshal.GetDelegateForFunctionPointer<CreatePipelineCacheDelegate_3>(createPipelineCache);
		}
		var destroyPipelineCache = (nint)GetInstanceProcedureAddress(instance, "vkDestroyPipelineCache");
		if (destroyPipelineCache != nint.Zero)
		{
			DestroyPipelineCache_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_0>(destroyPipelineCache);
			DestroyPipelineCache_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineCacheDelegate_1>(destroyPipelineCache);
		}
		var getPipelineCacheData = (nint)GetInstanceProcedureAddress(instance, "vkGetPipelineCacheData");
		if (getPipelineCacheData != nint.Zero)
		{
			GetPipelineCacheData_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_0>(getPipelineCacheData);
			GetPipelineCacheData_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineCacheDataDelegate_1>(getPipelineCacheData);
		}
		var mergePipelineCaches = (nint)GetInstanceProcedureAddress(instance, "vkMergePipelineCaches");
		if (mergePipelineCaches != nint.Zero)
		{
			MergePipelineCaches_0 = Marshal.GetDelegateForFunctionPointer<MergePipelineCachesDelegate_0>(mergePipelineCaches);
		}
		var createGraphicsPipelines = (nint)GetInstanceProcedureAddress(instance, "vkCreateGraphicsPipelines");
		if (createGraphicsPipelines != nint.Zero)
		{
			CreateGraphicsPipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateGraphicsPipelinesDelegate_0>(createGraphicsPipelines);
			CreateGraphicsPipelines_1 = Marshal.GetDelegateForFunctionPointer<CreateGraphicsPipelinesDelegate_1>(createGraphicsPipelines);
		}
		var createComputePipelines = (nint)GetInstanceProcedureAddress(instance, "vkCreateComputePipelines");
		if (createComputePipelines != nint.Zero)
		{
			CreateComputePipelines_0 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_0>(createComputePipelines);
			CreateComputePipelines_1 = Marshal.GetDelegateForFunctionPointer<CreateComputePipelinesDelegate_1>(createComputePipelines);
		}
		var destroyPipeline = (nint)GetInstanceProcedureAddress(instance, "vkDestroyPipeline");
		if (destroyPipeline != nint.Zero)
		{
			DestroyPipeline_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_0>(destroyPipeline);
			DestroyPipeline_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineDelegate_1>(destroyPipeline);
		}
		var createPipelineLayout = (nint)GetInstanceProcedureAddress(instance, "vkCreatePipelineLayout");
		if (createPipelineLayout != nint.Zero)
		{
			CreatePipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_0>(createPipelineLayout);
			CreatePipelineLayout_1 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_1>(createPipelineLayout);
			CreatePipelineLayout_2 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_2>(createPipelineLayout);
			CreatePipelineLayout_3 = Marshal.GetDelegateForFunctionPointer<CreatePipelineLayoutDelegate_3>(createPipelineLayout);
		}
		var destroyPipelineLayout = (nint)GetInstanceProcedureAddress(instance, "vkDestroyPipelineLayout");
		if (destroyPipelineLayout != nint.Zero)
		{
			DestroyPipelineLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_0>(destroyPipelineLayout);
			DestroyPipelineLayout_1 = Marshal.GetDelegateForFunctionPointer<DestroyPipelineLayoutDelegate_1>(destroyPipelineLayout);
		}
		var createSampler = (nint)GetInstanceProcedureAddress(instance, "vkCreateSampler");
		if (createSampler != nint.Zero)
		{
			CreateSampler_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_0>(createSampler);
			CreateSampler_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_1>(createSampler);
			CreateSampler_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_2>(createSampler);
			CreateSampler_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerDelegate_3>(createSampler);
		}
		var destroySampler = (nint)GetInstanceProcedureAddress(instance, "vkDestroySampler");
		if (destroySampler != nint.Zero)
		{
			DestroySampler_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_0>(destroySampler);
			DestroySampler_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerDelegate_1>(destroySampler);
		}
		var createDescriptorSetLayout = (nint)GetInstanceProcedureAddress(instance, "vkCreateDescriptorSetLayout");
		if (createDescriptorSetLayout != nint.Zero)
		{
			CreateDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_0>(createDescriptorSetLayout);
			CreateDescriptorSetLayout_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_1>(createDescriptorSetLayout);
			CreateDescriptorSetLayout_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_2>(createDescriptorSetLayout);
			CreateDescriptorSetLayout_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorSetLayoutDelegate_3>(createDescriptorSetLayout);
		}
		var destroyDescriptorSetLayout = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDescriptorSetLayout");
		if (destroyDescriptorSetLayout != nint.Zero)
		{
			DestroyDescriptorSetLayout_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_0>(destroyDescriptorSetLayout);
			DestroyDescriptorSetLayout_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorSetLayoutDelegate_1>(destroyDescriptorSetLayout);
		}
		var createDescriptorPool = (nint)GetInstanceProcedureAddress(instance, "vkCreateDescriptorPool");
		if (createDescriptorPool != nint.Zero)
		{
			CreateDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_0>(createDescriptorPool);
			CreateDescriptorPool_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_1>(createDescriptorPool);
			CreateDescriptorPool_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_2>(createDescriptorPool);
			CreateDescriptorPool_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorPoolDelegate_3>(createDescriptorPool);
		}
		var destroyDescriptorPool = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDescriptorPool");
		if (destroyDescriptorPool != nint.Zero)
		{
			DestroyDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_0>(destroyDescriptorPool);
			DestroyDescriptorPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorPoolDelegate_1>(destroyDescriptorPool);
		}
		var resetDescriptorPool = (nint)GetInstanceProcedureAddress(instance, "vkResetDescriptorPool");
		if (resetDescriptorPool != nint.Zero)
		{
			ResetDescriptorPool_0 = Marshal.GetDelegateForFunctionPointer<ResetDescriptorPoolDelegate_0>(resetDescriptorPool);
		}
		var allocateDescriptorSets = (nint)GetInstanceProcedureAddress(instance, "vkAllocateDescriptorSets");
		if (allocateDescriptorSets != nint.Zero)
		{
			AllocateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<AllocateDescriptorSetsDelegate_0>(allocateDescriptorSets);
			AllocateDescriptorSets_1 = Marshal.GetDelegateForFunctionPointer<AllocateDescriptorSetsDelegate_1>(allocateDescriptorSets);
		}
		var freeDescriptorSets = (nint)GetInstanceProcedureAddress(instance, "vkFreeDescriptorSets");
		if (freeDescriptorSets != nint.Zero)
		{
			FreeDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<FreeDescriptorSetsDelegate_0>(freeDescriptorSets);
		}
		var updateDescriptorSets = (nint)GetInstanceProcedureAddress(instance, "vkUpdateDescriptorSets");
		if (updateDescriptorSets != nint.Zero)
		{
			UpdateDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetsDelegate_0>(updateDescriptorSets);
		}
		var createFramebuffer = (nint)GetInstanceProcedureAddress(instance, "vkCreateFramebuffer");
		if (createFramebuffer != nint.Zero)
		{
			CreateFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_0>(createFramebuffer);
			CreateFramebuffer_1 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_1>(createFramebuffer);
			CreateFramebuffer_2 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_2>(createFramebuffer);
			CreateFramebuffer_3 = Marshal.GetDelegateForFunctionPointer<CreateFramebufferDelegate_3>(createFramebuffer);
		}
		var destroyFramebuffer = (nint)GetInstanceProcedureAddress(instance, "vkDestroyFramebuffer");
		if (destroyFramebuffer != nint.Zero)
		{
			DestroyFramebuffer_0 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_0>(destroyFramebuffer);
			DestroyFramebuffer_1 = Marshal.GetDelegateForFunctionPointer<DestroyFramebufferDelegate_1>(destroyFramebuffer);
		}
		var createRenderPass = (nint)GetInstanceProcedureAddress(instance, "vkCreateRenderPass");
		if (createRenderPass != nint.Zero)
		{
			CreateRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_0>(createRenderPass);
			CreateRenderPass_1 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_1>(createRenderPass);
			CreateRenderPass_2 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_2>(createRenderPass);
			CreateRenderPass_3 = Marshal.GetDelegateForFunctionPointer<CreateRenderPassDelegate_3>(createRenderPass);
		}
		var destroyRenderPass = (nint)GetInstanceProcedureAddress(instance, "vkDestroyRenderPass");
		if (destroyRenderPass != nint.Zero)
		{
			DestroyRenderPass_0 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_0>(destroyRenderPass);
			DestroyRenderPass_1 = Marshal.GetDelegateForFunctionPointer<DestroyRenderPassDelegate_1>(destroyRenderPass);
		}
		var getRenderAreaGranularity = (nint)GetInstanceProcedureAddress(instance, "vkGetRenderAreaGranularity");
		if (getRenderAreaGranularity != nint.Zero)
		{
			GetRenderAreaGranularity_0 = Marshal.GetDelegateForFunctionPointer<GetRenderAreaGranularityDelegate_0>(getRenderAreaGranularity);
		}
		var createCommandPool = (nint)GetInstanceProcedureAddress(instance, "vkCreateCommandPool");
		if (createCommandPool != nint.Zero)
		{
			CreateCommandPool_0 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_0>(createCommandPool);
			CreateCommandPool_1 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_1>(createCommandPool);
			CreateCommandPool_2 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_2>(createCommandPool);
			CreateCommandPool_3 = Marshal.GetDelegateForFunctionPointer<CreateCommandPoolDelegate_3>(createCommandPool);
		}
		var destroyCommandPool = (nint)GetInstanceProcedureAddress(instance, "vkDestroyCommandPool");
		if (destroyCommandPool != nint.Zero)
		{
			DestroyCommandPool_0 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_0>(destroyCommandPool);
			DestroyCommandPool_1 = Marshal.GetDelegateForFunctionPointer<DestroyCommandPoolDelegate_1>(destroyCommandPool);
		}
		var resetCommandPool = (nint)GetInstanceProcedureAddress(instance, "vkResetCommandPool");
		if (resetCommandPool != nint.Zero)
		{
			ResetCommandPool_0 = Marshal.GetDelegateForFunctionPointer<ResetCommandPoolDelegate_0>(resetCommandPool);
		}
		var allocateCommandBuffers = (nint)GetInstanceProcedureAddress(instance, "vkAllocateCommandBuffers");
		if (allocateCommandBuffers != nint.Zero)
		{
			AllocateCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<AllocateCommandBuffersDelegate_0>(allocateCommandBuffers);
			AllocateCommandBuffers_1 = Marshal.GetDelegateForFunctionPointer<AllocateCommandBuffersDelegate_1>(allocateCommandBuffers);
		}
		var freeCommandBuffers = (nint)GetInstanceProcedureAddress(instance, "vkFreeCommandBuffers");
		if (freeCommandBuffers != nint.Zero)
		{
			FreeCommandBuffers_0 = Marshal.GetDelegateForFunctionPointer<FreeCommandBuffersDelegate_0>(freeCommandBuffers);
		}
		var beginCommandBuffer = (nint)GetInstanceProcedureAddress(instance, "vkBeginCommandBuffer");
		if (beginCommandBuffer != nint.Zero)
		{
			BeginCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<BeginCommandBufferDelegate_0>(beginCommandBuffer);
			BeginCommandBuffer_1 = Marshal.GetDelegateForFunctionPointer<BeginCommandBufferDelegate_1>(beginCommandBuffer);
		}
		var endCommandBuffer = (nint)GetInstanceProcedureAddress(instance, "vkEndCommandBuffer");
		if (endCommandBuffer != nint.Zero)
		{
			EndCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<EndCommandBufferDelegate_0>(endCommandBuffer);
		}
		var resetCommandBuffer = (nint)GetInstanceProcedureAddress(instance, "vkResetCommandBuffer");
		if (resetCommandBuffer != nint.Zero)
		{
			ResetCommandBuffer_0 = Marshal.GetDelegateForFunctionPointer<ResetCommandBufferDelegate_0>(resetCommandBuffer);
		}
		var commandBindPipeline = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindPipeline");
		if (commandBindPipeline != nint.Zero)
		{
			CommandBindPipeline_0 = Marshal.GetDelegateForFunctionPointer<CommandBindPipelineDelegate_0>(commandBindPipeline);
		}
		var commandSetViewport = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetViewport");
		if (commandSetViewport != nint.Zero)
		{
			CommandSetViewport_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportDelegate_0>(commandSetViewport);
		}
		var commandSetScissor = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetScissor");
		if (commandSetScissor != nint.Zero)
		{
			CommandSetScissor_0 = Marshal.GetDelegateForFunctionPointer<CommandSetScissorDelegate_0>(commandSetScissor);
		}
		var commandSetLineWidth = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetLineWidth");
		if (commandSetLineWidth != nint.Zero)
		{
			CommandSetLineWidth_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLineWidthDelegate_0>(commandSetLineWidth);
		}
		var commandSetDepthBias = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthBias");
		if (commandSetDepthBias != nint.Zero)
		{
			CommandSetDepthBias_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBiasDelegate_0>(commandSetDepthBias);
		}
		var commandSetBlendConstants = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetBlendConstants");
		if (commandSetBlendConstants != nint.Zero)
		{
			CommandSetBlendConstants_0 = Marshal.GetDelegateForFunctionPointer<CommandSetBlendConstantsDelegate_0>(commandSetBlendConstants);
		}
		var commandSetDepthBounds = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthBounds");
		if (commandSetDepthBounds != nint.Zero)
		{
			CommandSetDepthBounds_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBoundsDelegate_0>(commandSetDepthBounds);
		}
		var commandSetStencilCompareMask = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetStencilCompareMask");
		if (commandSetStencilCompareMask != nint.Zero)
		{
			CommandSetStencilCompareMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilCompareMaskDelegate_0>(commandSetStencilCompareMask);
		}
		var commandSetStencilWriteMask = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetStencilWriteMask");
		if (commandSetStencilWriteMask != nint.Zero)
		{
			CommandSetStencilWriteMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilWriteMaskDelegate_0>(commandSetStencilWriteMask);
		}
		var commandSetStencilReference = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetStencilReference");
		if (commandSetStencilReference != nint.Zero)
		{
			CommandSetStencilReference_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilReferenceDelegate_0>(commandSetStencilReference);
		}
		var commandBindDescriptorSets = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindDescriptorSets");
		if (commandBindDescriptorSets != nint.Zero)
		{
			CommandBindDescriptorSets_0 = Marshal.GetDelegateForFunctionPointer<CommandBindDescriptorSetsDelegate_0>(commandBindDescriptorSets);
		}
		var commandBindIndexBuffer = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindIndexBuffer");
		if (commandBindIndexBuffer != nint.Zero)
		{
			CommandBindIndexBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandBindIndexBufferDelegate_0>(commandBindIndexBuffer);
		}
		var commandBindVertexBuffers = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindVertexBuffers");
		if (commandBindVertexBuffers != nint.Zero)
		{
			CommandBindVertexBuffers_0 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_0>(commandBindVertexBuffers);
			CommandBindVertexBuffers_1 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_1>(commandBindVertexBuffers);
			CommandBindVertexBuffers_2 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_2>(commandBindVertexBuffers);
			CommandBindVertexBuffers_3 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffersDelegate_3>(commandBindVertexBuffers);
		}
		var commandDraw = (nint)GetInstanceProcedureAddress(instance, "vkCmdDraw");
		if (commandDraw != nint.Zero)
		{
			CommandDraw_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawDelegate_0>(commandDraw);
		}
		var commandDrawIndexed = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndexed");
		if (commandDrawIndexed != nint.Zero)
		{
			CommandDrawIndexed_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedDelegate_0>(commandDrawIndexed);
		}
		var commandDrawIndirect = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndirect");
		if (commandDrawIndirect != nint.Zero)
		{
			CommandDrawIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectDelegate_0>(commandDrawIndirect);
		}
		var commandDrawIndexedIndirect = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndexedIndirect");
		if (commandDrawIndexedIndirect != nint.Zero)
		{
			CommandDrawIndexedIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectDelegate_0>(commandDrawIndexedIndirect);
		}
		var commandDispatch = (nint)GetInstanceProcedureAddress(instance, "vkCmdDispatch");
		if (commandDispatch != nint.Zero)
		{
			CommandDispatch_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchDelegate_0>(commandDispatch);
		}
		var commandDispatchIndirect = (nint)GetInstanceProcedureAddress(instance, "vkCmdDispatchIndirect");
		if (commandDispatchIndirect != nint.Zero)
		{
			CommandDispatchIndirect_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchIndirectDelegate_0>(commandDispatchIndirect);
		}
		var commandCopyBuffer = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyBuffer");
		if (commandCopyBuffer != nint.Zero)
		{
			CommandCopyBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferDelegate_0>(commandCopyBuffer);
		}
		var commandCopyImage = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyImage");
		if (commandCopyImage != nint.Zero)
		{
			CommandCopyImage_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageDelegate_0>(commandCopyImage);
		}
		var commandBlitImage = (nint)GetInstanceProcedureAddress(instance, "vkCmdBlitImage");
		if (commandBlitImage != nint.Zero)
		{
			CommandBlitImage_0 = Marshal.GetDelegateForFunctionPointer<CommandBlitImageDelegate_0>(commandBlitImage);
		}
		var commandCopyBufferToImage = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyBufferToImage");
		if (commandCopyBufferToImage != nint.Zero)
		{
			CommandCopyBufferToImage_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImageDelegate_0>(commandCopyBufferToImage);
		}
		var commandCopyImageToBuffer = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyImageToBuffer");
		if (commandCopyImageToBuffer != nint.Zero)
		{
			CommandCopyImageToBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBufferDelegate_0>(commandCopyImageToBuffer);
		}
		var commandUpdateBuffer = (nint)GetInstanceProcedureAddress(instance, "vkCmdUpdateBuffer");
		if (commandUpdateBuffer != nint.Zero)
		{
			CommandUpdateBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandUpdateBufferDelegate_0>(commandUpdateBuffer);
		}
		var commandFillBuffer = (nint)GetInstanceProcedureAddress(instance, "vkCmdFillBuffer");
		if (commandFillBuffer != nint.Zero)
		{
			CommandFillBuffer_0 = Marshal.GetDelegateForFunctionPointer<CommandFillBufferDelegate_0>(commandFillBuffer);
		}
		var commandClearColorImage = (nint)GetInstanceProcedureAddress(instance, "vkCmdClearColorImage");
		if (commandClearColorImage != nint.Zero)
		{
			CommandClearColorImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearColorImageDelegate_0>(commandClearColorImage);
			CommandClearColorImage_1 = Marshal.GetDelegateForFunctionPointer<CommandClearColorImageDelegate_1>(commandClearColorImage);
		}
		var commandClearDepthStencilImage = (nint)GetInstanceProcedureAddress(instance, "vkCmdClearDepthStencilImage");
		if (commandClearDepthStencilImage != nint.Zero)
		{
			CommandClearDepthStencilImage_0 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_0>(commandClearDepthStencilImage);
			CommandClearDepthStencilImage_1 = Marshal.GetDelegateForFunctionPointer<CommandClearDepthStencilImageDelegate_1>(commandClearDepthStencilImage);
		}
		var commandClearAttachments = (nint)GetInstanceProcedureAddress(instance, "vkCmdClearAttachments");
		if (commandClearAttachments != nint.Zero)
		{
			CommandClearAttachments_0 = Marshal.GetDelegateForFunctionPointer<CommandClearAttachmentsDelegate_0>(commandClearAttachments);
		}
		var commandResolveImage = (nint)GetInstanceProcedureAddress(instance, "vkCmdResolveImage");
		if (commandResolveImage != nint.Zero)
		{
			CommandResolveImage_0 = Marshal.GetDelegateForFunctionPointer<CommandResolveImageDelegate_0>(commandResolveImage);
		}
		var commandSetEvent = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetEvent");
		if (commandSetEvent != nint.Zero)
		{
			CommandSetEvent_0 = Marshal.GetDelegateForFunctionPointer<CommandSetEventDelegate_0>(commandSetEvent);
		}
		var commandResetEvent = (nint)GetInstanceProcedureAddress(instance, "vkCmdResetEvent");
		if (commandResetEvent != nint.Zero)
		{
			CommandResetEvent_0 = Marshal.GetDelegateForFunctionPointer<CommandResetEventDelegate_0>(commandResetEvent);
		}
		var commandWaitEvents = (nint)GetInstanceProcedureAddress(instance, "vkCmdWaitEvents");
		if (commandWaitEvents != nint.Zero)
		{
			CommandWaitEvents_0 = Marshal.GetDelegateForFunctionPointer<CommandWaitEventsDelegate_0>(commandWaitEvents);
		}
		var commandPipelineBarrier = (nint)GetInstanceProcedureAddress(instance, "vkCmdPipelineBarrier");
		if (commandPipelineBarrier != nint.Zero)
		{
			CommandPipelineBarrier_0 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrierDelegate_0>(commandPipelineBarrier);
		}
		var commandBeginQuery = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginQuery");
		if (commandBeginQuery != nint.Zero)
		{
			CommandBeginQuery_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginQueryDelegate_0>(commandBeginQuery);
		}
		var commandEndQuery = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndQuery");
		if (commandEndQuery != nint.Zero)
		{
			CommandEndQuery_0 = Marshal.GetDelegateForFunctionPointer<CommandEndQueryDelegate_0>(commandEndQuery);
		}
		var commandResetQueryPool = (nint)GetInstanceProcedureAddress(instance, "vkCmdResetQueryPool");
		if (commandResetQueryPool != nint.Zero)
		{
			CommandResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<CommandResetQueryPoolDelegate_0>(commandResetQueryPool);
		}
		var commandWriteTimestamp = (nint)GetInstanceProcedureAddress(instance, "vkCmdWriteTimestamp");
		if (commandWriteTimestamp != nint.Zero)
		{
			CommandWriteTimestamp_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteTimestampDelegate_0>(commandWriteTimestamp);
		}
		var commandCopyQueryPoolResults = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyQueryPoolResults");
		if (commandCopyQueryPoolResults != nint.Zero)
		{
			CommandCopyQueryPoolResults_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyQueryPoolResultsDelegate_0>(commandCopyQueryPoolResults);
		}
		var commandPushConstants = (nint)GetInstanceProcedureAddress(instance, "vkCmdPushConstants");
		if (commandPushConstants != nint.Zero)
		{
			CommandPushConstants_0 = Marshal.GetDelegateForFunctionPointer<CommandPushConstantsDelegate_0>(commandPushConstants);
		}
		var commandBeginRenderPass = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginRenderPass");
		if (commandBeginRenderPass != nint.Zero)
		{
			CommandBeginRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPassDelegate_0>(commandBeginRenderPass);
			CommandBeginRenderPass_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPassDelegate_1>(commandBeginRenderPass);
		}
		var commandNextSubpass = (nint)GetInstanceProcedureAddress(instance, "vkCmdNextSubpass");
		if (commandNextSubpass != nint.Zero)
		{
			CommandNextSubpass_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpassDelegate_0>(commandNextSubpass);
		}
		var commandEndRenderPass = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndRenderPass");
		if (commandEndRenderPass != nint.Zero)
		{
			CommandEndRenderPass_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPassDelegate_0>(commandEndRenderPass);
		}
		var commandExecuteCommands = (nint)GetInstanceProcedureAddress(instance, "vkCmdExecuteCommands");
		if (commandExecuteCommands != nint.Zero)
		{
			CommandExecuteCommands_0 = Marshal.GetDelegateForFunctionPointer<CommandExecuteCommandsDelegate_0>(commandExecuteCommands);
		}
		var enumerateInstanceVersion = (nint)GetInstanceProcedureAddress(instance, "vkEnumerateInstanceVersion");
		if (enumerateInstanceVersion != nint.Zero)
		{
			EnumerateInstanceVersion_0 = Marshal.GetDelegateForFunctionPointer<EnumerateInstanceVersionDelegate_0>(enumerateInstanceVersion);
		}
		var bindBufferMemory2 = (nint)GetInstanceProcedureAddress(instance, "vkBindBufferMemory2");
		if (bindBufferMemory2 != nint.Zero)
		{
			BindBufferMemory2_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemory2Delegate_0>(bindBufferMemory2);
		}
		var bindImageMemory2 = (nint)GetInstanceProcedureAddress(instance, "vkBindImageMemory2");
		if (bindImageMemory2 != nint.Zero)
		{
			BindImageMemory2_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemory2Delegate_0>(bindImageMemory2);
		}
		var getDeviceGroupPeerMemoryFeatures = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceGroupPeerMemoryFeatures");
		if (getDeviceGroupPeerMemoryFeatures != nint.Zero)
		{
			GetDeviceGroupPeerMemoryFeatures_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPeerMemoryFeaturesDelegate_0>(getDeviceGroupPeerMemoryFeatures);
		}
		var commandSetDeviceMask = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDeviceMask");
		if (commandSetDeviceMask != nint.Zero)
		{
			CommandSetDeviceMask_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDeviceMaskDelegate_0>(commandSetDeviceMask);
		}
		var commandDispatchBase = (nint)GetInstanceProcedureAddress(instance, "vkCmdDispatchBase");
		if (commandDispatchBase != nint.Zero)
		{
			CommandDispatchBase_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchBaseDelegate_0>(commandDispatchBase);
		}
		var enumeratePhysicalDeviceGroups = (nint)GetInstanceProcedureAddress(instance, "vkEnumeratePhysicalDeviceGroups");
		if (enumeratePhysicalDeviceGroups != nint.Zero)
		{
			EnumeratePhysicalDeviceGroups_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsDelegate_0>(enumeratePhysicalDeviceGroups);
			EnumeratePhysicalDeviceGroups_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsDelegate_1>(enumeratePhysicalDeviceGroups);
		}
		var getImageMemoryRequirements2 = (nint)GetInstanceProcedureAddress(instance, "vkGetImageMemoryRequirements2");
		if (getImageMemoryRequirements2 != nint.Zero)
		{
			GetImageMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2Delegate_0>(getImageMemoryRequirements2);
			GetImageMemoryRequirements2_1 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2Delegate_1>(getImageMemoryRequirements2);
		}
		var getBufferMemoryRequirements2 = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferMemoryRequirements2");
		if (getBufferMemoryRequirements2 != nint.Zero)
		{
			GetBufferMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2Delegate_0>(getBufferMemoryRequirements2);
			GetBufferMemoryRequirements2_1 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2Delegate_1>(getBufferMemoryRequirements2);
		}
		var getImageSparseMemoryRequirements2 = (nint)GetInstanceProcedureAddress(instance, "vkGetImageSparseMemoryRequirements2");
		if (getImageSparseMemoryRequirements2 != nint.Zero)
		{
			GetImageSparseMemoryRequirements2_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_0>(getImageSparseMemoryRequirements2);
			GetImageSparseMemoryRequirements2_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_1>(getImageSparseMemoryRequirements2);
			GetImageSparseMemoryRequirements2_2 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_2>(getImageSparseMemoryRequirements2);
			GetImageSparseMemoryRequirements2_3 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2Delegate_3>(getImageSparseMemoryRequirements2);
		}
		var getPhysicalDeviceFeatures2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFeatures2");
		if (getPhysicalDeviceFeatures2 != nint.Zero)
		{
			GetPhysicalDeviceFeatures2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeatures2Delegate_0>(getPhysicalDeviceFeatures2);
		}
		var getPhysicalDeviceProperties2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceProperties2");
		if (getPhysicalDeviceProperties2 != nint.Zero)
		{
			GetPhysicalDeviceProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceProperties2Delegate_0>(getPhysicalDeviceProperties2);
		}
		var getPhysicalDeviceFormatProperties2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFormatProperties2");
		if (getPhysicalDeviceFormatProperties2 != nint.Zero)
		{
			GetPhysicalDeviceFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatProperties2Delegate_0>(getPhysicalDeviceFormatProperties2);
		}
		var getPhysicalDeviceImageFormatProperties2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceImageFormatProperties2");
		if (getPhysicalDeviceImageFormatProperties2 != nint.Zero)
		{
			GetPhysicalDeviceImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2Delegate_0>(getPhysicalDeviceImageFormatProperties2);
			GetPhysicalDeviceImageFormatProperties2_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2Delegate_1>(getPhysicalDeviceImageFormatProperties2);
		}
		var getPhysicalDeviceQueueFamilyProperties2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
		if (getPhysicalDeviceQueueFamilyProperties2 != nint.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2Delegate_0>(getPhysicalDeviceQueueFamilyProperties2);
			GetPhysicalDeviceQueueFamilyProperties2_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2Delegate_1>(getPhysicalDeviceQueueFamilyProperties2);
		}
		var getPhysicalDeviceMemoryProperties2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceMemoryProperties2");
		if (getPhysicalDeviceMemoryProperties2 != nint.Zero)
		{
			GetPhysicalDeviceMemoryProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryProperties2Delegate_0>(getPhysicalDeviceMemoryProperties2);
		}
		var getPhysicalDeviceSparseImageFormatProperties2 = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
		if (getPhysicalDeviceSparseImageFormatProperties2 != nint.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties2_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_0>(getPhysicalDeviceSparseImageFormatProperties2);
			GetPhysicalDeviceSparseImageFormatProperties2_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_1>(getPhysicalDeviceSparseImageFormatProperties2);
			GetPhysicalDeviceSparseImageFormatProperties2_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_2>(getPhysicalDeviceSparseImageFormatProperties2);
			GetPhysicalDeviceSparseImageFormatProperties2_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2Delegate_3>(getPhysicalDeviceSparseImageFormatProperties2);
		}
		var trimCommandPool = (nint)GetInstanceProcedureAddress(instance, "vkTrimCommandPool");
		if (trimCommandPool != nint.Zero)
		{
			TrimCommandPool_0 = Marshal.GetDelegateForFunctionPointer<TrimCommandPoolDelegate_0>(trimCommandPool);
		}
		var getDeviceQueue2 = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceQueue2");
		if (getDeviceQueue2 != nint.Zero)
		{
			GetDeviceQueue2_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueue2Delegate_0>(getDeviceQueue2);
			GetDeviceQueue2_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceQueue2Delegate_1>(getDeviceQueue2);
		}
		var createSamplerYcbcrConversion = (nint)GetInstanceProcedureAddress(instance, "vkCreateSamplerYcbcrConversion");
		if (createSamplerYcbcrConversion != nint.Zero)
		{
			CreateSamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_0>(createSamplerYcbcrConversion);
			CreateSamplerYcbcrConversion_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_1>(createSamplerYcbcrConversion);
			CreateSamplerYcbcrConversion_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_2>(createSamplerYcbcrConversion);
			CreateSamplerYcbcrConversion_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionDelegate_3>(createSamplerYcbcrConversion);
		}
		var destroySamplerYcbcrConversion = (nint)GetInstanceProcedureAddress(instance, "vkDestroySamplerYcbcrConversion");
		if (destroySamplerYcbcrConversion != nint.Zero)
		{
			DestroySamplerYcbcrConversion_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionDelegate_0>(destroySamplerYcbcrConversion);
			DestroySamplerYcbcrConversion_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionDelegate_1>(destroySamplerYcbcrConversion);
		}
		var createDescriptorUpdateTemplate = (nint)GetInstanceProcedureAddress(instance, "vkCreateDescriptorUpdateTemplate");
		if (createDescriptorUpdateTemplate != nint.Zero)
		{
			CreateDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_0>(createDescriptorUpdateTemplate);
			CreateDescriptorUpdateTemplate_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_1>(createDescriptorUpdateTemplate);
			CreateDescriptorUpdateTemplate_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_2>(createDescriptorUpdateTemplate);
			CreateDescriptorUpdateTemplate_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateDelegate_3>(createDescriptorUpdateTemplate);
		}
		var destroyDescriptorUpdateTemplate = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDescriptorUpdateTemplate");
		if (destroyDescriptorUpdateTemplate != nint.Zero)
		{
			DestroyDescriptorUpdateTemplate_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateDelegate_0>(destroyDescriptorUpdateTemplate);
			DestroyDescriptorUpdateTemplate_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateDelegate_1>(destroyDescriptorUpdateTemplate);
		}
		var updateDescriptorSetWithTemplate = (nint)GetInstanceProcedureAddress(instance, "vkUpdateDescriptorSetWithTemplate");
		if (updateDescriptorSetWithTemplate != nint.Zero)
		{
			UpdateDescriptorSetWithTemplate_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetWithTemplateDelegate_0>(updateDescriptorSetWithTemplate);
		}
		var getPhysicalDeviceExternalBufferProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalBufferProperties");
		if (getPhysicalDeviceExternalBufferProperties != nint.Zero)
		{
			GetPhysicalDeviceExternalBufferProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesDelegate_0>(getPhysicalDeviceExternalBufferProperties);
			GetPhysicalDeviceExternalBufferProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesDelegate_1>(getPhysicalDeviceExternalBufferProperties);
		}
		var getPhysicalDeviceExternalFenceProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalFenceProperties");
		if (getPhysicalDeviceExternalFenceProperties != nint.Zero)
		{
			GetPhysicalDeviceExternalFenceProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesDelegate_0>(getPhysicalDeviceExternalFenceProperties);
			GetPhysicalDeviceExternalFenceProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesDelegate_1>(getPhysicalDeviceExternalFenceProperties);
		}
		var getPhysicalDeviceExternalSemaphoreProperties = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
		if (getPhysicalDeviceExternalSemaphoreProperties != nint.Zero)
		{
			GetPhysicalDeviceExternalSemaphoreProperties_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesDelegate_0>(getPhysicalDeviceExternalSemaphoreProperties);
			GetPhysicalDeviceExternalSemaphoreProperties_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesDelegate_1>(getPhysicalDeviceExternalSemaphoreProperties);
		}
		var getDescriptorSetLayoutSupport = (nint)GetInstanceProcedureAddress(instance, "vkGetDescriptorSetLayoutSupport");
		if (getDescriptorSetLayoutSupport != nint.Zero)
		{
			GetDescriptorSetLayoutSupport_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportDelegate_0>(getDescriptorSetLayoutSupport);
			GetDescriptorSetLayoutSupport_1 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportDelegate_1>(getDescriptorSetLayoutSupport);
		}
		var commandDrawIndirectCount = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndirectCount");
		if (commandDrawIndirectCount != nint.Zero)
		{
			CommandDrawIndirectCount_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountDelegate_0>(commandDrawIndirectCount);
		}
		var commandDrawIndexedIndirectCount = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndexedIndirectCount");
		if (commandDrawIndexedIndirectCount != nint.Zero)
		{
			CommandDrawIndexedIndirectCount_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountDelegate_0>(commandDrawIndexedIndirectCount);
		}
		var createRenderPass2 = (nint)GetInstanceProcedureAddress(instance, "vkCreateRenderPass2");
		if (createRenderPass2 != nint.Zero)
		{
			CreateRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_0>(createRenderPass2);
			CreateRenderPass2_1 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_1>(createRenderPass2);
			CreateRenderPass2_2 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_2>(createRenderPass2);
			CreateRenderPass2_3 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2Delegate_3>(createRenderPass2);
		}
		var commandBeginRenderPass2 = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginRenderPass2");
		if (commandBeginRenderPass2 != nint.Zero)
		{
			CommandBeginRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_0>(commandBeginRenderPass2);
			CommandBeginRenderPass2_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_1>(commandBeginRenderPass2);
			CommandBeginRenderPass2_2 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_2>(commandBeginRenderPass2);
			CommandBeginRenderPass2_3 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2Delegate_3>(commandBeginRenderPass2);
		}
		var commandNextSubpass2 = (nint)GetInstanceProcedureAddress(instance, "vkCmdNextSubpass2");
		if (commandNextSubpass2 != nint.Zero)
		{
			CommandNextSubpass2_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_0>(commandNextSubpass2);
			CommandNextSubpass2_1 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_1>(commandNextSubpass2);
			CommandNextSubpass2_2 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_2>(commandNextSubpass2);
			CommandNextSubpass2_3 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2Delegate_3>(commandNextSubpass2);
		}
		var commandEndRenderPass2 = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndRenderPass2");
		if (commandEndRenderPass2 != nint.Zero)
		{
			CommandEndRenderPass2_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2Delegate_0>(commandEndRenderPass2);
			CommandEndRenderPass2_1 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2Delegate_1>(commandEndRenderPass2);
		}
		var resetQueryPool = (nint)GetInstanceProcedureAddress(instance, "vkResetQueryPool");
		if (resetQueryPool != nint.Zero)
		{
			ResetQueryPool_0 = Marshal.GetDelegateForFunctionPointer<ResetQueryPoolDelegate_0>(resetQueryPool);
		}
		var getSemaphoreCounterValue = (nint)GetInstanceProcedureAddress(instance, "vkGetSemaphoreCounterValue");
		if (getSemaphoreCounterValue != nint.Zero)
		{
			GetSemaphoreCounterValue_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreCounterValueDelegate_0>(getSemaphoreCounterValue);
		}
		var waitSemaphores = (nint)GetInstanceProcedureAddress(instance, "vkWaitSemaphores");
		if (waitSemaphores != nint.Zero)
		{
			WaitSemaphores_0 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresDelegate_0>(waitSemaphores);
			WaitSemaphores_1 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresDelegate_1>(waitSemaphores);
		}
		var signalSemaphore = (nint)GetInstanceProcedureAddress(instance, "vkSignalSemaphore");
		if (signalSemaphore != nint.Zero)
		{
			SignalSemaphore_0 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreDelegate_0>(signalSemaphore);
			SignalSemaphore_1 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreDelegate_1>(signalSemaphore);
		}
		var getBufferDeviceAddress = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferDeviceAddress");
		if (getBufferDeviceAddress != nint.Zero)
		{
			GetBufferDeviceAddress_0 = Marshal.GetDelegateForFunctionPointer<GetBufferDeviceAddressDelegate_0>(getBufferDeviceAddress);
		}
		var getBufferOpaqueCaptureAddress = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferOpaqueCaptureAddress");
		if (getBufferOpaqueCaptureAddress != nint.Zero)
		{
			GetBufferOpaqueCaptureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetBufferOpaqueCaptureAddressDelegate_0>(getBufferOpaqueCaptureAddress);
		}
		var getDeviceMemoryOpaqueCaptureAddress = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceMemoryOpaqueCaptureAddress");
		if (getDeviceMemoryOpaqueCaptureAddress != nint.Zero)
		{
			GetDeviceMemoryOpaqueCaptureAddress_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryOpaqueCaptureAddressDelegate_0>(getDeviceMemoryOpaqueCaptureAddress);
		}
		var destroySurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkDestroySurfaceKHR");
		if (destroySurfaceKHR != nint.Zero)
		{
			DestroySurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_0>(destroySurfaceKHR);
			DestroySurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySurfaceKHRDelegate_1>(destroySurfaceKHR);
		}
		var getPhysicalDeviceSurfaceSupportKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfaceSupportKHR");
		if (getPhysicalDeviceSurfaceSupportKHR != nint.Zero)
		{
			GetPhysicalDeviceSurfaceSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceSupportKHRDelegate_0>(getPhysicalDeviceSurfaceSupportKHR);
		}
		var getPhysicalDeviceSurfaceCapabilitiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
		if (getPhysicalDeviceSurfaceCapabilitiesKHR != nint.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate_0>(getPhysicalDeviceSurfaceCapabilitiesKHR);
		}
		var getPhysicalDeviceSurfaceFormatsKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR");
		if (getPhysicalDeviceSurfaceFormatsKHR != nint.Zero)
		{
			GetPhysicalDeviceSurfaceFormatsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormatsKHRDelegate_0>(getPhysicalDeviceSurfaceFormatsKHR);
			GetPhysicalDeviceSurfaceFormatsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormatsKHRDelegate_1>(getPhysicalDeviceSurfaceFormatsKHR);
		}
		var getPhysicalDeviceSurfacePresentModesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR");
		if (getPhysicalDeviceSurfacePresentModesKHR != nint.Zero)
		{
			GetPhysicalDeviceSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_0>(getPhysicalDeviceSurfacePresentModesKHR);
			GetPhysicalDeviceSurfacePresentModesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModesKHRDelegate_1>(getPhysicalDeviceSurfacePresentModesKHR);
		}
		var createSwapchainKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateSwapchainKHR");
		if (createSwapchainKHR != nint.Zero)
		{
			CreateSwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_0>(createSwapchainKHR);
			CreateSwapchainKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_1>(createSwapchainKHR);
			CreateSwapchainKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_2>(createSwapchainKHR);
			CreateSwapchainKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateSwapchainKHRDelegate_3>(createSwapchainKHR);
		}
		var destroySwapchainKHR = (nint)GetInstanceProcedureAddress(instance, "vkDestroySwapchainKHR");
		if (destroySwapchainKHR != nint.Zero)
		{
			DestroySwapchainKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_0>(destroySwapchainKHR);
			DestroySwapchainKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySwapchainKHRDelegate_1>(destroySwapchainKHR);
		}
		var getSwapchainImagesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetSwapchainImagesKHR");
		if (getSwapchainImagesKHR != nint.Zero)
		{
			GetSwapchainImagesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_0>(getSwapchainImagesKHR);
			GetSwapchainImagesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSwapchainImagesKHRDelegate_1>(getSwapchainImagesKHR);
		}
		var acquireNextImageKHR = (nint)GetInstanceProcedureAddress(instance, "vkAcquireNextImageKHR");
		if (acquireNextImageKHR != nint.Zero)
		{
			AcquireNextImageKHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImageKHRDelegate_0>(acquireNextImageKHR);
		}
		var queuePresentKHR = (nint)GetInstanceProcedureAddress(instance, "vkQueuePresentKHR");
		if (queuePresentKHR != nint.Zero)
		{
			QueuePresentKHR_0 = Marshal.GetDelegateForFunctionPointer<QueuePresentKHRDelegate_0>(queuePresentKHR);
			QueuePresentKHR_1 = Marshal.GetDelegateForFunctionPointer<QueuePresentKHRDelegate_1>(queuePresentKHR);
		}
		var getDeviceGroupPresentCapabilitiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceGroupPresentCapabilitiesKHR");
		if (getDeviceGroupPresentCapabilitiesKHR != nint.Zero)
		{
			GetDeviceGroupPresentCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPresentCapabilitiesKHRDelegate_0>(getDeviceGroupPresentCapabilitiesKHR);
		}
		var getDeviceGroupSurfacePresentModesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceGroupSurfacePresentModesKHR");
		if (getDeviceGroupSurfacePresentModesKHR != nint.Zero)
		{
			GetDeviceGroupSurfacePresentModesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModesKHRDelegate_0>(getDeviceGroupSurfacePresentModesKHR);
		}
		var getPhysicalDevicePresentRectanglesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDevicePresentRectanglesKHR");
		if (getPhysicalDevicePresentRectanglesKHR != nint.Zero)
		{
			GetPhysicalDevicePresentRectanglesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHRDelegate_0>(getPhysicalDevicePresentRectanglesKHR);
			GetPhysicalDevicePresentRectanglesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDevicePresentRectanglesKHRDelegate_1>(getPhysicalDevicePresentRectanglesKHR);
		}
		var acquireNextImage2KHR = (nint)GetInstanceProcedureAddress(instance, "vkAcquireNextImage2KHR");
		if (acquireNextImage2KHR != nint.Zero)
		{
			AcquireNextImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHRDelegate_0>(acquireNextImage2KHR);
			AcquireNextImage2KHR_1 = Marshal.GetDelegateForFunctionPointer<AcquireNextImage2KHRDelegate_1>(acquireNextImage2KHR);
		}
		var getPhysicalDeviceDisplayPropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR");
		if (getPhysicalDeviceDisplayPropertiesKHR != nint.Zero)
		{
			GetPhysicalDeviceDisplayPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_0>(getPhysicalDeviceDisplayPropertiesKHR);
			GetPhysicalDeviceDisplayPropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPropertiesKHRDelegate_1>(getPhysicalDeviceDisplayPropertiesKHR);
		}
		var getPhysicalDeviceDisplayPlanePropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
		if (getPhysicalDeviceDisplayPlanePropertiesKHR != nint.Zero)
		{
			GetPhysicalDeviceDisplayPlanePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_0>(getPhysicalDeviceDisplayPlanePropertiesKHR);
			GetPhysicalDeviceDisplayPlanePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate_1>(getPhysicalDeviceDisplayPlanePropertiesKHR);
		}
		var getDisplayPlaneSupportedDisplaysKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDisplayPlaneSupportedDisplaysKHR");
		if (getDisplayPlaneSupportedDisplaysKHR != nint.Zero)
		{
			GetDisplayPlaneSupportedDisplaysKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_0>(getDisplayPlaneSupportedDisplaysKHR);
			GetDisplayPlaneSupportedDisplaysKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneSupportedDisplaysKHRDelegate_1>(getDisplayPlaneSupportedDisplaysKHR);
		}
		var getDisplayModePropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDisplayModePropertiesKHR");
		if (getDisplayModePropertiesKHR != nint.Zero)
		{
			GetDisplayModePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_0>(getDisplayModePropertiesKHR);
			GetDisplayModePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayModePropertiesKHRDelegate_1>(getDisplayModePropertiesKHR);
		}
		var createDisplayModeKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateDisplayModeKHR");
		if (createDisplayModeKHR != nint.Zero)
		{
			CreateDisplayModeKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_0>(createDisplayModeKHR);
			CreateDisplayModeKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_1>(createDisplayModeKHR);
			CreateDisplayModeKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_2>(createDisplayModeKHR);
			CreateDisplayModeKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDisplayModeKHRDelegate_3>(createDisplayModeKHR);
		}
		var getDisplayPlaneCapabilitiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDisplayPlaneCapabilitiesKHR");
		if (getDisplayPlaneCapabilitiesKHR != nint.Zero)
		{
			GetDisplayPlaneCapabilitiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilitiesKHRDelegate_0>(getDisplayPlaneCapabilitiesKHR);
		}
		var createDisplayPlaneSurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateDisplayPlaneSurfaceKHR");
		if (createDisplayPlaneSurfaceKHR != nint.Zero)
		{
			CreateDisplayPlaneSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_0>(createDisplayPlaneSurfaceKHR);
			CreateDisplayPlaneSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_1>(createDisplayPlaneSurfaceKHR);
			CreateDisplayPlaneSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_2>(createDisplayPlaneSurfaceKHR);
			CreateDisplayPlaneSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDisplayPlaneSurfaceKHRDelegate_3>(createDisplayPlaneSurfaceKHR);
		}
		var createSharedSwapchainsKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateSharedSwapchainsKHR");
		if (createSharedSwapchainsKHR != nint.Zero)
		{
			CreateSharedSwapchainsKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_0>(createSharedSwapchainsKHR);
			CreateSharedSwapchainsKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSharedSwapchainsKHRDelegate_1>(createSharedSwapchainsKHR);
		}
		var createXlibSurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateXlibSurfaceKHR");
		if (createXlibSurfaceKHR != nint.Zero)
		{
			CreateXlibSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_0>(createXlibSurfaceKHR);
			CreateXlibSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_1>(createXlibSurfaceKHR);
			CreateXlibSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_2>(createXlibSurfaceKHR);
			CreateXlibSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateXlibSurfaceKHRDelegate_3>(createXlibSurfaceKHR);
		}
		var getPhysicalDeviceXlibPresentationSupportKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR");
		if (getPhysicalDeviceXlibPresentationSupportKHR != nint.Zero)
		{
			GetPhysicalDeviceXlibPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceXlibPresentationSupportKHRDelegate_0>(getPhysicalDeviceXlibPresentationSupportKHR);
		}
		var createXcbSurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateXcbSurfaceKHR");
		if (createXcbSurfaceKHR != nint.Zero)
		{
			CreateXcbSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_0>(createXcbSurfaceKHR);
			CreateXcbSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_1>(createXcbSurfaceKHR);
			CreateXcbSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_2>(createXcbSurfaceKHR);
			CreateXcbSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateXcbSurfaceKHRDelegate_3>(createXcbSurfaceKHR);
		}
		var getPhysicalDeviceXcbPresentationSupportKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceXcbPresentationSupportKHR");
		if (getPhysicalDeviceXcbPresentationSupportKHR != nint.Zero)
		{
			GetPhysicalDeviceXcbPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceXcbPresentationSupportKHRDelegate_0>(getPhysicalDeviceXcbPresentationSupportKHR);
		}
		var createWaylandSurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateWaylandSurfaceKHR");
		if (createWaylandSurfaceKHR != nint.Zero)
		{
			CreateWaylandSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_0>(createWaylandSurfaceKHR);
			CreateWaylandSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_1>(createWaylandSurfaceKHR);
			CreateWaylandSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_2>(createWaylandSurfaceKHR);
			CreateWaylandSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateWaylandSurfaceKHRDelegate_3>(createWaylandSurfaceKHR);
		}
		var getPhysicalDeviceWaylandPresentationSupportKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceWaylandPresentationSupportKHR");
		if (getPhysicalDeviceWaylandPresentationSupportKHR != nint.Zero)
		{
			GetPhysicalDeviceWaylandPresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceWaylandPresentationSupportKHRDelegate_0>(getPhysicalDeviceWaylandPresentationSupportKHR);
		}
		var createAndroidSurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateAndroidSurfaceKHR");
		if (createAndroidSurfaceKHR != nint.Zero)
		{
			CreateAndroidSurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_0>(createAndroidSurfaceKHR);
			CreateAndroidSurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_1>(createAndroidSurfaceKHR);
			CreateAndroidSurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_2>(createAndroidSurfaceKHR);
			CreateAndroidSurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateAndroidSurfaceKHRDelegate_3>(createAndroidSurfaceKHR);
		}
		var createWin32SurfaceKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateWin32SurfaceKHR");
		if (createWin32SurfaceKHR != nint.Zero)
		{
			CreateWin32SurfaceKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_0>(createWin32SurfaceKHR);
			CreateWin32SurfaceKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_1>(createWin32SurfaceKHR);
			CreateWin32SurfaceKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_2>(createWin32SurfaceKHR);
			CreateWin32SurfaceKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateWin32SurfaceKHRDelegate_3>(createWin32SurfaceKHR);
		}
		var getPhysicalDeviceWin32PresentationSupportKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
		if (getPhysicalDeviceWin32PresentationSupportKHR != nint.Zero)
		{
			GetPhysicalDeviceWin32PresentationSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceWin32PresentationSupportKHRDelegate_0>(getPhysicalDeviceWin32PresentationSupportKHR);
		}
		var createDebugReportCallbackEXT = (nint)GetInstanceProcedureAddress(instance, "vkCreateDebugReportCallbackEXT");
		if (createDebugReportCallbackEXT != nint.Zero)
		{
			CreateDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_0>(createDebugReportCallbackEXT);
			CreateDebugReportCallbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_1>(createDebugReportCallbackEXT);
			CreateDebugReportCallbackEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_2>(createDebugReportCallbackEXT);
			CreateDebugReportCallbackEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackEXTDelegate_3>(createDebugReportCallbackEXT);
		}
		var destroyDebugReportCallbackEXT = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDebugReportCallbackEXT");
		if (destroyDebugReportCallbackEXT != nint.Zero)
		{
			DestroyDebugReportCallbackEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_0>(destroyDebugReportCallbackEXT);
			DestroyDebugReportCallbackEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackEXTDelegate_1>(destroyDebugReportCallbackEXT);
		}
		var debugReportMessageEXT = (nint)GetInstanceProcedureAddress(instance, "vkDebugReportMessageEXT");
		if (debugReportMessageEXT != nint.Zero)
		{
			DebugReportMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugReportMessageEXTDelegate_0>(debugReportMessageEXT);
		}
		var debugMarkerSetObjectTagEXT = (nint)GetInstanceProcedureAddress(instance, "vkDebugMarkerSetObjectTagEXT");
		if (debugMarkerSetObjectTagEXT != nint.Zero)
		{
			DebugMarkerSetObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectTagEXTDelegate_0>(debugMarkerSetObjectTagEXT);
			DebugMarkerSetObjectTagEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectTagEXTDelegate_1>(debugMarkerSetObjectTagEXT);
		}
		var debugMarkerSetObjectNameEXT = (nint)GetInstanceProcedureAddress(instance, "vkDebugMarkerSetObjectNameEXT");
		if (debugMarkerSetObjectNameEXT != nint.Zero)
		{
			DebugMarkerSetObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_0>(debugMarkerSetObjectNameEXT);
			DebugMarkerSetObjectNameEXT_1 = Marshal.GetDelegateForFunctionPointer<DebugMarkerSetObjectNameEXTDelegate_1>(debugMarkerSetObjectNameEXT);
		}
		var commandDebugMarkerBeginEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdDebugMarkerBeginEXT");
		if (commandDebugMarkerBeginEXT != nint.Zero)
		{
			CommandDebugMarkerBeginEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_0>(commandDebugMarkerBeginEXT);
			CommandDebugMarkerBeginEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerBeginEXTDelegate_1>(commandDebugMarkerBeginEXT);
		}
		var commandDebugMarkerEndEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdDebugMarkerEndEXT");
		if (commandDebugMarkerEndEXT != nint.Zero)
		{
			CommandDebugMarkerEndEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerEndEXTDelegate_0>(commandDebugMarkerEndEXT);
		}
		var commandDebugMarkerInsertEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdDebugMarkerInsertEXT");
		if (commandDebugMarkerInsertEXT != nint.Zero)
		{
			CommandDebugMarkerInsertEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerInsertEXTDelegate_0>(commandDebugMarkerInsertEXT);
			CommandDebugMarkerInsertEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDebugMarkerInsertEXTDelegate_1>(commandDebugMarkerInsertEXT);
		}
		var commandBindTransformFeedbackBuffersEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindTransformFeedbackBuffersEXT");
		if (commandBindTransformFeedbackBuffersEXT != nint.Zero)
		{
			CommandBindTransformFeedbackBuffersEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_0>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_1>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_2 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_2>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_3 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_3>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_4 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_4>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_5 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_5>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_6 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_6>(commandBindTransformFeedbackBuffersEXT);
			CommandBindTransformFeedbackBuffersEXT_7 = Marshal.GetDelegateForFunctionPointer<CommandBindTransformFeedbackBuffersEXTDelegate_7>(commandBindTransformFeedbackBuffersEXT);
		}
		var commandBeginTransformFeedbackEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginTransformFeedbackEXT");
		if (commandBeginTransformFeedbackEXT != nint.Zero)
		{
			CommandBeginTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginTransformFeedbackEXTDelegate_0>(commandBeginTransformFeedbackEXT);
			CommandBeginTransformFeedbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginTransformFeedbackEXTDelegate_1>(commandBeginTransformFeedbackEXT);
		}
		var commandEndTransformFeedbackEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndTransformFeedbackEXT");
		if (commandEndTransformFeedbackEXT != nint.Zero)
		{
			CommandEndTransformFeedbackEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndTransformFeedbackEXTDelegate_0>(commandEndTransformFeedbackEXT);
			CommandEndTransformFeedbackEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandEndTransformFeedbackEXTDelegate_1>(commandEndTransformFeedbackEXT);
		}
		var commandBeginQueryIndexedEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginQueryIndexedEXT");
		if (commandBeginQueryIndexedEXT != nint.Zero)
		{
			CommandBeginQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginQueryIndexedEXTDelegate_0>(commandBeginQueryIndexedEXT);
		}
		var commandEndQueryIndexedEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndQueryIndexedEXT");
		if (commandEndQueryIndexedEXT != nint.Zero)
		{
			CommandEndQueryIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndQueryIndexedEXTDelegate_0>(commandEndQueryIndexedEXT);
		}
		var commandDrawIndirectByteCountEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndirectByteCountEXT");
		if (commandDrawIndirectByteCountEXT != nint.Zero)
		{
			CommandDrawIndirectByteCountEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectByteCountEXTDelegate_0>(commandDrawIndirectByteCountEXT);
		}
		var createCuModuleNVX = (nint)GetInstanceProcedureAddress(instance, "vkCreateCuModuleNVX");
		if (createCuModuleNVX != nint.Zero)
		{
			CreateCuModuleNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_0>(createCuModuleNVX);
			CreateCuModuleNVX_1 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_1>(createCuModuleNVX);
			CreateCuModuleNVX_2 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_2>(createCuModuleNVX);
			CreateCuModuleNVX_3 = Marshal.GetDelegateForFunctionPointer<CreateCuModuleNVXDelegate_3>(createCuModuleNVX);
		}
		var createCuFunctionNVX = (nint)GetInstanceProcedureAddress(instance, "vkCreateCuFunctionNVX");
		if (createCuFunctionNVX != nint.Zero)
		{
			CreateCuFunctionNVX_0 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_0>(createCuFunctionNVX);
			CreateCuFunctionNVX_1 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_1>(createCuFunctionNVX);
			CreateCuFunctionNVX_2 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_2>(createCuFunctionNVX);
			CreateCuFunctionNVX_3 = Marshal.GetDelegateForFunctionPointer<CreateCuFunctionNVXDelegate_3>(createCuFunctionNVX);
		}
		var destroyCuModuleNVX = (nint)GetInstanceProcedureAddress(instance, "vkDestroyCuModuleNVX");
		if (destroyCuModuleNVX != nint.Zero)
		{
			DestroyCuModuleNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyCuModuleNVXDelegate_0>(destroyCuModuleNVX);
			DestroyCuModuleNVX_1 = Marshal.GetDelegateForFunctionPointer<DestroyCuModuleNVXDelegate_1>(destroyCuModuleNVX);
		}
		var destroyCuFunctionNVX = (nint)GetInstanceProcedureAddress(instance, "vkDestroyCuFunctionNVX");
		if (destroyCuFunctionNVX != nint.Zero)
		{
			DestroyCuFunctionNVX_0 = Marshal.GetDelegateForFunctionPointer<DestroyCuFunctionNVXDelegate_0>(destroyCuFunctionNVX);
			DestroyCuFunctionNVX_1 = Marshal.GetDelegateForFunctionPointer<DestroyCuFunctionNVXDelegate_1>(destroyCuFunctionNVX);
		}
		var commandCuLaunchKernelNVX = (nint)GetInstanceProcedureAddress(instance, "vkCmdCuLaunchKernelNVX");
		if (commandCuLaunchKernelNVX != nint.Zero)
		{
			CommandCuLaunchKernelNVX_0 = Marshal.GetDelegateForFunctionPointer<CommandCuLaunchKernelNVXDelegate_0>(commandCuLaunchKernelNVX);
			CommandCuLaunchKernelNVX_1 = Marshal.GetDelegateForFunctionPointer<CommandCuLaunchKernelNVXDelegate_1>(commandCuLaunchKernelNVX);
		}
		var getImageViewHandleNVX = (nint)GetInstanceProcedureAddress(instance, "vkGetImageViewHandleNVX");
		if (getImageViewHandleNVX != nint.Zero)
		{
			GetImageViewHandleNVX_0 = Marshal.GetDelegateForFunctionPointer<GetImageViewHandleNVXDelegate_0>(getImageViewHandleNVX);
		}
		var getImageViewAddressNVX = (nint)GetInstanceProcedureAddress(instance, "vkGetImageViewAddressNVX");
		if (getImageViewAddressNVX != nint.Zero)
		{
			GetImageViewAddressNVX_0 = Marshal.GetDelegateForFunctionPointer<GetImageViewAddressNVXDelegate_0>(getImageViewAddressNVX);
		}
		var commandDrawIndirectCountAMD = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndirectCount");
		if (commandDrawIndirectCountAMD != nint.Zero)
		{
			CommandDrawIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountAMDDelegate_0>(commandDrawIndirectCountAMD);
		}
		var commandDrawIndexedIndirectCountAMD = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndexedIndirectCount");
		if (commandDrawIndexedIndirectCountAMD != nint.Zero)
		{
			CommandDrawIndexedIndirectCountAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountAMDDelegate_0>(commandDrawIndexedIndirectCountAMD);
		}
		var getShaderInfoAMD = (nint)GetInstanceProcedureAddress(instance, "vkGetShaderInfoAMD");
		if (getShaderInfoAMD != nint.Zero)
		{
			GetShaderInfoAMD_0 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_0>(getShaderInfoAMD);
			GetShaderInfoAMD_1 = Marshal.GetDelegateForFunctionPointer<GetShaderInfoAMDDelegate_1>(getShaderInfoAMD);
		}
		var commandBeginRenderingKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginRenderingKHR");
		if (commandBeginRenderingKHR != nint.Zero)
		{
			CommandBeginRenderingKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderingKHRDelegate_0>(commandBeginRenderingKHR);
			CommandBeginRenderingKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderingKHRDelegate_1>(commandBeginRenderingKHR);
		}
		var commandEndRenderingKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndRenderingKHR");
		if (commandEndRenderingKHR != nint.Zero)
		{
			CommandEndRenderingKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderingKHRDelegate_0>(commandEndRenderingKHR);
		}
		var getPhysicalDeviceExternalImageFormatPropertiesNV = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV");
		if (getPhysicalDeviceExternalImageFormatPropertiesNV != nint.Zero)
		{
			GetPhysicalDeviceExternalImageFormatPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate_0>(getPhysicalDeviceExternalImageFormatPropertiesNV);
		}
		var getMemoryWin32HandleNV = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryWin32HandleNV");
		if (getMemoryWin32HandleNV != nint.Zero)
		{
			GetMemoryWin32HandleNV_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleNVDelegate_0>(getMemoryWin32HandleNV);
		}
		var getPhysicalDeviceFeatures2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFeatures2");
		if (getPhysicalDeviceFeatures2KHR != nint.Zero)
		{
			GetPhysicalDeviceFeatures2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFeatures2KHRDelegate_0>(getPhysicalDeviceFeatures2KHR);
		}
		var getPhysicalDeviceProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceProperties2");
		if (getPhysicalDeviceProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceProperties2KHRDelegate_0>(getPhysicalDeviceProperties2KHR);
		}
		var getPhysicalDeviceFormatProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFormatProperties2");
		if (getPhysicalDeviceFormatProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFormatProperties2KHRDelegate_0>(getPhysicalDeviceFormatProperties2KHR);
		}
		var getPhysicalDeviceImageFormatProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceImageFormatProperties2");
		if (getPhysicalDeviceImageFormatProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2KHRDelegate_0>(getPhysicalDeviceImageFormatProperties2KHR);
			GetPhysicalDeviceImageFormatProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceImageFormatProperties2KHRDelegate_1>(getPhysicalDeviceImageFormatProperties2KHR);
		}
		var getPhysicalDeviceQueueFamilyProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
		if (getPhysicalDeviceQueueFamilyProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceQueueFamilyProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_0>(getPhysicalDeviceQueueFamilyProperties2KHR);
			GetPhysicalDeviceQueueFamilyProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyProperties2KHRDelegate_1>(getPhysicalDeviceQueueFamilyProperties2KHR);
		}
		var getPhysicalDeviceMemoryProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceMemoryProperties2");
		if (getPhysicalDeviceMemoryProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceMemoryProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMemoryProperties2KHRDelegate_0>(getPhysicalDeviceMemoryProperties2KHR);
		}
		var getPhysicalDeviceSparseImageFormatProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
		if (getPhysicalDeviceSparseImageFormatProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceSparseImageFormatProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_0>(getPhysicalDeviceSparseImageFormatProperties2KHR);
			GetPhysicalDeviceSparseImageFormatProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_1>(getPhysicalDeviceSparseImageFormatProperties2KHR);
			GetPhysicalDeviceSparseImageFormatProperties2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_2>(getPhysicalDeviceSparseImageFormatProperties2KHR);
			GetPhysicalDeviceSparseImageFormatProperties2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSparseImageFormatProperties2KHRDelegate_3>(getPhysicalDeviceSparseImageFormatProperties2KHR);
		}
		var getDeviceGroupPeerMemoryFeaturesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceGroupPeerMemoryFeatures");
		if (getDeviceGroupPeerMemoryFeaturesKHR != nint.Zero)
		{
			GetDeviceGroupPeerMemoryFeaturesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupPeerMemoryFeaturesKHRDelegate_0>(getDeviceGroupPeerMemoryFeaturesKHR);
		}
		var commandSetDeviceMaskKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDeviceMask");
		if (commandSetDeviceMaskKHR != nint.Zero)
		{
			CommandSetDeviceMaskKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDeviceMaskKHRDelegate_0>(commandSetDeviceMaskKHR);
		}
		var commandDispatchBaseKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdDispatchBase");
		if (commandDispatchBaseKHR != nint.Zero)
		{
			CommandDispatchBaseKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandDispatchBaseKHRDelegate_0>(commandDispatchBaseKHR);
		}
		var trimCommandPoolKHR = (nint)GetInstanceProcedureAddress(instance, "vkTrimCommandPool");
		if (trimCommandPoolKHR != nint.Zero)
		{
			TrimCommandPoolKHR_0 = Marshal.GetDelegateForFunctionPointer<TrimCommandPoolKHRDelegate_0>(trimCommandPoolKHR);
		}
		var enumeratePhysicalDeviceGroupsKHR = (nint)GetInstanceProcedureAddress(instance, "vkEnumeratePhysicalDeviceGroups");
		if (enumeratePhysicalDeviceGroupsKHR != nint.Zero)
		{
			EnumeratePhysicalDeviceGroupsKHR_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsKHRDelegate_0>(enumeratePhysicalDeviceGroupsKHR);
			EnumeratePhysicalDeviceGroupsKHR_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceGroupsKHRDelegate_1>(enumeratePhysicalDeviceGroupsKHR);
		}
		var getPhysicalDeviceExternalBufferPropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalBufferProperties");
		if (getPhysicalDeviceExternalBufferPropertiesKHR != nint.Zero)
		{
			GetPhysicalDeviceExternalBufferPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_0>(getPhysicalDeviceExternalBufferPropertiesKHR);
			GetPhysicalDeviceExternalBufferPropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalBufferPropertiesKHRDelegate_1>(getPhysicalDeviceExternalBufferPropertiesKHR);
		}
		var getMemoryWin32HandleKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryWin32HandleKHR");
		if (getMemoryWin32HandleKHR != nint.Zero)
		{
			GetMemoryWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_0>(getMemoryWin32HandleKHR);
			GetMemoryWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandleKHRDelegate_1>(getMemoryWin32HandleKHR);
		}
		var getMemoryWin32HandlePropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryWin32HandlePropertiesKHR");
		if (getMemoryWin32HandlePropertiesKHR != nint.Zero)
		{
			GetMemoryWin32HandlePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryWin32HandlePropertiesKHRDelegate_0>(getMemoryWin32HandlePropertiesKHR);
		}
		var getMemoryFileDescriptorKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryFdKHR");
		if (getMemoryFileDescriptorKHR != nint.Zero)
		{
			GetMemoryFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorKHRDelegate_0>(getMemoryFileDescriptorKHR);
			GetMemoryFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorKHRDelegate_1>(getMemoryFileDescriptorKHR);
		}
		var getMemoryFileDescriptorPropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryFdPropertiesKHR");
		if (getMemoryFileDescriptorPropertiesKHR != nint.Zero)
		{
			GetMemoryFileDescriptorPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryFileDescriptorPropertiesKHRDelegate_0>(getMemoryFileDescriptorPropertiesKHR);
		}
		var getPhysicalDeviceExternalSemaphorePropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
		if (getPhysicalDeviceExternalSemaphorePropertiesKHR != nint.Zero)
		{
			GetPhysicalDeviceExternalSemaphorePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_0>(getPhysicalDeviceExternalSemaphorePropertiesKHR);
			GetPhysicalDeviceExternalSemaphorePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate_1>(getPhysicalDeviceExternalSemaphorePropertiesKHR);
		}
		var importSemaphoreWin32HandleKHR = (nint)GetInstanceProcedureAddress(instance, "vkImportSemaphoreWin32HandleKHR");
		if (importSemaphoreWin32HandleKHR != nint.Zero)
		{
			ImportSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_0>(importSemaphoreWin32HandleKHR);
			ImportSemaphoreWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreWin32HandleKHRDelegate_1>(importSemaphoreWin32HandleKHR);
		}
		var getSemaphoreWin32HandleKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetSemaphoreWin32HandleKHR");
		if (getSemaphoreWin32HandleKHR != nint.Zero)
		{
			GetSemaphoreWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_0>(getSemaphoreWin32HandleKHR);
			GetSemaphoreWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreWin32HandleKHRDelegate_1>(getSemaphoreWin32HandleKHR);
		}
		var importSemaphoreFileDescriptorKHR = (nint)GetInstanceProcedureAddress(instance, "vkImportSemaphoreFdKHR");
		if (importSemaphoreFileDescriptorKHR != nint.Zero)
		{
			ImportSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_0>(importSemaphoreFileDescriptorKHR);
			ImportSemaphoreFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportSemaphoreFileDescriptorKHRDelegate_1>(importSemaphoreFileDescriptorKHR);
		}
		var getSemaphoreFileDescriptorKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetSemaphoreFdKHR");
		if (getSemaphoreFileDescriptorKHR != nint.Zero)
		{
			GetSemaphoreFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_0>(getSemaphoreFileDescriptorKHR);
			GetSemaphoreFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreFileDescriptorKHRDelegate_1>(getSemaphoreFileDescriptorKHR);
		}
		var commandPushDescriptorSetKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdPushDescriptorSetKHR");
		if (commandPushDescriptorSetKHR != nint.Zero)
		{
			CommandPushDescriptorSetKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetKHRDelegate_0>(commandPushDescriptorSetKHR);
		}
		var commandPushDescriptorSetWithTemplateKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdPushDescriptorSetWithTemplateKHR");
		if (commandPushDescriptorSetWithTemplateKHR != nint.Zero)
		{
			CommandPushDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPushDescriptorSetWithTemplateKHRDelegate_0>(commandPushDescriptorSetWithTemplateKHR);
		}
		var commandBeginConditionalRenderingEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginConditionalRenderingEXT");
		if (commandBeginConditionalRenderingEXT != nint.Zero)
		{
			CommandBeginConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginConditionalRenderingEXTDelegate_0>(commandBeginConditionalRenderingEXT);
			CommandBeginConditionalRenderingEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginConditionalRenderingEXTDelegate_1>(commandBeginConditionalRenderingEXT);
		}
		var commandEndConditionalRenderingEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndConditionalRenderingEXT");
		if (commandEndConditionalRenderingEXT != nint.Zero)
		{
			CommandEndConditionalRenderingEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndConditionalRenderingEXTDelegate_0>(commandEndConditionalRenderingEXT);
		}
		var createDescriptorUpdateTemplateKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateDescriptorUpdateTemplate");
		if (createDescriptorUpdateTemplateKHR != nint.Zero)
		{
			CreateDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_0>(createDescriptorUpdateTemplateKHR);
			CreateDescriptorUpdateTemplateKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_1>(createDescriptorUpdateTemplateKHR);
			CreateDescriptorUpdateTemplateKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_2>(createDescriptorUpdateTemplateKHR);
			CreateDescriptorUpdateTemplateKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateDescriptorUpdateTemplateKHRDelegate_3>(createDescriptorUpdateTemplateKHR);
		}
		var destroyDescriptorUpdateTemplateKHR = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDescriptorUpdateTemplate");
		if (destroyDescriptorUpdateTemplateKHR != nint.Zero)
		{
			DestroyDescriptorUpdateTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateKHRDelegate_0>(destroyDescriptorUpdateTemplateKHR);
			DestroyDescriptorUpdateTemplateKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroyDescriptorUpdateTemplateKHRDelegate_1>(destroyDescriptorUpdateTemplateKHR);
		}
		var updateDescriptorSetWithTemplateKHR = (nint)GetInstanceProcedureAddress(instance, "vkUpdateDescriptorSetWithTemplate");
		if (updateDescriptorSetWithTemplateKHR != nint.Zero)
		{
			UpdateDescriptorSetWithTemplateKHR_0 = Marshal.GetDelegateForFunctionPointer<UpdateDescriptorSetWithTemplateKHRDelegate_0>(updateDescriptorSetWithTemplateKHR);
		}
		var commandSetViewportWScalingNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetViewportWScalingNV");
		if (commandSetViewportWScalingNV != nint.Zero)
		{
			CommandSetViewportWScalingNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_0>(commandSetViewportWScalingNV);
			CommandSetViewportWScalingNV_1 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWScalingNVDelegate_1>(commandSetViewportWScalingNV);
		}
		var releaseDisplayEXT = (nint)GetInstanceProcedureAddress(instance, "vkReleaseDisplayEXT");
		if (releaseDisplayEXT != nint.Zero)
		{
			ReleaseDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseDisplayEXTDelegate_0>(releaseDisplayEXT);
		}
		var getPhysicalDeviceSurfaceCapabilities2EXT = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT");
		if (getPhysicalDeviceSurfaceCapabilities2EXT != nint.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilities2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2EXTDelegate_0>(getPhysicalDeviceSurfaceCapabilities2EXT);
		}
		var displayPowerControlEXT = (nint)GetInstanceProcedureAddress(instance, "vkDisplayPowerControlEXT");
		if (displayPowerControlEXT != nint.Zero)
		{
			DisplayPowerControlEXT_0 = Marshal.GetDelegateForFunctionPointer<DisplayPowerControlEXTDelegate_0>(displayPowerControlEXT);
			DisplayPowerControlEXT_1 = Marshal.GetDelegateForFunctionPointer<DisplayPowerControlEXTDelegate_1>(displayPowerControlEXT);
		}
		var registerDeviceEventEXT = (nint)GetInstanceProcedureAddress(instance, "vkRegisterDeviceEventEXT");
		if (registerDeviceEventEXT != nint.Zero)
		{
			RegisterDeviceEventEXT_0 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_0>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_1 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_1>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_2 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_2>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_3 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_3>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_4 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_4>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_5 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_5>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_6 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_6>(registerDeviceEventEXT);
			RegisterDeviceEventEXT_7 = Marshal.GetDelegateForFunctionPointer<RegisterDeviceEventEXTDelegate_7>(registerDeviceEventEXT);
		}
		var registerDisplayEventEXT = (nint)GetInstanceProcedureAddress(instance, "vkRegisterDisplayEventEXT");
		if (registerDisplayEventEXT != nint.Zero)
		{
			RegisterDisplayEventEXT_0 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_0>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_1 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_1>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_2 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_2>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_3 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_3>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_4 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_4>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_5 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_5>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_6 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_6>(registerDisplayEventEXT);
			RegisterDisplayEventEXT_7 = Marshal.GetDelegateForFunctionPointer<RegisterDisplayEventEXTDelegate_7>(registerDisplayEventEXT);
		}
		var getSwapchainCounterEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetSwapchainCounterEXT");
		if (getSwapchainCounterEXT != nint.Zero)
		{
			GetSwapchainCounterEXT_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainCounterEXTDelegate_0>(getSwapchainCounterEXT);
		}
		var getRefreshCycleDurationGOOGLE = (nint)GetInstanceProcedureAddress(instance, "vkGetRefreshCycleDurationGOOGLE");
		if (getRefreshCycleDurationGOOGLE != nint.Zero)
		{
			GetRefreshCycleDurationGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<GetRefreshCycleDurationGOOGLEDelegate_0>(getRefreshCycleDurationGOOGLE);
		}
		var getPastPresentationTimingGOOGLE = (nint)GetInstanceProcedureAddress(instance, "vkGetPastPresentationTimingGOOGLE");
		if (getPastPresentationTimingGOOGLE != nint.Zero)
		{
			GetPastPresentationTimingGOOGLE_0 = Marshal.GetDelegateForFunctionPointer<GetPastPresentationTimingGOOGLEDelegate_0>(getPastPresentationTimingGOOGLE);
			GetPastPresentationTimingGOOGLE_1 = Marshal.GetDelegateForFunctionPointer<GetPastPresentationTimingGOOGLEDelegate_1>(getPastPresentationTimingGOOGLE);
		}
		var commandSetDiscardRectangleEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDiscardRectangleEXT");
		if (commandSetDiscardRectangleEXT != nint.Zero)
		{
			CommandSetDiscardRectangleEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDiscardRectangleEXTDelegate_0>(commandSetDiscardRectangleEXT);
		}
		var setHdrMetadataEXT = (nint)GetInstanceProcedureAddress(instance, "vkSetHdrMetadataEXT");
		if (setHdrMetadataEXT != nint.Zero)
		{
			SetHdrMetadataEXT_0 = Marshal.GetDelegateForFunctionPointer<SetHdrMetadataEXTDelegate_0>(setHdrMetadataEXT);
			SetHdrMetadataEXT_1 = Marshal.GetDelegateForFunctionPointer<SetHdrMetadataEXTDelegate_1>(setHdrMetadataEXT);
		}
		var createRenderPass2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateRenderPass2");
		if (createRenderPass2KHR != nint.Zero)
		{
			CreateRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2KHRDelegate_0>(createRenderPass2KHR);
			CreateRenderPass2KHR_1 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2KHRDelegate_1>(createRenderPass2KHR);
			CreateRenderPass2KHR_2 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2KHRDelegate_2>(createRenderPass2KHR);
			CreateRenderPass2KHR_3 = Marshal.GetDelegateForFunctionPointer<CreateRenderPass2KHRDelegate_3>(createRenderPass2KHR);
		}
		var commandBeginRenderPass2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginRenderPass2");
		if (commandBeginRenderPass2KHR != nint.Zero)
		{
			CommandBeginRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2KHRDelegate_0>(commandBeginRenderPass2KHR);
			CommandBeginRenderPass2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2KHRDelegate_1>(commandBeginRenderPass2KHR);
			CommandBeginRenderPass2KHR_2 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2KHRDelegate_2>(commandBeginRenderPass2KHR);
			CommandBeginRenderPass2KHR_3 = Marshal.GetDelegateForFunctionPointer<CommandBeginRenderPass2KHRDelegate_3>(commandBeginRenderPass2KHR);
		}
		var commandNextSubpass2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdNextSubpass2");
		if (commandNextSubpass2KHR != nint.Zero)
		{
			CommandNextSubpass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2KHRDelegate_0>(commandNextSubpass2KHR);
			CommandNextSubpass2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2KHRDelegate_1>(commandNextSubpass2KHR);
			CommandNextSubpass2KHR_2 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2KHRDelegate_2>(commandNextSubpass2KHR);
			CommandNextSubpass2KHR_3 = Marshal.GetDelegateForFunctionPointer<CommandNextSubpass2KHRDelegate_3>(commandNextSubpass2KHR);
		}
		var commandEndRenderPass2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndRenderPass2");
		if (commandEndRenderPass2KHR != nint.Zero)
		{
			CommandEndRenderPass2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2KHRDelegate_0>(commandEndRenderPass2KHR);
			CommandEndRenderPass2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandEndRenderPass2KHRDelegate_1>(commandEndRenderPass2KHR);
		}
		var getSwapchainStatusKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetSwapchainStatusKHR");
		if (getSwapchainStatusKHR != nint.Zero)
		{
			GetSwapchainStatusKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSwapchainStatusKHRDelegate_0>(getSwapchainStatusKHR);
		}
		var getPhysicalDeviceExternalFencePropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceExternalFenceProperties");
		if (getPhysicalDeviceExternalFencePropertiesKHR != nint.Zero)
		{
			GetPhysicalDeviceExternalFencePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesKHRDelegate_0>(getPhysicalDeviceExternalFencePropertiesKHR);
			GetPhysicalDeviceExternalFencePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceExternalFencePropertiesKHRDelegate_1>(getPhysicalDeviceExternalFencePropertiesKHR);
		}
		var importFenceWin32HandleKHR = (nint)GetInstanceProcedureAddress(instance, "vkImportFenceWin32HandleKHR");
		if (importFenceWin32HandleKHR != nint.Zero)
		{
			ImportFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_0>(importFenceWin32HandleKHR);
			ImportFenceWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportFenceWin32HandleKHRDelegate_1>(importFenceWin32HandleKHR);
		}
		var getFenceWin32HandleKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetFenceWin32HandleKHR");
		if (getFenceWin32HandleKHR != nint.Zero)
		{
			GetFenceWin32HandleKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_0>(getFenceWin32HandleKHR);
			GetFenceWin32HandleKHR_1 = Marshal.GetDelegateForFunctionPointer<GetFenceWin32HandleKHRDelegate_1>(getFenceWin32HandleKHR);
		}
		var importFenceFileDescriptorKHR = (nint)GetInstanceProcedureAddress(instance, "vkImportFenceFdKHR");
		if (importFenceFileDescriptorKHR != nint.Zero)
		{
			ImportFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_0>(importFenceFileDescriptorKHR);
			ImportFenceFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<ImportFenceFileDescriptorKHRDelegate_1>(importFenceFileDescriptorKHR);
		}
		var getFenceFileDescriptorKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetFenceFdKHR");
		if (getFenceFileDescriptorKHR != nint.Zero)
		{
			GetFenceFileDescriptorKHR_0 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_0>(getFenceFileDescriptorKHR);
			GetFenceFileDescriptorKHR_1 = Marshal.GetDelegateForFunctionPointer<GetFenceFileDescriptorKHRDelegate_1>(getFenceFileDescriptorKHR);
		}
		var enumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR = (nint)GetInstanceProcedureAddress(instance, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
		if (enumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR != nint.Zero)
		{
			EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_0 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_0>(enumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR);
			EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_1 = Marshal.GetDelegateForFunctionPointer<EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate_1>(enumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR);
		}
		var getPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
		if (getPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR != nint.Zero)
		{
			GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_0>(getPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR);
			GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate_1>(getPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR);
		}
		var acquireProfilingLockKHR = (nint)GetInstanceProcedureAddress(instance, "vkAcquireProfilingLockKHR");
		if (acquireProfilingLockKHR != nint.Zero)
		{
			AcquireProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<AcquireProfilingLockKHRDelegate_0>(acquireProfilingLockKHR);
			AcquireProfilingLockKHR_1 = Marshal.GetDelegateForFunctionPointer<AcquireProfilingLockKHRDelegate_1>(acquireProfilingLockKHR);
		}
		var releaseProfilingLockKHR = (nint)GetInstanceProcedureAddress(instance, "vkReleaseProfilingLockKHR");
		if (releaseProfilingLockKHR != nint.Zero)
		{
			ReleaseProfilingLockKHR_0 = Marshal.GetDelegateForFunctionPointer<ReleaseProfilingLockKHRDelegate_0>(releaseProfilingLockKHR);
		}
		var getPhysicalDeviceSurfaceCapabilities2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR");
		if (getPhysicalDeviceSurfaceCapabilities2KHR != nint.Zero)
		{
			GetPhysicalDeviceSurfaceCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_0>(getPhysicalDeviceSurfaceCapabilities2KHR);
			GetPhysicalDeviceSurfaceCapabilities2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceCapabilities2KHRDelegate_1>(getPhysicalDeviceSurfaceCapabilities2KHR);
		}
		var getPhysicalDeviceSurfaceFormats2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR");
		if (getPhysicalDeviceSurfaceFormats2KHR != nint.Zero)
		{
			GetPhysicalDeviceSurfaceFormats2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_0>(getPhysicalDeviceSurfaceFormats2KHR);
			GetPhysicalDeviceSurfaceFormats2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_1>(getPhysicalDeviceSurfaceFormats2KHR);
			GetPhysicalDeviceSurfaceFormats2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_2>(getPhysicalDeviceSurfaceFormats2KHR);
			GetPhysicalDeviceSurfaceFormats2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfaceFormats2KHRDelegate_3>(getPhysicalDeviceSurfaceFormats2KHR);
		}
		var getPhysicalDeviceDisplayProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceDisplayProperties2KHR");
		if (getPhysicalDeviceDisplayProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceDisplayProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayProperties2KHRDelegate_0>(getPhysicalDeviceDisplayProperties2KHR);
			GetPhysicalDeviceDisplayProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayProperties2KHRDelegate_1>(getPhysicalDeviceDisplayProperties2KHR);
		}
		var getPhysicalDeviceDisplayPlaneProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
		if (getPhysicalDeviceDisplayPlaneProperties2KHR != nint.Zero)
		{
			GetPhysicalDeviceDisplayPlaneProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_0>(getPhysicalDeviceDisplayPlaneProperties2KHR);
			GetPhysicalDeviceDisplayPlaneProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceDisplayPlaneProperties2KHRDelegate_1>(getPhysicalDeviceDisplayPlaneProperties2KHR);
		}
		var getDisplayModeProperties2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDisplayModeProperties2KHR");
		if (getDisplayModeProperties2KHR != nint.Zero)
		{
			GetDisplayModeProperties2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayModeProperties2KHRDelegate_0>(getDisplayModeProperties2KHR);
			GetDisplayModeProperties2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayModeProperties2KHRDelegate_1>(getDisplayModeProperties2KHR);
		}
		var getDisplayPlaneCapabilities2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDisplayPlaneCapabilities2KHR");
		if (getDisplayPlaneCapabilities2KHR != nint.Zero)
		{
			GetDisplayPlaneCapabilities2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilities2KHRDelegate_0>(getDisplayPlaneCapabilities2KHR);
			GetDisplayPlaneCapabilities2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetDisplayPlaneCapabilities2KHRDelegate_1>(getDisplayPlaneCapabilities2KHR);
		}
		var createMacOSSurfaceMVK = (nint)GetInstanceProcedureAddress(instance, "vkCreateMacOSSurfaceMVK");
		if (createMacOSSurfaceMVK != nint.Zero)
		{
			CreateMacOSSurfaceMVK_0 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_0>(createMacOSSurfaceMVK);
			CreateMacOSSurfaceMVK_1 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_1>(createMacOSSurfaceMVK);
			CreateMacOSSurfaceMVK_2 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_2>(createMacOSSurfaceMVK);
			CreateMacOSSurfaceMVK_3 = Marshal.GetDelegateForFunctionPointer<CreateMacOSSurfaceMVKDelegate_3>(createMacOSSurfaceMVK);
		}
		var setDebugUtilsObjectNameEXT = (nint)GetInstanceProcedureAddress(instance, "vkSetDebugUtilsObjectNameEXT");
		if (setDebugUtilsObjectNameEXT != nint.Zero)
		{
			SetDebugUtilsObjectNameEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectNameEXTDelegate_0>(setDebugUtilsObjectNameEXT);
			SetDebugUtilsObjectNameEXT_1 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectNameEXTDelegate_1>(setDebugUtilsObjectNameEXT);
		}
		var setDebugUtilsObjectTagEXT = (nint)GetInstanceProcedureAddress(instance, "vkSetDebugUtilsObjectTagEXT");
		if (setDebugUtilsObjectTagEXT != nint.Zero)
		{
			SetDebugUtilsObjectTagEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectTagEXTDelegate_0>(setDebugUtilsObjectTagEXT);
			SetDebugUtilsObjectTagEXT_1 = Marshal.GetDelegateForFunctionPointer<SetDebugUtilsObjectTagEXTDelegate_1>(setDebugUtilsObjectTagEXT);
		}
		var queueBeginDebugUtilsLabelEXT = (nint)GetInstanceProcedureAddress(instance, "vkQueueBeginDebugUtilsLabelEXT");
		if (queueBeginDebugUtilsLabelEXT != nint.Zero)
		{
			QueueBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueBeginDebugUtilsLabelEXTDelegate_0>(queueBeginDebugUtilsLabelEXT);
			QueueBeginDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<QueueBeginDebugUtilsLabelEXTDelegate_1>(queueBeginDebugUtilsLabelEXT);
		}
		var queueEndDebugUtilsLabelEXT = (nint)GetInstanceProcedureAddress(instance, "vkQueueEndDebugUtilsLabelEXT");
		if (queueEndDebugUtilsLabelEXT != nint.Zero)
		{
			QueueEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueEndDebugUtilsLabelEXTDelegate_0>(queueEndDebugUtilsLabelEXT);
		}
		var queueInsertDebugUtilsLabelEXT = (nint)GetInstanceProcedureAddress(instance, "vkQueueInsertDebugUtilsLabelEXT");
		if (queueInsertDebugUtilsLabelEXT != nint.Zero)
		{
			QueueInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<QueueInsertDebugUtilsLabelEXTDelegate_0>(queueInsertDebugUtilsLabelEXT);
			QueueInsertDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<QueueInsertDebugUtilsLabelEXTDelegate_1>(queueInsertDebugUtilsLabelEXT);
		}
		var commandBeginDebugUtilsLabelEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdBeginDebugUtilsLabelEXT");
		if (commandBeginDebugUtilsLabelEXT != nint.Zero)
		{
			CommandBeginDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBeginDebugUtilsLabelEXTDelegate_0>(commandBeginDebugUtilsLabelEXT);
			CommandBeginDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBeginDebugUtilsLabelEXTDelegate_1>(commandBeginDebugUtilsLabelEXT);
		}
		var commandEndDebugUtilsLabelEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdEndDebugUtilsLabelEXT");
		if (commandEndDebugUtilsLabelEXT != nint.Zero)
		{
			CommandEndDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandEndDebugUtilsLabelEXTDelegate_0>(commandEndDebugUtilsLabelEXT);
		}
		var commandInsertDebugUtilsLabelEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdInsertDebugUtilsLabelEXT");
		if (commandInsertDebugUtilsLabelEXT != nint.Zero)
		{
			CommandInsertDebugUtilsLabelEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandInsertDebugUtilsLabelEXTDelegate_0>(commandInsertDebugUtilsLabelEXT);
			CommandInsertDebugUtilsLabelEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandInsertDebugUtilsLabelEXTDelegate_1>(commandInsertDebugUtilsLabelEXT);
		}
		var createDebugUtilsMessengerEXT = (nint)GetInstanceProcedureAddress(instance, "vkCreateDebugUtilsMessengerEXT");
		if (createDebugUtilsMessengerEXT != nint.Zero)
		{
			CreateDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_0>(createDebugUtilsMessengerEXT);
			CreateDebugUtilsMessengerEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_1>(createDebugUtilsMessengerEXT);
			CreateDebugUtilsMessengerEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_2>(createDebugUtilsMessengerEXT);
			CreateDebugUtilsMessengerEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateDebugUtilsMessengerEXTDelegate_3>(createDebugUtilsMessengerEXT);
		}
		var destroyDebugUtilsMessengerEXT = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDebugUtilsMessengerEXT");
		if (destroyDebugUtilsMessengerEXT != nint.Zero)
		{
			DestroyDebugUtilsMessengerEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyDebugUtilsMessengerEXTDelegate_0>(destroyDebugUtilsMessengerEXT);
			DestroyDebugUtilsMessengerEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyDebugUtilsMessengerEXTDelegate_1>(destroyDebugUtilsMessengerEXT);
		}
		var submitDebugUtilsMessageEXT = (nint)GetInstanceProcedureAddress(instance, "vkSubmitDebugUtilsMessageEXT");
		if (submitDebugUtilsMessageEXT != nint.Zero)
		{
			SubmitDebugUtilsMessageEXT_0 = Marshal.GetDelegateForFunctionPointer<SubmitDebugUtilsMessageEXTDelegate_0>(submitDebugUtilsMessageEXT);
			SubmitDebugUtilsMessageEXT_1 = Marshal.GetDelegateForFunctionPointer<SubmitDebugUtilsMessageEXTDelegate_1>(submitDebugUtilsMessageEXT);
		}
		var getAndroidHardwareBufferPropertiesANDROID = (nint)GetInstanceProcedureAddress(instance, "vkGetAndroidHardwareBufferPropertiesANDROID");
		if (getAndroidHardwareBufferPropertiesANDROID != nint.Zero)
		{
			GetAndroidHardwareBufferPropertiesANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetAndroidHardwareBufferPropertiesANDROIDDelegate_0>(getAndroidHardwareBufferPropertiesANDROID);
		}
		var getMemoryAndroidHardwareBufferANDROID = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryAndroidHardwareBufferANDROID");
		if (getMemoryAndroidHardwareBufferANDROID != nint.Zero)
		{
			GetMemoryAndroidHardwareBufferANDROID_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryAndroidHardwareBufferANDROIDDelegate_0>(getMemoryAndroidHardwareBufferANDROID);
			GetMemoryAndroidHardwareBufferANDROID_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryAndroidHardwareBufferANDROIDDelegate_1>(getMemoryAndroidHardwareBufferANDROID);
		}
		var commandSetSampleLocationsEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetSampleLocationsEXT");
		if (commandSetSampleLocationsEXT != nint.Zero)
		{
			CommandSetSampleLocationsEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_0>(commandSetSampleLocationsEXT);
			CommandSetSampleLocationsEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandSetSampleLocationsEXTDelegate_1>(commandSetSampleLocationsEXT);
		}
		var getPhysicalDeviceMultisamplePropertiesEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceMultisamplePropertiesEXT");
		if (getPhysicalDeviceMultisamplePropertiesEXT != nint.Zero)
		{
			GetPhysicalDeviceMultisamplePropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceMultisamplePropertiesEXTDelegate_0>(getPhysicalDeviceMultisamplePropertiesEXT);
		}
		var getImageMemoryRequirements2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetImageMemoryRequirements2");
		if (getImageMemoryRequirements2KHR != nint.Zero)
		{
			GetImageMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2KHRDelegate_0>(getImageMemoryRequirements2KHR);
			GetImageMemoryRequirements2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetImageMemoryRequirements2KHRDelegate_1>(getImageMemoryRequirements2KHR);
		}
		var getBufferMemoryRequirements2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferMemoryRequirements2");
		if (getBufferMemoryRequirements2KHR != nint.Zero)
		{
			GetBufferMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2KHRDelegate_0>(getBufferMemoryRequirements2KHR);
			GetBufferMemoryRequirements2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetBufferMemoryRequirements2KHRDelegate_1>(getBufferMemoryRequirements2KHR);
		}
		var getImageSparseMemoryRequirements2KHR = (nint)GetInstanceProcedureAddress(instance, "vkGetImageSparseMemoryRequirements2");
		if (getImageSparseMemoryRequirements2KHR != nint.Zero)
		{
			GetImageSparseMemoryRequirements2KHR_0 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_0>(getImageSparseMemoryRequirements2KHR);
			GetImageSparseMemoryRequirements2KHR_1 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_1>(getImageSparseMemoryRequirements2KHR);
			GetImageSparseMemoryRequirements2KHR_2 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_2>(getImageSparseMemoryRequirements2KHR);
			GetImageSparseMemoryRequirements2KHR_3 = Marshal.GetDelegateForFunctionPointer<GetImageSparseMemoryRequirements2KHRDelegate_3>(getImageSparseMemoryRequirements2KHR);
		}
		var createAccelerationStructureKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateAccelerationStructureKHR");
		if (createAccelerationStructureKHR != nint.Zero)
		{
			CreateAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_0>(createAccelerationStructureKHR);
			CreateAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_1>(createAccelerationStructureKHR);
			CreateAccelerationStructureKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_2>(createAccelerationStructureKHR);
			CreateAccelerationStructureKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureKHRDelegate_3>(createAccelerationStructureKHR);
		}
		var destroyAccelerationStructureKHR = (nint)GetInstanceProcedureAddress(instance, "vkDestroyAccelerationStructureKHR");
		if (destroyAccelerationStructureKHR != nint.Zero)
		{
			DestroyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureKHRDelegate_0>(destroyAccelerationStructureKHR);
			DestroyAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureKHRDelegate_1>(destroyAccelerationStructureKHR);
		}
		var commandBuildAccelerationStructuresKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdBuildAccelerationStructuresKHR");
		if (commandBuildAccelerationStructuresKHR != nint.Zero)
		{
			CommandBuildAccelerationStructuresKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresKHRDelegate_0>(commandBuildAccelerationStructuresKHR);
		}
		var commandBuildAccelerationStructuresIndirectKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdBuildAccelerationStructuresIndirectKHR");
		if (commandBuildAccelerationStructuresIndirectKHR != nint.Zero)
		{
			CommandBuildAccelerationStructuresIndirectKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_0>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_1>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_2 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_2>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_3 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_3>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_4 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_4>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_5 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_5>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_6 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_6>(commandBuildAccelerationStructuresIndirectKHR);
			CommandBuildAccelerationStructuresIndirectKHR_7 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructuresIndirectKHRDelegate_7>(commandBuildAccelerationStructuresIndirectKHR);
		}
		var buildAccelerationStructuresKHR = (nint)GetInstanceProcedureAddress(instance, "vkBuildAccelerationStructuresKHR");
		if (buildAccelerationStructuresKHR != nint.Zero)
		{
			BuildAccelerationStructuresKHR_0 = Marshal.GetDelegateForFunctionPointer<BuildAccelerationStructuresKHRDelegate_0>(buildAccelerationStructuresKHR);
		}
		var copyAccelerationStructureKHR = (nint)GetInstanceProcedureAddress(instance, "vkCopyAccelerationStructureKHR");
		if (copyAccelerationStructureKHR != nint.Zero)
		{
			CopyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureKHRDelegate_0>(copyAccelerationStructureKHR);
			CopyAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureKHRDelegate_1>(copyAccelerationStructureKHR);
		}
		var copyAccelerationStructureToMemoryKHR = (nint)GetInstanceProcedureAddress(instance, "vkCopyAccelerationStructureToMemoryKHR");
		if (copyAccelerationStructureToMemoryKHR != nint.Zero)
		{
			CopyAccelerationStructureToMemoryKHR_0 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureToMemoryKHRDelegate_0>(copyAccelerationStructureToMemoryKHR);
			CopyAccelerationStructureToMemoryKHR_1 = Marshal.GetDelegateForFunctionPointer<CopyAccelerationStructureToMemoryKHRDelegate_1>(copyAccelerationStructureToMemoryKHR);
		}
		var copyMemoryToAccelerationStructureKHR = (nint)GetInstanceProcedureAddress(instance, "vkCopyMemoryToAccelerationStructureKHR");
		if (copyMemoryToAccelerationStructureKHR != nint.Zero)
		{
			CopyMemoryToAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CopyMemoryToAccelerationStructureKHRDelegate_0>(copyMemoryToAccelerationStructureKHR);
			CopyMemoryToAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CopyMemoryToAccelerationStructureKHRDelegate_1>(copyMemoryToAccelerationStructureKHR);
		}
		var writeAccelerationStructuresPropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkWriteAccelerationStructuresPropertiesKHR");
		if (writeAccelerationStructuresPropertiesKHR != nint.Zero)
		{
			WriteAccelerationStructuresPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<WriteAccelerationStructuresPropertiesKHRDelegate_0>(writeAccelerationStructuresPropertiesKHR);
		}
		var commandCopyAccelerationStructureKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyAccelerationStructureKHR");
		if (commandCopyAccelerationStructureKHR != nint.Zero)
		{
			CommandCopyAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureKHRDelegate_0>(commandCopyAccelerationStructureKHR);
			CommandCopyAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureKHRDelegate_1>(commandCopyAccelerationStructureKHR);
		}
		var commandCopyAccelerationStructureToMemoryKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyAccelerationStructureToMemoryKHR");
		if (commandCopyAccelerationStructureToMemoryKHR != nint.Zero)
		{
			CommandCopyAccelerationStructureToMemoryKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureToMemoryKHRDelegate_0>(commandCopyAccelerationStructureToMemoryKHR);
			CommandCopyAccelerationStructureToMemoryKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureToMemoryKHRDelegate_1>(commandCopyAccelerationStructureToMemoryKHR);
		}
		var commandCopyMemoryToAccelerationStructureKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyMemoryToAccelerationStructureKHR");
		if (commandCopyMemoryToAccelerationStructureKHR != nint.Zero)
		{
			CommandCopyMemoryToAccelerationStructureKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyMemoryToAccelerationStructureKHRDelegate_0>(commandCopyMemoryToAccelerationStructureKHR);
			CommandCopyMemoryToAccelerationStructureKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyMemoryToAccelerationStructureKHRDelegate_1>(commandCopyMemoryToAccelerationStructureKHR);
		}
		var getAccelerationStructureDeviceAddressKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetAccelerationStructureDeviceAddressKHR");
		if (getAccelerationStructureDeviceAddressKHR != nint.Zero)
		{
			GetAccelerationStructureDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureDeviceAddressKHRDelegate_0>(getAccelerationStructureDeviceAddressKHR);
		}
		var commandWriteAccelerationStructuresPropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdWriteAccelerationStructuresPropertiesKHR");
		if (commandWriteAccelerationStructuresPropertiesKHR != nint.Zero)
		{
			CommandWriteAccelerationStructuresPropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteAccelerationStructuresPropertiesKHRDelegate_0>(commandWriteAccelerationStructuresPropertiesKHR);
		}
		var getDeviceAccelerationStructureCompatibilityKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceAccelerationStructureCompatibilityKHR");
		if (getDeviceAccelerationStructureCompatibilityKHR != nint.Zero)
		{
			GetDeviceAccelerationStructureCompatibilityKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceAccelerationStructureCompatibilityKHRDelegate_0>(getDeviceAccelerationStructureCompatibilityKHR);
			GetDeviceAccelerationStructureCompatibilityKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceAccelerationStructureCompatibilityKHRDelegate_1>(getDeviceAccelerationStructureCompatibilityKHR);
		}
		var getAccelerationStructureBuildSizesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetAccelerationStructureBuildSizesKHR");
		if (getAccelerationStructureBuildSizesKHR != nint.Zero)
		{
			GetAccelerationStructureBuildSizesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_0>(getAccelerationStructureBuildSizesKHR);
			GetAccelerationStructureBuildSizesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_1>(getAccelerationStructureBuildSizesKHR);
			GetAccelerationStructureBuildSizesKHR_2 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_2>(getAccelerationStructureBuildSizesKHR);
			GetAccelerationStructureBuildSizesKHR_3 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureBuildSizesKHRDelegate_3>(getAccelerationStructureBuildSizesKHR);
		}
		var commandTraceRaysKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdTraceRaysKHR");
		if (commandTraceRaysKHR != nint.Zero)
		{
			CommandTraceRaysKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_0>(commandTraceRaysKHR);
			CommandTraceRaysKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_1>(commandTraceRaysKHR);
			CommandTraceRaysKHR_2 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_2>(commandTraceRaysKHR);
			CommandTraceRaysKHR_3 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_3>(commandTraceRaysKHR);
			CommandTraceRaysKHR_4 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_4>(commandTraceRaysKHR);
			CommandTraceRaysKHR_5 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_5>(commandTraceRaysKHR);
			CommandTraceRaysKHR_6 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_6>(commandTraceRaysKHR);
			CommandTraceRaysKHR_7 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_7>(commandTraceRaysKHR);
			CommandTraceRaysKHR_8 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_8>(commandTraceRaysKHR);
			CommandTraceRaysKHR_9 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_9>(commandTraceRaysKHR);
			CommandTraceRaysKHR_10 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_10>(commandTraceRaysKHR);
			CommandTraceRaysKHR_11 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_11>(commandTraceRaysKHR);
			CommandTraceRaysKHR_12 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_12>(commandTraceRaysKHR);
			CommandTraceRaysKHR_13 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_13>(commandTraceRaysKHR);
			CommandTraceRaysKHR_14 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_14>(commandTraceRaysKHR);
			CommandTraceRaysKHR_15 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysKHRDelegate_15>(commandTraceRaysKHR);
		}
		var createRayTracingPipelinesKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateRayTracingPipelinesKHR");
		if (createRayTracingPipelinesKHR != nint.Zero)
		{
			CreateRayTracingPipelinesKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesKHRDelegate_0>(createRayTracingPipelinesKHR);
			CreateRayTracingPipelinesKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesKHRDelegate_1>(createRayTracingPipelinesKHR);
		}
		var getRayTracingShaderGroupHandlesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetRayTracingShaderGroupHandlesKHR");
		if (getRayTracingShaderGroupHandlesKHR != nint.Zero)
		{
			GetRayTracingShaderGroupHandlesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingShaderGroupHandlesKHRDelegate_0>(getRayTracingShaderGroupHandlesKHR);
		}
		var getRayTracingCaptureReplayShaderGroupHandlesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
		if (getRayTracingCaptureReplayShaderGroupHandlesKHR != nint.Zero)
		{
			GetRayTracingCaptureReplayShaderGroupHandlesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate_0>(getRayTracingCaptureReplayShaderGroupHandlesKHR);
		}
		var commandTraceRaysIndirectKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdTraceRaysIndirectKHR");
		if (commandTraceRaysIndirectKHR != nint.Zero)
		{
			CommandTraceRaysIndirectKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_0>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_1>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_2 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_2>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_3 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_3>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_4 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_4>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_5 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_5>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_6 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_6>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_7 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_7>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_8 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_8>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_9 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_9>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_10 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_10>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_11 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_11>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_12 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_12>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_13 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_13>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_14 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_14>(commandTraceRaysIndirectKHR);
			CommandTraceRaysIndirectKHR_15 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysIndirectKHRDelegate_15>(commandTraceRaysIndirectKHR);
		}
		var getRayTracingShaderGroupStackSizeKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetRayTracingShaderGroupStackSizeKHR");
		if (getRayTracingShaderGroupStackSizeKHR != nint.Zero)
		{
			GetRayTracingShaderGroupStackSizeKHR_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingShaderGroupStackSizeKHRDelegate_0>(getRayTracingShaderGroupStackSizeKHR);
		}
		var commandSetRayTracingPipelineStackSizeKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetRayTracingPipelineStackSizeKHR");
		if (commandSetRayTracingPipelineStackSizeKHR != nint.Zero)
		{
			CommandSetRayTracingPipelineStackSizeKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetRayTracingPipelineStackSizeKHRDelegate_0>(commandSetRayTracingPipelineStackSizeKHR);
		}
		var createSamplerYcbcrConversionKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateSamplerYcbcrConversion");
		if (createSamplerYcbcrConversionKHR != nint.Zero)
		{
			CreateSamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_0>(createSamplerYcbcrConversionKHR);
			CreateSamplerYcbcrConversionKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_1>(createSamplerYcbcrConversionKHR);
			CreateSamplerYcbcrConversionKHR_2 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_2>(createSamplerYcbcrConversionKHR);
			CreateSamplerYcbcrConversionKHR_3 = Marshal.GetDelegateForFunctionPointer<CreateSamplerYcbcrConversionKHRDelegate_3>(createSamplerYcbcrConversionKHR);
		}
		var destroySamplerYcbcrConversionKHR = (nint)GetInstanceProcedureAddress(instance, "vkDestroySamplerYcbcrConversion");
		if (destroySamplerYcbcrConversionKHR != nint.Zero)
		{
			DestroySamplerYcbcrConversionKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionKHRDelegate_0>(destroySamplerYcbcrConversionKHR);
			DestroySamplerYcbcrConversionKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroySamplerYcbcrConversionKHRDelegate_1>(destroySamplerYcbcrConversionKHR);
		}
		var bindBufferMemory2KHR = (nint)GetInstanceProcedureAddress(instance, "vkBindBufferMemory2");
		if (bindBufferMemory2KHR != nint.Zero)
		{
			BindBufferMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<BindBufferMemory2KHRDelegate_0>(bindBufferMemory2KHR);
		}
		var bindImageMemory2KHR = (nint)GetInstanceProcedureAddress(instance, "vkBindImageMemory2");
		if (bindImageMemory2KHR != nint.Zero)
		{
			BindImageMemory2KHR_0 = Marshal.GetDelegateForFunctionPointer<BindImageMemory2KHRDelegate_0>(bindImageMemory2KHR);
		}
		var getImageDrmFormatModifierPropertiesEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetImageDrmFormatModifierPropertiesEXT");
		if (getImageDrmFormatModifierPropertiesEXT != nint.Zero)
		{
			GetImageDrmFormatModifierPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetImageDrmFormatModifierPropertiesEXTDelegate_0>(getImageDrmFormatModifierPropertiesEXT);
		}
		var createValidationCacheEXT = (nint)GetInstanceProcedureAddress(instance, "vkCreateValidationCacheEXT");
		if (createValidationCacheEXT != nint.Zero)
		{
			CreateValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_0>(createValidationCacheEXT);
			CreateValidationCacheEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_1>(createValidationCacheEXT);
			CreateValidationCacheEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_2>(createValidationCacheEXT);
			CreateValidationCacheEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateValidationCacheEXTDelegate_3>(createValidationCacheEXT);
		}
		var destroyValidationCacheEXT = (nint)GetInstanceProcedureAddress(instance, "vkDestroyValidationCacheEXT");
		if (destroyValidationCacheEXT != nint.Zero)
		{
			DestroyValidationCacheEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_0>(destroyValidationCacheEXT);
			DestroyValidationCacheEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyValidationCacheEXTDelegate_1>(destroyValidationCacheEXT);
		}
		var mergeValidationCachesEXT = (nint)GetInstanceProcedureAddress(instance, "vkMergeValidationCachesEXT");
		if (mergeValidationCachesEXT != nint.Zero)
		{
			MergeValidationCachesEXT_0 = Marshal.GetDelegateForFunctionPointer<MergeValidationCachesEXTDelegate_0>(mergeValidationCachesEXT);
		}
		var getValidationCacheDataEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetValidationCacheDataEXT");
		if (getValidationCacheDataEXT != nint.Zero)
		{
			GetValidationCacheDataEXT_0 = Marshal.GetDelegateForFunctionPointer<GetValidationCacheDataEXTDelegate_0>(getValidationCacheDataEXT);
			GetValidationCacheDataEXT_1 = Marshal.GetDelegateForFunctionPointer<GetValidationCacheDataEXTDelegate_1>(getValidationCacheDataEXT);
		}
		var commandBindShadingRateImageNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindShadingRateImageNV");
		if (commandBindShadingRateImageNV != nint.Zero)
		{
			CommandBindShadingRateImageNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBindShadingRateImageNVDelegate_0>(commandBindShadingRateImageNV);
		}
		var commandSetViewportShadingRatePaletteNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetViewportShadingRatePaletteNV");
		if (commandSetViewportShadingRatePaletteNV != nint.Zero)
		{
			CommandSetViewportShadingRatePaletteNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportShadingRatePaletteNVDelegate_0>(commandSetViewportShadingRatePaletteNV);
			CommandSetViewportShadingRatePaletteNV_1 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportShadingRatePaletteNVDelegate_1>(commandSetViewportShadingRatePaletteNV);
		}
		var commandSetCoarseSampleOrderNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetCoarseSampleOrderNV");
		if (commandSetCoarseSampleOrderNV != nint.Zero)
		{
			CommandSetCoarseSampleOrderNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCoarseSampleOrderNVDelegate_0>(commandSetCoarseSampleOrderNV);
		}
		var createAccelerationStructureNV = (nint)GetInstanceProcedureAddress(instance, "vkCreateAccelerationStructureNV");
		if (createAccelerationStructureNV != nint.Zero)
		{
			CreateAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_0>(createAccelerationStructureNV);
			CreateAccelerationStructureNV_1 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_1>(createAccelerationStructureNV);
			CreateAccelerationStructureNV_2 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_2>(createAccelerationStructureNV);
			CreateAccelerationStructureNV_3 = Marshal.GetDelegateForFunctionPointer<CreateAccelerationStructureNVDelegate_3>(createAccelerationStructureNV);
		}
		var destroyAccelerationStructureNV = (nint)GetInstanceProcedureAddress(instance, "vkDestroyAccelerationStructureNV");
		if (destroyAccelerationStructureNV != nint.Zero)
		{
			DestroyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureNVDelegate_0>(destroyAccelerationStructureNV);
			DestroyAccelerationStructureNV_1 = Marshal.GetDelegateForFunctionPointer<DestroyAccelerationStructureNVDelegate_1>(destroyAccelerationStructureNV);
		}
		var getAccelerationStructureMemoryRequirementsNV = (nint)GetInstanceProcedureAddress(instance, "vkGetAccelerationStructureMemoryRequirementsNV");
		if (getAccelerationStructureMemoryRequirementsNV != nint.Zero)
		{
			GetAccelerationStructureMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureMemoryRequirementsNVDelegate_0>(getAccelerationStructureMemoryRequirementsNV);
			GetAccelerationStructureMemoryRequirementsNV_1 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureMemoryRequirementsNVDelegate_1>(getAccelerationStructureMemoryRequirementsNV);
		}
		var bindAccelerationStructureMemoryNV = (nint)GetInstanceProcedureAddress(instance, "vkBindAccelerationStructureMemoryNV");
		if (bindAccelerationStructureMemoryNV != nint.Zero)
		{
			BindAccelerationStructureMemoryNV_0 = Marshal.GetDelegateForFunctionPointer<BindAccelerationStructureMemoryNVDelegate_0>(bindAccelerationStructureMemoryNV);
		}
		var commandBuildAccelerationStructureNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdBuildAccelerationStructureNV");
		if (commandBuildAccelerationStructureNV != nint.Zero)
		{
			CommandBuildAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructureNVDelegate_0>(commandBuildAccelerationStructureNV);
			CommandBuildAccelerationStructureNV_1 = Marshal.GetDelegateForFunctionPointer<CommandBuildAccelerationStructureNVDelegate_1>(commandBuildAccelerationStructureNV);
		}
		var commandCopyAccelerationStructureNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyAccelerationStructureNV");
		if (commandCopyAccelerationStructureNV != nint.Zero)
		{
			CommandCopyAccelerationStructureNV_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyAccelerationStructureNVDelegate_0>(commandCopyAccelerationStructureNV);
		}
		var commandTraceRaysNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdTraceRaysNV");
		if (commandTraceRaysNV != nint.Zero)
		{
			CommandTraceRaysNV_0 = Marshal.GetDelegateForFunctionPointer<CommandTraceRaysNVDelegate_0>(commandTraceRaysNV);
		}
		var createRayTracingPipelinesNV = (nint)GetInstanceProcedureAddress(instance, "vkCreateRayTracingPipelinesNV");
		if (createRayTracingPipelinesNV != nint.Zero)
		{
			CreateRayTracingPipelinesNV_0 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesNVDelegate_0>(createRayTracingPipelinesNV);
			CreateRayTracingPipelinesNV_1 = Marshal.GetDelegateForFunctionPointer<CreateRayTracingPipelinesNVDelegate_1>(createRayTracingPipelinesNV);
		}
		var getRayTracingShaderGroupHandlesNV = (nint)GetInstanceProcedureAddress(instance, "vkGetRayTracingShaderGroupHandlesKHR");
		if (getRayTracingShaderGroupHandlesNV != nint.Zero)
		{
			GetRayTracingShaderGroupHandlesNV_0 = Marshal.GetDelegateForFunctionPointer<GetRayTracingShaderGroupHandlesNVDelegate_0>(getRayTracingShaderGroupHandlesNV);
		}
		var getAccelerationStructureHandleNV = (nint)GetInstanceProcedureAddress(instance, "vkGetAccelerationStructureHandleNV");
		if (getAccelerationStructureHandleNV != nint.Zero)
		{
			GetAccelerationStructureHandleNV_0 = Marshal.GetDelegateForFunctionPointer<GetAccelerationStructureHandleNVDelegate_0>(getAccelerationStructureHandleNV);
		}
		var commandWriteAccelerationStructuresPropertiesNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdWriteAccelerationStructuresPropertiesNV");
		if (commandWriteAccelerationStructuresPropertiesNV != nint.Zero)
		{
			CommandWriteAccelerationStructuresPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteAccelerationStructuresPropertiesNVDelegate_0>(commandWriteAccelerationStructuresPropertiesNV);
		}
		var compileDeferredNV = (nint)GetInstanceProcedureAddress(instance, "vkCompileDeferredNV");
		if (compileDeferredNV != nint.Zero)
		{
			CompileDeferredNV_0 = Marshal.GetDelegateForFunctionPointer<CompileDeferredNVDelegate_0>(compileDeferredNV);
		}
		var getDescriptorSetLayoutSupportKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDescriptorSetLayoutSupport");
		if (getDescriptorSetLayoutSupportKHR != nint.Zero)
		{
			GetDescriptorSetLayoutSupportKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportKHRDelegate_0>(getDescriptorSetLayoutSupportKHR);
			GetDescriptorSetLayoutSupportKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDescriptorSetLayoutSupportKHRDelegate_1>(getDescriptorSetLayoutSupportKHR);
		}
		var commandDrawIndirectCountKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndirectCount");
		if (commandDrawIndirectCountKHR != nint.Zero)
		{
			CommandDrawIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndirectCountKHRDelegate_0>(commandDrawIndirectCountKHR);
		}
		var commandDrawIndexedIndirectCountKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawIndexedIndirectCount");
		if (commandDrawIndexedIndirectCountKHR != nint.Zero)
		{
			CommandDrawIndexedIndirectCountKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawIndexedIndirectCountKHRDelegate_0>(commandDrawIndexedIndirectCountKHR);
		}
		var getMemoryHostPointerPropertiesEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryHostPointerPropertiesEXT");
		if (getMemoryHostPointerPropertiesEXT != nint.Zero)
		{
			GetMemoryHostPointerPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryHostPointerPropertiesEXTDelegate_0>(getMemoryHostPointerPropertiesEXT);
		}
		var commandWriteBufferMarkerAMD = (nint)GetInstanceProcedureAddress(instance, "vkCmdWriteBufferMarkerAMD");
		if (commandWriteBufferMarkerAMD != nint.Zero)
		{
			CommandWriteBufferMarkerAMD_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteBufferMarkerAMDDelegate_0>(commandWriteBufferMarkerAMD);
		}
		var getPhysicalDeviceCalibrateableTimeDomainsEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT");
		if (getPhysicalDeviceCalibrateableTimeDomainsEXT != nint.Zero)
		{
			GetPhysicalDeviceCalibrateableTimeDomainsEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_0>(getPhysicalDeviceCalibrateableTimeDomainsEXT);
			GetPhysicalDeviceCalibrateableTimeDomainsEXT_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate_1>(getPhysicalDeviceCalibrateableTimeDomainsEXT);
		}
		var getCalibratedTimestampsEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetCalibratedTimestampsEXT");
		if (getCalibratedTimestampsEXT != nint.Zero)
		{
			GetCalibratedTimestampsEXT_0 = Marshal.GetDelegateForFunctionPointer<GetCalibratedTimestampsEXTDelegate_0>(getCalibratedTimestampsEXT);
			GetCalibratedTimestampsEXT_1 = Marshal.GetDelegateForFunctionPointer<GetCalibratedTimestampsEXTDelegate_1>(getCalibratedTimestampsEXT);
		}
		var commandDrawMeshTasksNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawMeshTasksNV");
		if (commandDrawMeshTasksNV != nint.Zero)
		{
			CommandDrawMeshTasksNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksNVDelegate_0>(commandDrawMeshTasksNV);
		}
		var commandDrawMeshTasksIndirectNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawMeshTasksIndirectNV");
		if (commandDrawMeshTasksIndirectNV != nint.Zero)
		{
			CommandDrawMeshTasksIndirectNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksIndirectNVDelegate_0>(commandDrawMeshTasksIndirectNV);
		}
		var commandDrawMeshTasksIndirectCountNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawMeshTasksIndirectCountNV");
		if (commandDrawMeshTasksIndirectCountNV != nint.Zero)
		{
			CommandDrawMeshTasksIndirectCountNV_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMeshTasksIndirectCountNVDelegate_0>(commandDrawMeshTasksIndirectCountNV);
		}
		var commandSetExclusiveScissorNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetExclusiveScissorNV");
		if (commandSetExclusiveScissorNV != nint.Zero)
		{
			CommandSetExclusiveScissorNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetExclusiveScissorNVDelegate_0>(commandSetExclusiveScissorNV);
		}
		var commandSetCheckpointNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetCheckpointNV");
		if (commandSetCheckpointNV != nint.Zero)
		{
			CommandSetCheckpointNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCheckpointNVDelegate_0>(commandSetCheckpointNV);
		}
		var getQueueCheckpointDataNV = (nint)GetInstanceProcedureAddress(instance, "vkGetQueueCheckpointDataNV");
		if (getQueueCheckpointDataNV != nint.Zero)
		{
			GetQueueCheckpointDataNV_0 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointDataNVDelegate_0>(getQueueCheckpointDataNV);
			GetQueueCheckpointDataNV_1 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointDataNVDelegate_1>(getQueueCheckpointDataNV);
		}
		var getSemaphoreCounterValueKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetSemaphoreCounterValue");
		if (getSemaphoreCounterValueKHR != nint.Zero)
		{
			GetSemaphoreCounterValueKHR_0 = Marshal.GetDelegateForFunctionPointer<GetSemaphoreCounterValueKHRDelegate_0>(getSemaphoreCounterValueKHR);
		}
		var waitSemaphoresKHR = (nint)GetInstanceProcedureAddress(instance, "vkWaitSemaphores");
		if (waitSemaphoresKHR != nint.Zero)
		{
			WaitSemaphoresKHR_0 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresKHRDelegate_0>(waitSemaphoresKHR);
			WaitSemaphoresKHR_1 = Marshal.GetDelegateForFunctionPointer<WaitSemaphoresKHRDelegate_1>(waitSemaphoresKHR);
		}
		var signalSemaphoreKHR = (nint)GetInstanceProcedureAddress(instance, "vkSignalSemaphore");
		if (signalSemaphoreKHR != nint.Zero)
		{
			SignalSemaphoreKHR_0 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreKHRDelegate_0>(signalSemaphoreKHR);
			SignalSemaphoreKHR_1 = Marshal.GetDelegateForFunctionPointer<SignalSemaphoreKHRDelegate_1>(signalSemaphoreKHR);
		}
		var initializePerformanceApiINTEL = (nint)GetInstanceProcedureAddress(instance, "vkInitializePerformanceApiINTEL");
		if (initializePerformanceApiINTEL != nint.Zero)
		{
			InitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<InitializePerformanceApiINTELDelegate_0>(initializePerformanceApiINTEL);
			InitializePerformanceApiINTEL_1 = Marshal.GetDelegateForFunctionPointer<InitializePerformanceApiINTELDelegate_1>(initializePerformanceApiINTEL);
		}
		var uninitializePerformanceApiINTEL = (nint)GetInstanceProcedureAddress(instance, "vkUninitializePerformanceApiINTEL");
		if (uninitializePerformanceApiINTEL != nint.Zero)
		{
			UninitializePerformanceApiINTEL_0 = Marshal.GetDelegateForFunctionPointer<UninitializePerformanceApiINTELDelegate_0>(uninitializePerformanceApiINTEL);
		}
		var commandSetPerformanceMarkerINTEL = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetPerformanceMarkerINTEL");
		if (commandSetPerformanceMarkerINTEL != nint.Zero)
		{
			CommandSetPerformanceMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceMarkerINTELDelegate_0>(commandSetPerformanceMarkerINTEL);
			CommandSetPerformanceMarkerINTEL_1 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceMarkerINTELDelegate_1>(commandSetPerformanceMarkerINTEL);
		}
		var commandSetPerformanceStreamMarkerINTEL = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetPerformanceStreamMarkerINTEL");
		if (commandSetPerformanceStreamMarkerINTEL != nint.Zero)
		{
			CommandSetPerformanceStreamMarkerINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceStreamMarkerINTELDelegate_0>(commandSetPerformanceStreamMarkerINTEL);
			CommandSetPerformanceStreamMarkerINTEL_1 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceStreamMarkerINTELDelegate_1>(commandSetPerformanceStreamMarkerINTEL);
		}
		var commandSetPerformanceOverrideINTEL = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetPerformanceOverrideINTEL");
		if (commandSetPerformanceOverrideINTEL != nint.Zero)
		{
			CommandSetPerformanceOverrideINTEL_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceOverrideINTELDelegate_0>(commandSetPerformanceOverrideINTEL);
			CommandSetPerformanceOverrideINTEL_1 = Marshal.GetDelegateForFunctionPointer<CommandSetPerformanceOverrideINTELDelegate_1>(commandSetPerformanceOverrideINTEL);
		}
		var acquirePerformanceConfigurationINTEL = (nint)GetInstanceProcedureAddress(instance, "vkAcquirePerformanceConfigurationINTEL");
		if (acquirePerformanceConfigurationINTEL != nint.Zero)
		{
			AcquirePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_0>(acquirePerformanceConfigurationINTEL);
			AcquirePerformanceConfigurationINTEL_1 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_1>(acquirePerformanceConfigurationINTEL);
			AcquirePerformanceConfigurationINTEL_2 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_2>(acquirePerformanceConfigurationINTEL);
			AcquirePerformanceConfigurationINTEL_3 = Marshal.GetDelegateForFunctionPointer<AcquirePerformanceConfigurationINTELDelegate_3>(acquirePerformanceConfigurationINTEL);
		}
		var releasePerformanceConfigurationINTEL = (nint)GetInstanceProcedureAddress(instance, "vkReleasePerformanceConfigurationINTEL");
		if (releasePerformanceConfigurationINTEL != nint.Zero)
		{
			ReleasePerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<ReleasePerformanceConfigurationINTELDelegate_0>(releasePerformanceConfigurationINTEL);
		}
		var queueSetPerformanceConfigurationINTEL = (nint)GetInstanceProcedureAddress(instance, "vkQueueSetPerformanceConfigurationINTEL");
		if (queueSetPerformanceConfigurationINTEL != nint.Zero)
		{
			QueueSetPerformanceConfigurationINTEL_0 = Marshal.GetDelegateForFunctionPointer<QueueSetPerformanceConfigurationINTELDelegate_0>(queueSetPerformanceConfigurationINTEL);
		}
		var getPerformanceParameterINTEL = (nint)GetInstanceProcedureAddress(instance, "vkGetPerformanceParameterINTEL");
		if (getPerformanceParameterINTEL != nint.Zero)
		{
			GetPerformanceParameterINTEL_0 = Marshal.GetDelegateForFunctionPointer<GetPerformanceParameterINTELDelegate_0>(getPerformanceParameterINTEL);
		}
		var setLocalDimmingAMD = (nint)GetInstanceProcedureAddress(instance, "vkSetLocalDimmingAMD");
		if (setLocalDimmingAMD != nint.Zero)
		{
			SetLocalDimmingAMD_0 = Marshal.GetDelegateForFunctionPointer<SetLocalDimmingAMDDelegate_0>(setLocalDimmingAMD);
		}
		var getPhysicalDeviceFragmentShadingRatesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceFragmentShadingRatesKHR");
		if (getPhysicalDeviceFragmentShadingRatesKHR != nint.Zero)
		{
			GetPhysicalDeviceFragmentShadingRatesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFragmentShadingRatesKHRDelegate_0>(getPhysicalDeviceFragmentShadingRatesKHR);
			GetPhysicalDeviceFragmentShadingRatesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceFragmentShadingRatesKHRDelegate_1>(getPhysicalDeviceFragmentShadingRatesKHR);
		}
		var commandSetFragmentShadingRateKHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetFragmentShadingRateKHR");
		if (commandSetFragmentShadingRateKHR != nint.Zero)
		{
			CommandSetFragmentShadingRateKHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetFragmentShadingRateKHRDelegate_0>(commandSetFragmentShadingRateKHR);
			CommandSetFragmentShadingRateKHR_1 = Marshal.GetDelegateForFunctionPointer<CommandSetFragmentShadingRateKHRDelegate_1>(commandSetFragmentShadingRateKHR);
		}
		var getBufferDeviceAddressEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferDeviceAddress");
		if (getBufferDeviceAddressEXT != nint.Zero)
		{
			GetBufferDeviceAddressEXT_0 = Marshal.GetDelegateForFunctionPointer<GetBufferDeviceAddressEXTDelegate_0>(getBufferDeviceAddressEXT);
		}
		var getPhysicalDeviceToolPropertiesEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceToolPropertiesEXT");
		if (getPhysicalDeviceToolPropertiesEXT != nint.Zero)
		{
			GetPhysicalDeviceToolPropertiesEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceToolPropertiesEXTDelegate_0>(getPhysicalDeviceToolPropertiesEXT);
			GetPhysicalDeviceToolPropertiesEXT_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceToolPropertiesEXTDelegate_1>(getPhysicalDeviceToolPropertiesEXT);
		}
		var waitForPresentKHR = (nint)GetInstanceProcedureAddress(instance, "vkWaitForPresentKHR");
		if (waitForPresentKHR != nint.Zero)
		{
			WaitForPresentKHR_0 = Marshal.GetDelegateForFunctionPointer<WaitForPresentKHRDelegate_0>(waitForPresentKHR);
		}
		var getPhysicalDeviceCooperativeMatrixPropertiesNV = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
		if (getPhysicalDeviceCooperativeMatrixPropertiesNV != nint.Zero)
		{
			GetPhysicalDeviceCooperativeMatrixPropertiesNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_0>(getPhysicalDeviceCooperativeMatrixPropertiesNV);
			GetPhysicalDeviceCooperativeMatrixPropertiesNV_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate_1>(getPhysicalDeviceCooperativeMatrixPropertiesNV);
		}
		var getPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
		if (getPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV != nint.Zero)
		{
			GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_0>(getPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV);
			GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate_1>(getPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV);
		}
		var getPhysicalDeviceSurfacePresentModes2EXT = (nint)GetInstanceProcedureAddress(instance, "vkGetPhysicalDeviceSurfacePresentModes2EXT");
		if (getPhysicalDeviceSurfacePresentModes2EXT != nint.Zero)
		{
			GetPhysicalDeviceSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_0>(getPhysicalDeviceSurfacePresentModes2EXT);
			GetPhysicalDeviceSurfacePresentModes2EXT_1 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_1>(getPhysicalDeviceSurfacePresentModes2EXT);
			GetPhysicalDeviceSurfacePresentModes2EXT_2 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_2>(getPhysicalDeviceSurfacePresentModes2EXT);
			GetPhysicalDeviceSurfacePresentModes2EXT_3 = Marshal.GetDelegateForFunctionPointer<GetPhysicalDeviceSurfacePresentModes2EXTDelegate_3>(getPhysicalDeviceSurfacePresentModes2EXT);
		}
		var acquireFullScreenExclusiveModeEXT = (nint)GetInstanceProcedureAddress(instance, "vkAcquireFullScreenExclusiveModeEXT");
		if (acquireFullScreenExclusiveModeEXT != nint.Zero)
		{
			AcquireFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<AcquireFullScreenExclusiveModeEXTDelegate_0>(acquireFullScreenExclusiveModeEXT);
		}
		var releaseFullScreenExclusiveModeEXT = (nint)GetInstanceProcedureAddress(instance, "vkReleaseFullScreenExclusiveModeEXT");
		if (releaseFullScreenExclusiveModeEXT != nint.Zero)
		{
			ReleaseFullScreenExclusiveModeEXT_0 = Marshal.GetDelegateForFunctionPointer<ReleaseFullScreenExclusiveModeEXTDelegate_0>(releaseFullScreenExclusiveModeEXT);
		}
		var getDeviceGroupSurfacePresentModes2EXT = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceGroupSurfacePresentModes2EXT");
		if (getDeviceGroupSurfacePresentModes2EXT != nint.Zero)
		{
			GetDeviceGroupSurfacePresentModes2EXT_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModes2EXTDelegate_0>(getDeviceGroupSurfacePresentModes2EXT);
			GetDeviceGroupSurfacePresentModes2EXT_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceGroupSurfacePresentModes2EXTDelegate_1>(getDeviceGroupSurfacePresentModes2EXT);
		}
		var createHeadlessSurfaceEXT = (nint)GetInstanceProcedureAddress(instance, "vkCreateHeadlessSurfaceEXT");
		if (createHeadlessSurfaceEXT != nint.Zero)
		{
			CreateHeadlessSurfaceEXT_0 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_0>(createHeadlessSurfaceEXT);
			CreateHeadlessSurfaceEXT_1 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_1>(createHeadlessSurfaceEXT);
			CreateHeadlessSurfaceEXT_2 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_2>(createHeadlessSurfaceEXT);
			CreateHeadlessSurfaceEXT_3 = Marshal.GetDelegateForFunctionPointer<CreateHeadlessSurfaceEXTDelegate_3>(createHeadlessSurfaceEXT);
		}
		var getBufferDeviceAddressKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferDeviceAddress");
		if (getBufferDeviceAddressKHR != nint.Zero)
		{
			GetBufferDeviceAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferDeviceAddressKHRDelegate_0>(getBufferDeviceAddressKHR);
		}
		var getBufferOpaqueCaptureAddressKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetBufferOpaqueCaptureAddress");
		if (getBufferOpaqueCaptureAddressKHR != nint.Zero)
		{
			GetBufferOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetBufferOpaqueCaptureAddressKHRDelegate_0>(getBufferOpaqueCaptureAddressKHR);
		}
		var getDeviceMemoryOpaqueCaptureAddressKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceMemoryOpaqueCaptureAddress");
		if (getDeviceMemoryOpaqueCaptureAddressKHR != nint.Zero)
		{
			GetDeviceMemoryOpaqueCaptureAddressKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceMemoryOpaqueCaptureAddressKHRDelegate_0>(getDeviceMemoryOpaqueCaptureAddressKHR);
		}
		var commandSetLineStippleEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetLineStippleEXT");
		if (commandSetLineStippleEXT != nint.Zero)
		{
			CommandSetLineStippleEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLineStippleEXTDelegate_0>(commandSetLineStippleEXT);
		}
		var resetQueryPoolEXT = (nint)GetInstanceProcedureAddress(instance, "vkResetQueryPool");
		if (resetQueryPoolEXT != nint.Zero)
		{
			ResetQueryPoolEXT_0 = Marshal.GetDelegateForFunctionPointer<ResetQueryPoolEXTDelegate_0>(resetQueryPoolEXT);
		}
		var commandSetCullModeEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetCullModeEXT");
		if (commandSetCullModeEXT != nint.Zero)
		{
			CommandSetCullModeEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetCullModeEXTDelegate_0>(commandSetCullModeEXT);
		}
		var commandSetFrontFaceEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetFrontFaceEXT");
		if (commandSetFrontFaceEXT != nint.Zero)
		{
			CommandSetFrontFaceEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetFrontFaceEXTDelegate_0>(commandSetFrontFaceEXT);
		}
		var commandSetPrimitiveTopologyEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetPrimitiveTopologyEXT");
		if (commandSetPrimitiveTopologyEXT != nint.Zero)
		{
			CommandSetPrimitiveTopologyEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPrimitiveTopologyEXTDelegate_0>(commandSetPrimitiveTopologyEXT);
		}
		var commandSetViewportWithCountEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetViewportWithCountEXT");
		if (commandSetViewportWithCountEXT != nint.Zero)
		{
			CommandSetViewportWithCountEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetViewportWithCountEXTDelegate_0>(commandSetViewportWithCountEXT);
		}
		var commandSetScissorWithCountEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetScissorWithCountEXT");
		if (commandSetScissorWithCountEXT != nint.Zero)
		{
			CommandSetScissorWithCountEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetScissorWithCountEXTDelegate_0>(commandSetScissorWithCountEXT);
		}
		var commandBindVertexBuffers2EXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindVertexBuffers2EXT");
		if (commandBindVertexBuffers2EXT != nint.Zero)
		{
			CommandBindVertexBuffers2EXT_0 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_0>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_1 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_1>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_2 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_2>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_3 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_3>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_4 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_4>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_5 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_5>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_6 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_6>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_7 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_7>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_8 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_8>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_9 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_9>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_10 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_10>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_11 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_11>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_12 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_12>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_13 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_13>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_14 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_14>(commandBindVertexBuffers2EXT);
			CommandBindVertexBuffers2EXT_15 = Marshal.GetDelegateForFunctionPointer<CommandBindVertexBuffers2EXTDelegate_15>(commandBindVertexBuffers2EXT);
		}
		var commandSetDepthTestEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthTestEnableEXT");
		if (commandSetDepthTestEnableEXT != nint.Zero)
		{
			CommandSetDepthTestEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthTestEnableEXTDelegate_0>(commandSetDepthTestEnableEXT);
		}
		var commandSetDepthWriteEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthWriteEnableEXT");
		if (commandSetDepthWriteEnableEXT != nint.Zero)
		{
			CommandSetDepthWriteEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthWriteEnableEXTDelegate_0>(commandSetDepthWriteEnableEXT);
		}
		var commandSetDepthCompareOpEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthCompareOpEXT");
		if (commandSetDepthCompareOpEXT != nint.Zero)
		{
			CommandSetDepthCompareOpEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthCompareOpEXTDelegate_0>(commandSetDepthCompareOpEXT);
		}
		var commandSetDepthBoundsTestEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthBoundsTestEnableEXT");
		if (commandSetDepthBoundsTestEnableEXT != nint.Zero)
		{
			CommandSetDepthBoundsTestEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBoundsTestEnableEXTDelegate_0>(commandSetDepthBoundsTestEnableEXT);
		}
		var commandSetStencilTestEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetStencilTestEnableEXT");
		if (commandSetStencilTestEnableEXT != nint.Zero)
		{
			CommandSetStencilTestEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilTestEnableEXTDelegate_0>(commandSetStencilTestEnableEXT);
		}
		var commandSetStencilOpEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetStencilOpEXT");
		if (commandSetStencilOpEXT != nint.Zero)
		{
			CommandSetStencilOpEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetStencilOpEXTDelegate_0>(commandSetStencilOpEXT);
		}
		var createDeferredOperationKHR = (nint)GetInstanceProcedureAddress(instance, "vkCreateDeferredOperationKHR");
		if (createDeferredOperationKHR != nint.Zero)
		{
			CreateDeferredOperationKHR_0 = Marshal.GetDelegateForFunctionPointer<CreateDeferredOperationKHRDelegate_0>(createDeferredOperationKHR);
			CreateDeferredOperationKHR_1 = Marshal.GetDelegateForFunctionPointer<CreateDeferredOperationKHRDelegate_1>(createDeferredOperationKHR);
		}
		var destroyDeferredOperationKHR = (nint)GetInstanceProcedureAddress(instance, "vkDestroyDeferredOperationKHR");
		if (destroyDeferredOperationKHR != nint.Zero)
		{
			DestroyDeferredOperationKHR_0 = Marshal.GetDelegateForFunctionPointer<DestroyDeferredOperationKHRDelegate_0>(destroyDeferredOperationKHR);
			DestroyDeferredOperationKHR_1 = Marshal.GetDelegateForFunctionPointer<DestroyDeferredOperationKHRDelegate_1>(destroyDeferredOperationKHR);
		}
		var getDeferredOperationMaxConcurrencyKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeferredOperationMaxConcurrencyKHR");
		if (getDeferredOperationMaxConcurrencyKHR != nint.Zero)
		{
			GetDeferredOperationMaxConcurrencyKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeferredOperationMaxConcurrencyKHRDelegate_0>(getDeferredOperationMaxConcurrencyKHR);
		}
		var getDeferredOperationResultKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeferredOperationResultKHR");
		if (getDeferredOperationResultKHR != nint.Zero)
		{
			GetDeferredOperationResultKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeferredOperationResultKHRDelegate_0>(getDeferredOperationResultKHR);
		}
		var deferredOperationJoinKHR = (nint)GetInstanceProcedureAddress(instance, "vkDeferredOperationJoinKHR");
		if (deferredOperationJoinKHR != nint.Zero)
		{
			DeferredOperationJoinKHR_0 = Marshal.GetDelegateForFunctionPointer<DeferredOperationJoinKHRDelegate_0>(deferredOperationJoinKHR);
		}
		var getPipelineExecutablePropertiesKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPipelineExecutablePropertiesKHR");
		if (getPipelineExecutablePropertiesKHR != nint.Zero)
		{
			GetPipelineExecutablePropertiesKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_0>(getPipelineExecutablePropertiesKHR);
			GetPipelineExecutablePropertiesKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_1>(getPipelineExecutablePropertiesKHR);
			GetPipelineExecutablePropertiesKHR_2 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_2>(getPipelineExecutablePropertiesKHR);
			GetPipelineExecutablePropertiesKHR_3 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutablePropertiesKHRDelegate_3>(getPipelineExecutablePropertiesKHR);
		}
		var getPipelineExecutableStatisticsKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPipelineExecutableStatisticsKHR");
		if (getPipelineExecutableStatisticsKHR != nint.Zero)
		{
			GetPipelineExecutableStatisticsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_0>(getPipelineExecutableStatisticsKHR);
			GetPipelineExecutableStatisticsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_1>(getPipelineExecutableStatisticsKHR);
			GetPipelineExecutableStatisticsKHR_2 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_2>(getPipelineExecutableStatisticsKHR);
			GetPipelineExecutableStatisticsKHR_3 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableStatisticsKHRDelegate_3>(getPipelineExecutableStatisticsKHR);
		}
		var getPipelineExecutableInternalRepresentationsKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetPipelineExecutableInternalRepresentationsKHR");
		if (getPipelineExecutableInternalRepresentationsKHR != nint.Zero)
		{
			GetPipelineExecutableInternalRepresentationsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_0>(getPipelineExecutableInternalRepresentationsKHR);
			GetPipelineExecutableInternalRepresentationsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_1>(getPipelineExecutableInternalRepresentationsKHR);
			GetPipelineExecutableInternalRepresentationsKHR_2 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_2>(getPipelineExecutableInternalRepresentationsKHR);
			GetPipelineExecutableInternalRepresentationsKHR_3 = Marshal.GetDelegateForFunctionPointer<GetPipelineExecutableInternalRepresentationsKHRDelegate_3>(getPipelineExecutableInternalRepresentationsKHR);
		}
		var getGeneratedCommandsMemoryRequirementsNV = (nint)GetInstanceProcedureAddress(instance, "vkGetGeneratedCommandsMemoryRequirementsNV");
		if (getGeneratedCommandsMemoryRequirementsNV != nint.Zero)
		{
			GetGeneratedCommandsMemoryRequirementsNV_0 = Marshal.GetDelegateForFunctionPointer<GetGeneratedCommandsMemoryRequirementsNVDelegate_0>(getGeneratedCommandsMemoryRequirementsNV);
			GetGeneratedCommandsMemoryRequirementsNV_1 = Marshal.GetDelegateForFunctionPointer<GetGeneratedCommandsMemoryRequirementsNVDelegate_1>(getGeneratedCommandsMemoryRequirementsNV);
		}
		var commandPreprocessGeneratedCommandsNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdPreprocessGeneratedCommandsNV");
		if (commandPreprocessGeneratedCommandsNV != nint.Zero)
		{
			CommandPreprocessGeneratedCommandsNV_0 = Marshal.GetDelegateForFunctionPointer<CommandPreprocessGeneratedCommandsNVDelegate_0>(commandPreprocessGeneratedCommandsNV);
			CommandPreprocessGeneratedCommandsNV_1 = Marshal.GetDelegateForFunctionPointer<CommandPreprocessGeneratedCommandsNVDelegate_1>(commandPreprocessGeneratedCommandsNV);
		}
		var commandExecuteGeneratedCommandsNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdExecuteGeneratedCommandsNV");
		if (commandExecuteGeneratedCommandsNV != nint.Zero)
		{
			CommandExecuteGeneratedCommandsNV_0 = Marshal.GetDelegateForFunctionPointer<CommandExecuteGeneratedCommandsNVDelegate_0>(commandExecuteGeneratedCommandsNV);
			CommandExecuteGeneratedCommandsNV_1 = Marshal.GetDelegateForFunctionPointer<CommandExecuteGeneratedCommandsNVDelegate_1>(commandExecuteGeneratedCommandsNV);
		}
		var commandBindPipelineShaderGroupNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindPipelineShaderGroupNV");
		if (commandBindPipelineShaderGroupNV != nint.Zero)
		{
			CommandBindPipelineShaderGroupNV_0 = Marshal.GetDelegateForFunctionPointer<CommandBindPipelineShaderGroupNVDelegate_0>(commandBindPipelineShaderGroupNV);
		}
		var createIndirectCommandsLayoutNV = (nint)GetInstanceProcedureAddress(instance, "vkCreateIndirectCommandsLayoutNV");
		if (createIndirectCommandsLayoutNV != nint.Zero)
		{
			CreateIndirectCommandsLayoutNV_0 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_0>(createIndirectCommandsLayoutNV);
			CreateIndirectCommandsLayoutNV_1 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_1>(createIndirectCommandsLayoutNV);
			CreateIndirectCommandsLayoutNV_2 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_2>(createIndirectCommandsLayoutNV);
			CreateIndirectCommandsLayoutNV_3 = Marshal.GetDelegateForFunctionPointer<CreateIndirectCommandsLayoutNVDelegate_3>(createIndirectCommandsLayoutNV);
		}
		var destroyIndirectCommandsLayoutNV = (nint)GetInstanceProcedureAddress(instance, "vkDestroyIndirectCommandsLayoutNV");
		if (destroyIndirectCommandsLayoutNV != nint.Zero)
		{
			DestroyIndirectCommandsLayoutNV_0 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVDelegate_0>(destroyIndirectCommandsLayoutNV);
			DestroyIndirectCommandsLayoutNV_1 = Marshal.GetDelegateForFunctionPointer<DestroyIndirectCommandsLayoutNVDelegate_1>(destroyIndirectCommandsLayoutNV);
		}
		var acquireDrmDisplayEXT = (nint)GetInstanceProcedureAddress(instance, "vkAcquireDrmDisplayEXT");
		if (acquireDrmDisplayEXT != nint.Zero)
		{
			AcquireDrmDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<AcquireDrmDisplayEXTDelegate_0>(acquireDrmDisplayEXT);
		}
		var getDrmDisplayEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetDrmDisplayEXT");
		if (getDrmDisplayEXT != nint.Zero)
		{
			GetDrmDisplayEXT_0 = Marshal.GetDelegateForFunctionPointer<GetDrmDisplayEXTDelegate_0>(getDrmDisplayEXT);
		}
		var createPrivateDataSlotEXT = (nint)GetInstanceProcedureAddress(instance, "vkCreatePrivateDataSlotEXT");
		if (createPrivateDataSlotEXT != nint.Zero)
		{
			CreatePrivateDataSlotEXT_0 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotEXTDelegate_0>(createPrivateDataSlotEXT);
			CreatePrivateDataSlotEXT_1 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotEXTDelegate_1>(createPrivateDataSlotEXT);
			CreatePrivateDataSlotEXT_2 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotEXTDelegate_2>(createPrivateDataSlotEXT);
			CreatePrivateDataSlotEXT_3 = Marshal.GetDelegateForFunctionPointer<CreatePrivateDataSlotEXTDelegate_3>(createPrivateDataSlotEXT);
		}
		var destroyPrivateDataSlotEXT = (nint)GetInstanceProcedureAddress(instance, "vkDestroyPrivateDataSlotEXT");
		if (destroyPrivateDataSlotEXT != nint.Zero)
		{
			DestroyPrivateDataSlotEXT_0 = Marshal.GetDelegateForFunctionPointer<DestroyPrivateDataSlotEXTDelegate_0>(destroyPrivateDataSlotEXT);
			DestroyPrivateDataSlotEXT_1 = Marshal.GetDelegateForFunctionPointer<DestroyPrivateDataSlotEXTDelegate_1>(destroyPrivateDataSlotEXT);
		}
		var setPrivateDataEXT = (nint)GetInstanceProcedureAddress(instance, "vkSetPrivateDataEXT");
		if (setPrivateDataEXT != nint.Zero)
		{
			SetPrivateDataEXT_0 = Marshal.GetDelegateForFunctionPointer<SetPrivateDataEXTDelegate_0>(setPrivateDataEXT);
		}
		var getPrivateDataEXT = (nint)GetInstanceProcedureAddress(instance, "vkGetPrivateDataEXT");
		if (getPrivateDataEXT != nint.Zero)
		{
			GetPrivateDataEXT_0 = Marshal.GetDelegateForFunctionPointer<GetPrivateDataEXTDelegate_0>(getPrivateDataEXT);
		}
		var commandSetEvent2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetEvent2KHR");
		if (commandSetEvent2KHR != nint.Zero)
		{
			CommandSetEvent2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandSetEvent2KHRDelegate_0>(commandSetEvent2KHR);
			CommandSetEvent2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandSetEvent2KHRDelegate_1>(commandSetEvent2KHR);
		}
		var commandResetEvent2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdResetEvent2KHR");
		if (commandResetEvent2KHR != nint.Zero)
		{
			CommandResetEvent2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandResetEvent2KHRDelegate_0>(commandResetEvent2KHR);
		}
		var commandWaitEvents2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdWaitEvents2KHR");
		if (commandWaitEvents2KHR != nint.Zero)
		{
			CommandWaitEvents2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandWaitEvents2KHRDelegate_0>(commandWaitEvents2KHR);
		}
		var commandPipelineBarrier2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdPipelineBarrier2KHR");
		if (commandPipelineBarrier2KHR != nint.Zero)
		{
			CommandPipelineBarrier2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrier2KHRDelegate_0>(commandPipelineBarrier2KHR);
			CommandPipelineBarrier2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandPipelineBarrier2KHRDelegate_1>(commandPipelineBarrier2KHR);
		}
		var commandWriteTimestamp2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdWriteTimestamp2KHR");
		if (commandWriteTimestamp2KHR != nint.Zero)
		{
			CommandWriteTimestamp2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteTimestamp2KHRDelegate_0>(commandWriteTimestamp2KHR);
		}
		var queueSubmit2KHR = (nint)GetInstanceProcedureAddress(instance, "vkQueueSubmit2KHR");
		if (queueSubmit2KHR != nint.Zero)
		{
			QueueSubmit2KHR_0 = Marshal.GetDelegateForFunctionPointer<QueueSubmit2KHRDelegate_0>(queueSubmit2KHR);
		}
		var commandWriteBufferMarker2AMD = (nint)GetInstanceProcedureAddress(instance, "vkCmdWriteBufferMarker2AMD");
		if (commandWriteBufferMarker2AMD != nint.Zero)
		{
			CommandWriteBufferMarker2AMD_0 = Marshal.GetDelegateForFunctionPointer<CommandWriteBufferMarker2AMDDelegate_0>(commandWriteBufferMarker2AMD);
		}
		var getQueueCheckpointData2NV = (nint)GetInstanceProcedureAddress(instance, "vkGetQueueCheckpointData2NV");
		if (getQueueCheckpointData2NV != nint.Zero)
		{
			GetQueueCheckpointData2NV_0 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointData2NVDelegate_0>(getQueueCheckpointData2NV);
			GetQueueCheckpointData2NV_1 = Marshal.GetDelegateForFunctionPointer<GetQueueCheckpointData2NVDelegate_1>(getQueueCheckpointData2NV);
		}
		var commandSetFragmentShadingRateEnumNV = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetFragmentShadingRateEnumNV");
		if (commandSetFragmentShadingRateEnumNV != nint.Zero)
		{
			CommandSetFragmentShadingRateEnumNV_0 = Marshal.GetDelegateForFunctionPointer<CommandSetFragmentShadingRateEnumNVDelegate_0>(commandSetFragmentShadingRateEnumNV);
		}
		var commandCopyBuffer2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyBuffer2KHR");
		if (commandCopyBuffer2KHR != nint.Zero)
		{
			CommandCopyBuffer2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBuffer2KHRDelegate_0>(commandCopyBuffer2KHR);
			CommandCopyBuffer2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyBuffer2KHRDelegate_1>(commandCopyBuffer2KHR);
		}
		var commandCopyImage2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyImage2KHR");
		if (commandCopyImage2KHR != nint.Zero)
		{
			CommandCopyImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImage2KHRDelegate_0>(commandCopyImage2KHR);
			CommandCopyImage2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyImage2KHRDelegate_1>(commandCopyImage2KHR);
		}
		var commandCopyBufferToImage2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyBufferToImage2KHR");
		if (commandCopyBufferToImage2KHR != nint.Zero)
		{
			CommandCopyBufferToImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImage2KHRDelegate_0>(commandCopyBufferToImage2KHR);
			CommandCopyBufferToImage2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyBufferToImage2KHRDelegate_1>(commandCopyBufferToImage2KHR);
		}
		var commandCopyImageToBuffer2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdCopyImageToBuffer2KHR");
		if (commandCopyImageToBuffer2KHR != nint.Zero)
		{
			CommandCopyImageToBuffer2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBuffer2KHRDelegate_0>(commandCopyImageToBuffer2KHR);
			CommandCopyImageToBuffer2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandCopyImageToBuffer2KHRDelegate_1>(commandCopyImageToBuffer2KHR);
		}
		var commandBlitImage2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdBlitImage2KHR");
		if (commandBlitImage2KHR != nint.Zero)
		{
			CommandBlitImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandBlitImage2KHRDelegate_0>(commandBlitImage2KHR);
			CommandBlitImage2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandBlitImage2KHRDelegate_1>(commandBlitImage2KHR);
		}
		var commandResolveImage2KHR = (nint)GetInstanceProcedureAddress(instance, "vkCmdResolveImage2KHR");
		if (commandResolveImage2KHR != nint.Zero)
		{
			CommandResolveImage2KHR_0 = Marshal.GetDelegateForFunctionPointer<CommandResolveImage2KHRDelegate_0>(commandResolveImage2KHR);
			CommandResolveImage2KHR_1 = Marshal.GetDelegateForFunctionPointer<CommandResolveImage2KHRDelegate_1>(commandResolveImage2KHR);
		}
		var acquireWinrtDisplayNV = (nint)GetInstanceProcedureAddress(instance, "vkAcquireWinrtDisplayNV");
		if (acquireWinrtDisplayNV != nint.Zero)
		{
			AcquireWinrtDisplayNV_0 = Marshal.GetDelegateForFunctionPointer<AcquireWinrtDisplayNVDelegate_0>(acquireWinrtDisplayNV);
		}
		var getWinrtDisplayNV = (nint)GetInstanceProcedureAddress(instance, "vkGetWinrtDisplayNV");
		if (getWinrtDisplayNV != nint.Zero)
		{
			GetWinrtDisplayNV_0 = Marshal.GetDelegateForFunctionPointer<GetWinrtDisplayNVDelegate_0>(getWinrtDisplayNV);
		}
		var commandSetVertexInputEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetVertexInputEXT");
		if (commandSetVertexInputEXT != nint.Zero)
		{
			CommandSetVertexInputEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetVertexInputEXTDelegate_0>(commandSetVertexInputEXT);
		}
		var getDeviceSubpassShadingMaxWorkgroupSizeHUAWEI = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
		if (getDeviceSubpassShadingMaxWorkgroupSizeHUAWEI != nint.Zero)
		{
			GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate_0>(getDeviceSubpassShadingMaxWorkgroupSizeHUAWEI);
		}
		var commandSubpassShadingHUAWEI = (nint)GetInstanceProcedureAddress(instance, "vkCmdSubpassShadingHUAWEI");
		if (commandSubpassShadingHUAWEI != nint.Zero)
		{
			CommandSubpassShadingHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<CommandSubpassShadingHUAWEIDelegate_0>(commandSubpassShadingHUAWEI);
		}
		var commandBindInvocationMaskHUAWEI = (nint)GetInstanceProcedureAddress(instance, "vkCmdBindInvocationMaskHUAWEI");
		if (commandBindInvocationMaskHUAWEI != nint.Zero)
		{
			CommandBindInvocationMaskHUAWEI_0 = Marshal.GetDelegateForFunctionPointer<CommandBindInvocationMaskHUAWEIDelegate_0>(commandBindInvocationMaskHUAWEI);
		}
		var getMemoryRemoteAddressNV = (nint)GetInstanceProcedureAddress(instance, "vkGetMemoryRemoteAddressNV");
		if (getMemoryRemoteAddressNV != nint.Zero)
		{
			GetMemoryRemoteAddressNV_0 = Marshal.GetDelegateForFunctionPointer<GetMemoryRemoteAddressNVDelegate_0>(getMemoryRemoteAddressNV);
			GetMemoryRemoteAddressNV_1 = Marshal.GetDelegateForFunctionPointer<GetMemoryRemoteAddressNVDelegate_1>(getMemoryRemoteAddressNV);
		}
		var commandSetPatchControlPointsEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetPatchControlPointsEXT");
		if (commandSetPatchControlPointsEXT != nint.Zero)
		{
			CommandSetPatchControlPointsEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPatchControlPointsEXTDelegate_0>(commandSetPatchControlPointsEXT);
		}
		var commandSetRasterizerDiscardEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetRasterizerDiscardEnableEXT");
		if (commandSetRasterizerDiscardEnableEXT != nint.Zero)
		{
			CommandSetRasterizerDiscardEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetRasterizerDiscardEnableEXTDelegate_0>(commandSetRasterizerDiscardEnableEXT);
		}
		var commandSetDepthBiasEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetDepthBiasEnableEXT");
		if (commandSetDepthBiasEnableEXT != nint.Zero)
		{
			CommandSetDepthBiasEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetDepthBiasEnableEXTDelegate_0>(commandSetDepthBiasEnableEXT);
		}
		var commandSetLogicOpEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetLogicOpEXT");
		if (commandSetLogicOpEXT != nint.Zero)
		{
			CommandSetLogicOpEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetLogicOpEXTDelegate_0>(commandSetLogicOpEXT);
		}
		var commandSetPrimitiveRestartEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetPrimitiveRestartEnableEXT");
		if (commandSetPrimitiveRestartEnableEXT != nint.Zero)
		{
			CommandSetPrimitiveRestartEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetPrimitiveRestartEnableEXTDelegate_0>(commandSetPrimitiveRestartEnableEXT);
		}
		var commandSetColorWriteEnableEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdSetColorWriteEnableEXT");
		if (commandSetColorWriteEnableEXT != nint.Zero)
		{
			CommandSetColorWriteEnableEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandSetColorWriteEnableEXTDelegate_0>(commandSetColorWriteEnableEXT);
			CommandSetColorWriteEnableEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandSetColorWriteEnableEXTDelegate_1>(commandSetColorWriteEnableEXT);
		}
		var commandDrawMultiEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawMultiEXT");
		if (commandDrawMultiEXT != nint.Zero)
		{
			CommandDrawMultiEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiEXTDelegate_0>(commandDrawMultiEXT);
			CommandDrawMultiEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiEXTDelegate_1>(commandDrawMultiEXT);
		}
		var commandDrawMultiIndexedEXT = (nint)GetInstanceProcedureAddress(instance, "vkCmdDrawMultiIndexedEXT");
		if (commandDrawMultiIndexedEXT != nint.Zero)
		{
			CommandDrawMultiIndexedEXT_0 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_0>(commandDrawMultiIndexedEXT);
			CommandDrawMultiIndexedEXT_1 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_1>(commandDrawMultiIndexedEXT);
			CommandDrawMultiIndexedEXT_2 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_2>(commandDrawMultiIndexedEXT);
			CommandDrawMultiIndexedEXT_3 = Marshal.GetDelegateForFunctionPointer<CommandDrawMultiIndexedEXTDelegate_3>(commandDrawMultiIndexedEXT);
		}
		var setDeviceMemoryPriorityEXT = (nint)GetInstanceProcedureAddress(instance, "vkSetDeviceMemoryPriorityEXT");
		if (setDeviceMemoryPriorityEXT != nint.Zero)
		{
			SetDeviceMemoryPriorityEXT_0 = Marshal.GetDelegateForFunctionPointer<SetDeviceMemoryPriorityEXTDelegate_0>(setDeviceMemoryPriorityEXT);
		}
		var getDeviceBufferMemoryRequirementsKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceBufferMemoryRequirementsKHR");
		if (getDeviceBufferMemoryRequirementsKHR != nint.Zero)
		{
			GetDeviceBufferMemoryRequirementsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceBufferMemoryRequirementsKHRDelegate_0>(getDeviceBufferMemoryRequirementsKHR);
			GetDeviceBufferMemoryRequirementsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceBufferMemoryRequirementsKHRDelegate_1>(getDeviceBufferMemoryRequirementsKHR);
		}
		var getDeviceImageMemoryRequirementsKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceImageMemoryRequirementsKHR");
		if (getDeviceImageMemoryRequirementsKHR != nint.Zero)
		{
			GetDeviceImageMemoryRequirementsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageMemoryRequirementsKHRDelegate_0>(getDeviceImageMemoryRequirementsKHR);
			GetDeviceImageMemoryRequirementsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageMemoryRequirementsKHRDelegate_1>(getDeviceImageMemoryRequirementsKHR);
		}
		var getDeviceImageSparseMemoryRequirementsKHR = (nint)GetInstanceProcedureAddress(instance, "vkGetDeviceImageSparseMemoryRequirementsKHR");
		if (getDeviceImageSparseMemoryRequirementsKHR != nint.Zero)
		{
			GetDeviceImageSparseMemoryRequirementsKHR_0 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsKHRDelegate_0>(getDeviceImageSparseMemoryRequirementsKHR);
			GetDeviceImageSparseMemoryRequirementsKHR_1 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsKHRDelegate_1>(getDeviceImageSparseMemoryRequirementsKHR);
			GetDeviceImageSparseMemoryRequirementsKHR_2 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsKHRDelegate_2>(getDeviceImageSparseMemoryRequirementsKHR);
			GetDeviceImageSparseMemoryRequirementsKHR_3 = Marshal.GetDelegateForFunctionPointer<GetDeviceImageSparseMemoryRequirementsKHRDelegate_3>(getDeviceImageSparseMemoryRequirementsKHR);
		}
	}
}
