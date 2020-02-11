# CustomListView

### 困りごと

Xamarin.Forms 4.5.0.282-pre4 + WPF で StackLayout 内に ListView を配置すると、先頭要素のみサイズが小さくなり内容が表示されない。



### 調査結果

CustomRenderer により、ListView の DataTemplate を WPF (各PF) に委譲することで表示できた。

~~XPF開発の意味がない…~~



### 調査で出会ったサイト

- [Xamarin.Forms.WPFでListViewのViewCellをウインドウ幅に追従させる](https://qiita.com/f-miyu/items/cadb22ff866719b3fb26)

- [ソースコード　FormsPanel](https://github.com/xamarin/Xamarin.Forms/blob/master/Xamarin.Forms.Platform.WPF/FormsPanel.cs)

- [レンダラーの基本クラスおよびネイティブ コントロール](https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/custom-renderer/renderers)
- [ViewCell のカスタマイズ](https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/custom-renderer/viewcell)



### 追記

Xamarin.Forms の Issues に挙がってた。2020/2/11時点では Open。

Ver3.6.0.XXX なら動作した。

[[Bug] [WPF] Grid + ListView -> first row height not correct](https://github.com/xamarin/Xamarin.Forms/issues/6436)



以上