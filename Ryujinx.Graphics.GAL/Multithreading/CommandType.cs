﻿namespace Ryujinx.Graphics.GAL.Multithreading
{
    enum CommandType : byte
    {
        Action,
        CompileShader,
        CreateBuffer,
        CreateProgram,
        CreateSampler,
        CreateSync,
        CreateTexture,
        GetCapabilities,
        Unused,
        PreFrame,
        ReportCounter,
        ResetCounter,
        UpdateCounters,

        BufferDispose,
        BufferGetData,
        BufferSetData,

        CounterEventDispose,
        CounterEventFlush,

        ProgramDispose,
        ProgramGetBinary,
        ProgramCheckLink,

        SamplerDispose,

        ShaderDispose,

        TextureCopyTo,
        TextureCopyToScaled,
        TextureCopyToSlice,
        TextureCreateView,
        TextureGetData,
        TextureRelease,
        TextureSetData,
        TextureSetDataSlice,
        TextureSetStorage,

        WindowPresent,

        Barrier,
        BeginTransformFeedback,
        ClearBuffer,
        ClearRenderTargetColor,
        ClearRenderTargetDepthStencil,
        CommandBufferBarrier,
        CopyBuffer,
        DispatchCompute,
        Draw,
        DrawIndexed,
        EndHostConditionalRendering,
        EndTransformFeedback,
        MultiDrawIndirectCount,
        MultiDrawIndexedIndirectCount,
        SetAlphaTest,
        SetBlendState,
        SetDepthBias,
        SetDepthClamp,
        SetDepthMode,
        SetDepthTest,
        SetFaceCulling,
        SetFrontFace,
        SetStorageBuffers,
        SetTransformFeedbackBuffers,
        SetUniformBuffers,
        SetImage,
        SetIndexBuffer,
        SetLineParameters,
        SetLogicOpState,
        SetPointParameters,
        SetPrimitiveRestart,
        SetPrimitiveTopology,
        SetProgram,
        SetRasterizerDiscard,
        SetRenderTargetColorMasks,
        SetRenderTargetScale,
        SetRenderTargets,
        SetSampler,
        SetScissor,
        SetStencilTest,
        SetTexture,
        SetUserClipDistance,
        SetVertexAttribs,
        SetVertexBuffers,
        SetViewports,
        TextureBarrier,
        TextureBarrierTiled,
        TryHostConditionalRendering,
        TryHostConditionalRenderingFlush,
        UpdateRenderScale
    }
}
