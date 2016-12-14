# Multi-Style for WPF

WpfMultiStyle 是用于 WPF 中，使控件同时应用多个 Style，类似于 HTML 中 `class="class1 class2 class3"`。

## 使用

### 引入命名空间
```C#
xmlns:wms="clr-namespace:WpfMultiStyle;assembly=WpfMultiStyle"
```

### 应用样式
以  `Button` 为例：
```C#
<Button Style="{wms:MultiStyle btn btn-default btn-lg}" Content="Large button" />
```

### 运行效果
![demo](https://github.com/PxAndy/WpfMultiStyle/blob/master/demo.png)

## 参考
[How to apply multiple styles in WPF](http://stackoverflow.com/questions/16096/how-to-apply-multiple-styles-in-wpf)
