// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing.Processors.Effects;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Defines extension methods that allow the application of user defined processing delegate to an <see cref="Image"/>.
    /// </summary>
    public static class PixelRowDelegateExtensions
    {
        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(PixelConversionModifiers.None));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(modifiers));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, Rectangle rectangle)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(PixelConversionModifiers.None), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, Rectangle rectangle, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(modifiers), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(rowDelegate, PixelConversionModifiers.None));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(rowDelegate, modifiers));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate, Rectangle rectangle)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(rowDelegate, PixelConversionModifiers.None), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate, Rectangle rectangle, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate
            => source.ApplyProcessor(new PixelRowDelegateProcessor<TDelegate>(rowDelegate, modifiers), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation rowOperation)
            => ProcessPixelRowsAsVector4(source, rowOperation, PixelConversionModifiers.None);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation rowOperation, PixelConversionModifiers modifiers)
            => source.ApplyProcessor(new PixelRowDelegateProcessor<PixelRowDelegate>(new PixelRowDelegate(rowOperation), modifiers));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation rowOperation, Rectangle rectangle)
            => ProcessPixelRowsAsVector4(source, rowOperation, rectangle, PixelConversionModifiers.None);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation rowOperation, Rectangle rectangle, PixelConversionModifiers modifiers)
            => source.ApplyProcessor(new PixelRowDelegateProcessor<PixelRowDelegate>(new PixelRowDelegate(rowOperation), modifiers), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(PixelConversionModifiers.None));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(modifiers));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, Rectangle rectangle)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(PixelConversionModifiers.None), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, Rectangle rectangle, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(modifiers), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(rowDelegate, PixelConversionModifiers.None));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(rowDelegate, modifiers));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate, Rectangle rectangle)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(rowDelegate, PixelConversionModifiers.None), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <typeparam name="TDelegate">The type of user defined, row processing delegate to use.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowDelegate">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4<TDelegate>(this IImageProcessingContext source, TDelegate rowDelegate, Rectangle rectangle, PixelConversionModifiers modifiers)
            where TDelegate : struct, IPixelRowDelegate<Point>
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor<TDelegate>(rowDelegate, modifiers), rectangle);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation<Point> rowOperation)
            => ProcessPositionAwarePixelRowsAsVector4(source, rowOperation, PixelConversionModifiers.None);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation<Point> rowOperation, PixelConversionModifiers modifiers)
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor(rowOperation, modifiers));

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation<Point> rowOperation, Rectangle rectangle)
            => ProcessPositionAwarePixelRowsAsVector4(source, rowOperation, rectangle, PixelConversionModifiers.None);

        /// <summary>
        /// Applies a user defined processing delegate to the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rowOperation">The user defined processing delegate to use to modify image rows.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <param name="modifiers">The <see cref="PixelConversionModifiers"/> to apply during the pixel conversions.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext ProcessPositionAwarePixelRowsAsVector4(this IImageProcessingContext source, PixelRowOperation<Point> rowOperation, Rectangle rectangle, PixelConversionModifiers modifiers)
            => source.ApplyProcessor(new PositionAwarePixelRowDelegateProcessor(rowOperation, modifiers), rectangle);
    }
}
