# G8 POS Demo

可部署的飲料店 POS Web Demo。

目前定位：
- **Demo / MVP UI 驗證版**
- 適合先驗證平板操作流程、櫃台畫面與點單體驗
- 尚未接正式資料庫、帳號、支付或店內硬體橋接

## 目前已完成
- .NET 8 / Blazor Web App
- 商品分類與搜尋
- 商品選擇與客製化（糖度 / 冰量 / 加料）
- 購物車
- 模擬結帳
- 模擬訂單號
- 最近完成訂單列表
- 櫃台式版面配置
- Render 部署準備（Dockerfile / render.yaml）

## 本機執行
```powershell
dotnet run --project .\POS\src\G8.PosDemo.Web\G8.PosDemo.Web.csproj
```

預設會在類似下列網址啟動：
- `http://localhost:5083`

## 建置
```powershell
dotnet build .\POS\G8.PosDemo.sln
```

## Publish
```powershell
dotnet publish .\POS\src\G8.PosDemo.Web\G8.PosDemo.Web.csproj -c Release -o .\POS\publish\G8.PosDemo.Web
```

## Render 部署
已補：
- `POS/render.yaml`
- `POS/src/G8.PosDemo.Web/Dockerfile`
- `POS/RENDER.md`

如果要走 Render，建議把 `POS/` 抽成獨立 GitHub repo，再用 Render Blueprint 或手動建立 Web Service。

## Demo 部署建議
這個版本適合先部署為 **外網可訪問的 Demo**，例如：
- Render
- Azure App Service
- Railway

建議先把它當作：
- UI / UX 驗證站
- 平板試用站
- 流程驗證站

而不是正式營運 POS。

## 目前限制
- 無正式資料庫
- 無登入 / 權限控管
- 無支付整合
- 無庫存同步
- 無店內列印 / 發票 / 錢櫃硬體橋接

## 下一步建議
1. 抽出假資料到獨立 service / model
2. 加入支付區與更完整結帳流程
3. 實際部署到 Render 做平板遠端試用
4. 之後再接正式資料模型與 PostgreSQL
