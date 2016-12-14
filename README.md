# Multi-Style for WPF

WpfMultiStyle 是用于 WPF 中，使控件同时应用多个 Style，类似于 HTML 中 `class="class1 class2 class3"`。

## 使用

### 引入命名空间[Nuget](https://www.nuget.org/packages/WpfMultiStyle/)
```C#
xmlns:wms="clr-namespace:WpfMultiStyle;assembly=WpfMultiStyle"
```

### 应用样式
目前有两种方式。一种是通过MarkupExtension扩展，这种有点儿缺陷，在设计时不能直接实时显示效果，需要把 Style 剪切再粘贴才会显示真正的效果。一种是通过附加属性，这个是实时显示效果的。
以`Button` 为例：
```C#
<Button Style="{wms:MultiStyle btn btn-default btn-lg}" Content="Large button" />
<Button wms:Apply.MultiStyle="btn btn-primary btn-lg" Content="Large button" />
```

### 效果
![demo](https://github.com/PxAndy/WpfMultiStyle/blob/master/demo.png)

## 参考
[How to apply multiple styles in WPF](http://stackoverflow.com/questions/16096/how-to-apply-multiple-styles-in-wpf)
